namespace RSpkDetector
{
    partial class Overlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.lblPkers = new System.Windows.Forms.Label();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.SuspendLayout();
        	// 
        	// lblPkers
        	// 
        	this.lblPkers.AutoSize = true;
        	this.lblPkers.Location = new System.Drawing.Point(-1, 21);
        	this.lblPkers.Name = "lblPkers";
        	this.lblPkers.Size = new System.Drawing.Size(10, 13);
        	this.lblPkers.TabIndex = 0;
        	this.lblPkers.Text = " ";
        	// 
        	// panel1
        	// 
        	this.panel1.Location = new System.Drawing.Point(-1, 1);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(495, 275);
        	this.panel1.TabIndex = 2;
        	// 
        	// Overlay
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(493, 274);
        	this.Controls.Add(this.panel1);
        	this.Controls.Add(this.lblPkers);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.Name = "Overlay";
        	this.Text = "Overlay";
        	this.TopMost = true;
        	this.Load += new System.EventHandler(this.Overlay_Load);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Panel panel1;

        #endregion

        
        private System.Windows.Forms.Label lblPkers;
    }
}