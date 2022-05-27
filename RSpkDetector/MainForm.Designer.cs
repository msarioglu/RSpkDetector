/*
 * Created by SharpDevelop.
 * User: Bayram1995
 * Date: 16-4-2017
 * Time: 13:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RSpkDetector
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.cbWindows = new System.Windows.Forms.ComboBox();
            this.txtHandle = new System.Windows.Forms.TextBox();
            this.txtWindowname = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.xPos = new System.Windows.Forms.NumericUpDown();
            this.arcX = new System.Windows.Forms.NumericUpDown();
            this.userX = new System.Windows.Forms.NumericUpDown();
            this.yPos = new System.Windows.Forms.NumericUpDown();
            this.arcY = new System.Windows.Forms.NumericUpDown();
            this.userY = new System.Windows.Forms.NumericUpDown();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.arcWidth = new System.Windows.Forms.NumericUpDown();
            this.userWidth = new System.Windows.Forms.NumericUpDown();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.arcHeight = new System.Windows.Forms.NumericUpDown();
            this.userHeight = new System.Windows.Forms.NumericUpDown();
            this.CheckIntervalTimer = new System.Windows.Forms.NumericUpDown();
            this.StartButton = new System.Windows.Forms.Button();
            this.arcOverlay = new System.Windows.Forms.CheckBox();
            this.red = new System.Windows.Forms.NumericUpDown();
            this.green = new System.Windows.Forms.NumericUpDown();
            this.blue = new System.Windows.Forms.NumericUpDown();
            this.timerCompare = new System.Windows.Forms.Timer(this.components);
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.WarningBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckIntervalTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarningBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cbWindows
            // 
            this.cbWindows.FormattingEnabled = true;
            this.cbWindows.Location = new System.Drawing.Point(17, 12);
            this.cbWindows.Name = "cbWindows";
            this.cbWindows.Size = new System.Drawing.Size(409, 21);
            this.cbWindows.TabIndex = 0;
            this.cbWindows.SelectedIndexChanged += new System.EventHandler(this.cbWindows_SelectedIndexChanged);
            // 
            // txtHandle
            // 
            this.txtHandle.Enabled = false;
            this.txtHandle.Location = new System.Drawing.Point(17, 48);
            this.txtHandle.Name = "txtHandle";
            this.txtHandle.Size = new System.Drawing.Size(229, 20);
            this.txtHandle.TabIndex = 1;
            // 
            // txtWindowname
            // 
            this.txtWindowname.Enabled = false;
            this.txtWindowname.Location = new System.Drawing.Point(17, 74);
            this.txtWindowname.Name = "txtWindowname";
            this.txtWindowname.Size = new System.Drawing.Size(360, 20);
            this.txtWindowname.TabIndex = 2;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(252, 46);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(125, 22);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.BtnPreviewClick);
            // 
            // xPos
            // 
            this.xPos.Location = new System.Drawing.Point(17, 100);
            this.xPos.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.xPos.Name = "xPos";
            this.xPos.Size = new System.Drawing.Size(66, 20);
            this.xPos.TabIndex = 4;
            this.xPos.Value = new decimal(new int[] {
            560,
            0,
            0,
            0});
            // 
            // arcX
            // 
            this.arcX.Location = new System.Drawing.Point(89, 100);
            this.arcX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.arcX.Name = "arcX";
            this.arcX.Size = new System.Drawing.Size(66, 20);
            this.arcX.TabIndex = 5;
            // 
            // userX
            // 
            this.userX.Location = new System.Drawing.Point(161, 100);
            this.userX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.userX.Name = "userX";
            this.userX.Size = new System.Drawing.Size(66, 20);
            this.userX.TabIndex = 6;
            this.userX.Value = new decimal(new int[] {
            82,
            0,
            0,
            0});
            // 
            // yPos
            // 
            this.yPos.Location = new System.Drawing.Point(17, 126);
            this.yPos.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.yPos.Name = "yPos";
            this.yPos.Size = new System.Drawing.Size(66, 20);
            this.yPos.TabIndex = 7;
            this.yPos.Value = new decimal(new int[] {
            33,
            0,
            0,
            0});
            // 
            // arcY
            // 
            this.arcY.Location = new System.Drawing.Point(89, 126);
            this.arcY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.arcY.Name = "arcY";
            this.arcY.Size = new System.Drawing.Size(66, 20);
            this.arcY.TabIndex = 8;
            // 
            // userY
            // 
            this.userY.Location = new System.Drawing.Point(161, 126);
            this.userY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.userY.Name = "userY";
            this.userY.Size = new System.Drawing.Size(66, 20);
            this.userY.TabIndex = 9;
            this.userY.Value = new decimal(new int[] {
            82,
            0,
            0,
            0});
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(17, 152);
            this.width.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(66, 20);
            this.width.TabIndex = 10;
            this.width.Value = new decimal(new int[] {
            245,
            0,
            0,
            0});
            // 
            // arcWidth
            // 
            this.arcWidth.Location = new System.Drawing.Point(89, 152);
            this.arcWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.arcWidth.Name = "arcWidth";
            this.arcWidth.Size = new System.Drawing.Size(66, 20);
            this.arcWidth.TabIndex = 11;
            this.arcWidth.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // userWidth
            // 
            this.userWidth.Location = new System.Drawing.Point(161, 152);
            this.userWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.userWidth.Name = "userWidth";
            this.userWidth.Size = new System.Drawing.Size(66, 20);
            this.userWidth.TabIndex = 12;
            this.userWidth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(17, 178);
            this.height.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(66, 20);
            this.height.TabIndex = 13;
            this.height.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // arcHeight
            // 
            this.arcHeight.Location = new System.Drawing.Point(89, 178);
            this.arcHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.arcHeight.Name = "arcHeight";
            this.arcHeight.Size = new System.Drawing.Size(66, 20);
            this.arcHeight.TabIndex = 14;
            this.arcHeight.Value = new decimal(new int[] {
            162,
            0,
            0,
            0});
            // 
            // userHeight
            // 
            this.userHeight.Location = new System.Drawing.Point(161, 178);
            this.userHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.userHeight.Name = "userHeight";
            this.userHeight.Size = new System.Drawing.Size(66, 20);
            this.userHeight.TabIndex = 15;
            this.userHeight.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // CheckIntervalTimer
            // 
            this.CheckIntervalTimer.Location = new System.Drawing.Point(233, 178);
            this.CheckIntervalTimer.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CheckIntervalTimer.Name = "CheckIntervalTimer";
            this.CheckIntervalTimer.Size = new System.Drawing.Size(66, 20);
            this.CheckIntervalTimer.TabIndex = 16;
            this.CheckIntervalTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(305, 176);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(71, 21);
            this.StartButton.TabIndex = 17;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // arcOverlay
            // 
            this.arcOverlay.Location = new System.Drawing.Point(235, 102);
            this.arcOverlay.Name = "arcOverlay";
            this.arcOverlay.Size = new System.Drawing.Size(17, 17);
            this.arcOverlay.TabIndex = 18;
            this.arcOverlay.Text = "checkBox1";
            this.arcOverlay.UseVisualStyleBackColor = true;
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(311, 100);
            this.red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(66, 20);
            this.red.TabIndex = 19;
            this.red.Value = new decimal(new int[] {
            254,
            0,
            0,
            0});
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(311, 126);
            this.green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(66, 20);
            this.green.TabIndex = 20;
            this.green.Value = new decimal(new int[] {
            254,
            0,
            0,
            0});
            // 
            // blue
            // 
            this.blue.Location = new System.Drawing.Point(311, 150);
            this.blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(66, 20);
            this.blue.TabIndex = 21;
            this.blue.Value = new decimal(new int[] {
            254,
            0,
            0,
            0});
            // 
            // timerCompare
            // 
            this.timerCompare.Interval = 1000;
            this.timerCompare.Tick += new System.EventHandler(this.TimerCompareTick);
            // 
            // pbColor
            // 
            this.pbColor.Location = new System.Drawing.Point(252, 105);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(53, 51);
            this.pbColor.TabIndex = 22;
            this.pbColor.TabStop = false;
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(382, 47);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(166, 150);
            this.pbPreview.TabIndex = 23;
            this.pbPreview.TabStop = false;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(439, 12);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(109, 22);
            this.RefreshButton.TabIndex = 24;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButtonClick);
            // 
            // WarningBox
            // 
            this.WarningBox.Location = new System.Drawing.Point(10, 207);
            this.WarningBox.Name = "WarningBox";
            this.WarningBox.Size = new System.Drawing.Size(367, 43);
            this.WarningBox.TabIndex = 25;
            this.WarningBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 24);
            this.button1.TabIndex = 27;
            this.button1.Text = "Overlay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WarningBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.pbColor);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.green);
            this.Controls.Add(this.red);
            this.Controls.Add(this.arcOverlay);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CheckIntervalTimer);
            this.Controls.Add(this.userHeight);
            this.Controls.Add(this.arcHeight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.userWidth);
            this.Controls.Add(this.arcWidth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.userY);
            this.Controls.Add(this.arcY);
            this.Controls.Add(this.yPos);
            this.Controls.Add(this.userX);
            this.Controls.Add(this.arcX);
            this.Controls.Add(this.xPos);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.txtWindowname);
            this.Controls.Add(this.txtHandle);
            this.Controls.Add(this.cbWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "RSpkDetector";
            ((System.ComponentModel.ISupportInitialize)(this.xPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckIntervalTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarningBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox WarningBox;
		private System.Windows.Forms.Button RefreshButton;
		private System.Windows.Forms.PictureBox pbPreview;
		private System.Windows.Forms.PictureBox pbColor;
		private System.Windows.Forms.Timer timerCompare;
		private System.Windows.Forms.NumericUpDown blue;
		private System.Windows.Forms.NumericUpDown green;
		private System.Windows.Forms.NumericUpDown red;
		private System.Windows.Forms.CheckBox arcOverlay;
		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.NumericUpDown CheckIntervalTimer;
		private System.Windows.Forms.NumericUpDown userHeight;
		private System.Windows.Forms.NumericUpDown arcHeight;
		private System.Windows.Forms.NumericUpDown height;
		private System.Windows.Forms.NumericUpDown userWidth;
		private System.Windows.Forms.NumericUpDown arcWidth;
		private System.Windows.Forms.NumericUpDown width;
		private System.Windows.Forms.NumericUpDown userY;
		private System.Windows.Forms.NumericUpDown arcY;
		private System.Windows.Forms.NumericUpDown yPos;
		private System.Windows.Forms.NumericUpDown userX;
		private System.Windows.Forms.NumericUpDown arcX;
		private System.Windows.Forms.NumericUpDown xPos;
		private System.Windows.Forms.Button btnPreview;
		private System.Windows.Forms.TextBox txtWindowname;
		private System.Windows.Forms.TextBox txtHandle;
		private System.Windows.Forms.ComboBox cbWindows;
	}
}
