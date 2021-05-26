
namespace demo
{
    partial class fLoading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLoading));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mdaVideo = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.mdaVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 3400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mdaVideo
            // 
            this.mdaVideo.Enabled = true;
            this.mdaVideo.Location = new System.Drawing.Point(1, 1);
            this.mdaVideo.Name = "mdaVideo";
            this.mdaVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mdaVideo.OcxState")));
            this.mdaVideo.Size = new System.Drawing.Size(660, 400);
            this.mdaVideo.TabIndex = 0;
            this.mdaVideo.Enter += new System.EventHandler(this.mdaVideo_Enter);
            // 
            // fLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(660, 400);
            this.Controls.Add(this.mdaVideo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLoading";
            this.Load += new System.EventHandler(this.fLoading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mdaVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer mdaVideo;
    }
}