using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RSpkDetector
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        Dictionary<IntPtr, string> windowList = new Dictionary<IntPtr, string>();
        IntPtr ptrhandle;
        private Overlay overlay;
		bool showOverlay = false;
		
		
        public MainForm()
        {
            InitializeComponent();
			overlay = new Overlay();
        }
        
		protected override void OnLoad(EventArgs e)
		{
 			getWindows(cbWindows);  
			base.OnLoad(e);
		}
		
		
        private void getWindows(ComboBox List)
        {
            IntPtr hWnd = IntPtr.Zero;
            windowList.Clear();
            List.Items.Clear();
            foreach (Process pList in Process.GetProcesses())
            {
                if ((pList.MainWindowHandle.ToString() != "0") && (pList.MainWindowTitle != ""))
                {
                    
                    
                    windowList.Add(pList.MainWindowHandle, pList.MainWindowTitle);
                    List.Items.Add(pList.MainWindowHandle + ": " + pList.MainWindowTitle);
                }
            }
        }

        public static int Distance(Point p1, Point p2)
        {
            int dx = p1.X - p2.X;
            int dy = p1.Y - p2.Y;

            double distance = Math.Sqrt(dx * dx + dy * dy);

            return (int)Math.Round(distance, MidpointRounding.AwayFromZero);
        }

        private void cbWindows_SelectedIndexChanged(object sender, EventArgs e)
        {
            string window = cbWindows.SelectedItem.ToString();

            string windowHandle = window.Substring(0, window.IndexOf(":"));
            ptrhandle = new IntPtr(Convert.ToInt32(windowHandle));

            string windowName = window.Substring(window.IndexOf(":") + 1);

            if (windowList.ContainsKey(ptrhandle))
            {
                txtHandle.Text = "Window Handle: " + ptrhandle.ToString();
                txtWindowname.Text = "Window Name: " + windowName;
            }
        }
        

        public Image CaptureWindow(IntPtr handle)
        {
            IntPtr hdcSrc = User32.GetWindowDC(handle);
            User32.RECT windowRect = new User32.RECT();
            User32.GetWindowRect(handle, ref windowRect);
            int width = windowRect.right - windowRect.left;
            int height = windowRect.bottom - windowRect.top;
            IntPtr hdcDest = GDI32.CreateCompatibleDC(hdcSrc);
            IntPtr hBitmap = GDI32.CreateCompatibleBitmap(hdcSrc, width, height);
            IntPtr hOld = GDI32.SelectObject(hdcDest, hBitmap);
            GDI32.BitBlt(hdcDest, 0, 0, width, height, hdcSrc, 0, 0, GDI32.SRCCOPY);
            GDI32.SelectObject(hdcDest, hOld);
            GDI32.DeleteDC(hdcDest);
            User32.ReleaseDC(handle, hdcSrc);
            Image img = Image.FromHbitmap(hBitmap);
            GDI32.DeleteObject(hBitmap);
            return img;
        }

        public static Image CropToCircle(Image srcImage, Color backGround, int x, int y, int width, int height)
        {
            Image dstImage = new Bitmap(srcImage.Width, srcImage.Height, srcImage.PixelFormat);
            Graphics g = Graphics.FromImage(dstImage);
            using (Brush br = new SolidBrush(backGround))
            {
                g.FillRectangle(br, 0, 0, dstImage.Width, dstImage.Height);
            }
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(x, y, width, height);
            g.SetClip(path);
            g.DrawImage(srcImage, 0, 0);
            return dstImage;
        }

        public static Bitmap cropAtRect(Bitmap b, Rectangle r, int userX, int userY, int userWidth, int userHeight)
        {
            Bitmap nb = new Bitmap(r.Width, r.Height);
            Graphics g = Graphics.FromImage(nb);
            SolidBrush brush = new SolidBrush(Color.FromArgb(255, 0, 255));
            
            g.DrawImage(b, -r.X, -r.Y);
            g.FillEllipse(brush, userX, userY, userWidth, userHeight);

            return nb;
        }

        private void pbPreview_MouseUp(object sender, MouseEventArgs e)
        {
            int widthP = Convert.ToInt32(e.X / (Convert.ToDecimal(pbPreview.Width) / 100));
            int heightP = Convert.ToInt32(e.Y / (Convert.ToDecimal(pbPreview.Height) / 100));

            Bitmap b = new Bitmap(pbPreview.BackgroundImage);

            decimal widthM = (Convert.ToDecimal(b.Width) / 100);
            decimal heightM = (Convert.ToDecimal(b.Height) / 100);

            Color color = b.GetPixel(Convert.ToInt32(widthP * widthM), Convert.ToInt32(heightP * heightM));

            red.Value = color.R;
            green.Value = color.G;
            blue.Value = color.B;

            pbColor.BackColor = Color.FromArgb(color.R, color.G, color.B);
        }


		void BtnPreviewClick(object sender, EventArgs e)
		{
            Image screenshot = CaptureWindow(ptrhandle);

            Rectangle cropRect = new Rectangle(Convert.ToInt32(xPos.Value), Convert.ToInt32(yPos.Value), Convert.ToInt32(width.Value), Convert.ToInt32(height.Value));
            Bitmap bitmapScreenshot = new Bitmap(screenshot);

            screenshot = cropAtRect(bitmapScreenshot, cropRect, Convert.ToInt32(userX.Value), Convert.ToInt32(userY.Value), Convert.ToInt32(userWidth.Value), Convert.ToInt32(userHeight.Value));

            if (arcOverlay.Checked == true)
            {
                screenshot = CropToCircle(screenshot, Color.Black, Convert.ToInt32(arcX.Value), Convert.ToInt32(arcY.Value), Convert.ToInt32(arcWidth.Value), Convert.ToInt32(arcHeight.Value));
            }

            pbPreview.BackgroundImage = screenshot;
		}
		int detectedPlayers =0;
        Bitmap bitmapScreenshot = null;
        Bitmap compareScreenshot = null;
        Color current;
        Image screenshot;

        Rectangle selectedRegion = new Rectangle();
        public Rectangle cropRect()
        {
            selectedRegion.X = Convert.ToInt32(xPos.Value);
            selectedRegion.Y = Convert.ToInt32(yPos.Value);
            selectedRegion.Width = Convert.ToInt32(width.Value);
            selectedRegion.Height = Convert.ToInt32(height.Value);
            return selectedRegion;
        }
        
        void TimerCompareTick(object sender, EventArgs e)
		{
            try
            {

                screenshot = CaptureWindow(ptrhandle);

                bitmapScreenshot = new Bitmap(screenshot);

                screenshot = cropAtRect(bitmapScreenshot, cropRect(), Convert.ToInt32(userX.Value), Convert.ToInt32(userY.Value), Convert.ToInt32(userWidth.Value), Convert.ToInt32(userHeight.Value));

                screenshot = CropToCircle(screenshot, Color.Black, Convert.ToInt32(arcX.Value), Convert.ToInt32(arcY.Value), Convert.ToInt32(arcWidth.Value), Convert.ToInt32(arcHeight.Value));
                pbPreview.BackgroundImage = screenshot;
                compareScreenshot = new Bitmap(screenshot);

                WarningBox.BackColor = Color.FromArgb(0, 255, 0);
                detectedPlayers = 0;
                for (int y = 0; y < compareScreenshot.Height; y++)
                {
                    for (int x = 0; x < compareScreenshot.Width; x++)
                    {
                        current = compareScreenshot.GetPixel(x, y);

                        if ((current.R == red.Value) && (current.G == green.Value) && (current.B == blue.Value))
                        {
                            detectedPlayers++;
                            if (detectedPlayers / 7 > 0)
                                WarningBox.BackColor = Color.FromArgb(255, 0, 0);
                        }

                    }
                }
                if(showOverlay) { 
					overlay.DrawOnWindow(ptrhandle, "" + detectedPlayers / 7);
                }
                label1.Text = "Players: " + (detectedPlayers / 7).ToString();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally
            {
                bitmapScreenshot.Dispose();
                compareScreenshot.Dispose();
                GC.Collect();
            }
        }
        
        public void getPlayers ()
        {}
		
		void StartButtonClick(object sender, EventArgs e)
		{
			
            if (StartButton.Text == "Start")
            {
                WarningBox.BackColor = Color.FromArgb(0, 255, 0);
                timerCompare.Interval = Convert.ToInt32(CheckIntervalTimer.Value);
                timerCompare.Start();
                StartButton.Text = "Stop";

            }
            else {
                timerCompare.Stop();
                StartButton.Text = "Start";
            }
		}
		
		void RefreshButtonClick(object sender, EventArgs e)
		{
            getWindows(cbWindows);  
		}

		void Button1Click(object sender, EventArgs e)
		{
            overlay.Show();
            showOverlay = true;
			
		}
    }
}