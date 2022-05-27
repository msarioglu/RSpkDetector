using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;

namespace RSpkDetector
{
    public partial class Overlay : Form
    {
    	
    	[DllImport("User32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
		[DllImport("User32.dll")]
		public static extern void ReleaseDC(IntPtr hwnd, IntPtr dc);
		public static string users = "0";

		private const int SWP_NOMOVE     = 0x0002;
		private const int SWP_NOSIZE     = 0x0001;
		private const int SWP_SHOWWINDOW = 0x0040;

		private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
		
		public enum GWL
		{
		    ExStyle = -20
		}

		public enum WS_EX
		{
		    Transparent = 0x20,
		    Layered = 0x80000,
		}
		
		public enum LWA
		{
		    ColorKey = 0x1,
		    Alpha = 0x2
		}
		
		[DllImport("user32.dll", EntryPoint = "GetWindowLong")]
		public static extern int GetWindowLong(IntPtr hWnd, GWL nIndex);
		
		[DllImport("user32.dll", EntryPoint = "SetWindowLong")]
		public static extern int SetWindowLong(IntPtr hWnd, GWL nIndex, int dwNewLong);
		
		[DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
		public static extern bool SetLayeredWindowAttributes(IntPtr hWnd, int crKey, byte alpha, LWA dwFlags);
		[DllImport("user32.dll")]
		static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
		
		
		
		protected override void OnShown(EventArgs e)
		{
		    base.OnShown(e);
		    int wl = GetWindowLong(this.Handle, GWL.ExStyle);
		    wl = wl | 0x80000 | 0x20;
		    SetWindowLong(this.Handle, GWL.ExStyle, wl);
		    //SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
		    //SetLayeredWindowAttributes(this.Handle, 0, 128, LWA.Alpha);


		}
		
		
		
        public Overlay()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        

        public void DrawOnWindow(IntPtr handle, String Text)
        {
            IntPtr hdcSrc = User32.GetWindowDC(handle);
            User32.RECT windowRect = new User32.RECT();
            User32.GetWindowRect(handle, ref windowRect);
            int width = windowRect.right - windowRect.left;
            int height = windowRect.bottom - windowRect.top;
            
        	IntPtr desktop = User32.GetDC(IntPtr.Zero);
			//Graphics g = Graphics.FromHdc(desktop);
			panel1.Paint+=new PaintEventHandler(DrawPkers);
        	panel1.Refresh();
        	users = Text;
        	this.Left = windowRect.left + 420;
        	this.Top = windowRect.top + 490;

            //User32.ReleaseDC(handle, hdcSrc);
        }
        
        public void DrawPkers(object sender, PaintEventArgs e)
        {
        	//Graphics g = CreateGraphics();
            var g = e.Graphics;
        	Font fy = new Font("Helvetica", 10, FontStyle.Bold);
        	Pen myp = new Pen(System.Drawing.Color.Red, 4);
        	Brush br;
            
        	e.Graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixel;
        	//e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
        	if (users == "0") {
        	br = new SolidBrush(System.Drawing.Color.Green);
        	} else {
        	br = new SolidBrush(System.Drawing.Color.Red);
        	}
            g.DrawString("Players: " + users, fy, br, 0,0);
        }

        private void Overlay_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
        }
    }
}
