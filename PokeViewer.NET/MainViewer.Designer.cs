using PokeViewer.NET.Properties;

namespace PokeViewer.NET
{
    partial class MainViewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainViewer));
            this.Connect = new System.Windows.Forms.Button();
            this.SwitchIP = new System.Windows.Forms.TextBox();
            this.OriginIcon = new System.Windows.Forms.PictureBox();
            this.WindowCapture = new System.Windows.Forms.Button();
            this.DayCareView = new System.Windows.Forms.Button();
            this.InGameScreenshot = new System.Windows.Forms.Button();
            this.outbreakCrawler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OriginIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(19, 32);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 25);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // SwitchIP
            // 
            this.SwitchIP.Location = new System.Drawing.Point(19, 6);
            this.SwitchIP.Name = "SwitchIP";
            this.SwitchIP.Size = new System.Drawing.Size(128, 23);
            this.SwitchIP.TabIndex = 2;
            this.SwitchIP.Text = "192.168.0.0";
            this.SwitchIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SwitchIP.TextChanged += new System.EventHandler(this.CheckForIP);
            // 
            // OriginIcon
            // 
            this.OriginIcon.ImageLocation = "https://raw.githubusercontent.com/zyro670/PokeTextures/main/OriginMarks/icon_gene" +
    "ration_00%5Esb.png";
            this.OriginIcon.Location = new System.Drawing.Point(169, 31);
            this.OriginIcon.Name = "OriginIcon";
            this.OriginIcon.Size = new System.Drawing.Size(64, 64);
            this.OriginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OriginIcon.TabIndex = 10;
            this.OriginIcon.TabStop = false;
            // 
            // WindowCapture
            // 
            this.WindowCapture.Image = ((System.Drawing.Image)(resources.GetObject("WindowCapture.Image")));
            this.WindowCapture.Location = new System.Drawing.Point(109, 33);
            this.WindowCapture.Name = "WindowCapture";
            this.WindowCapture.Size = new System.Drawing.Size(37, 25);
            this.WindowCapture.TabIndex = 20;
            this.WindowCapture.UseVisualStyleBackColor = true;
            this.WindowCapture.Click += new System.EventHandler(this.CaptureWindow_Click);
            // 
            // DayCareView
            // 
            this.DayCareView.Location = new System.Drawing.Point(316, 4);
            this.DayCareView.Name = "DayCareView";
            this.DayCareView.Size = new System.Drawing.Size(75, 25);
            this.DayCareView.TabIndex = 27;
            this.DayCareView.Text = "Egg View";
            this.DayCareView.UseVisualStyleBackColor = true;
            this.DayCareView.Visible = false;
            this.DayCareView.Click += new System.EventHandler(this.DayCareView_Click);
            // 
            // InGameScreenshot
            // 
            this.InGameScreenshot.Image = ((System.Drawing.Image)(resources.GetObject("InGameScreenshot.Image")));
            this.InGameScreenshot.Location = new System.Drawing.Point(109, 64);
            this.InGameScreenshot.Name = "InGameScreenshot";
            this.InGameScreenshot.Size = new System.Drawing.Size(37, 25);
            this.InGameScreenshot.TabIndex = 30;
            this.InGameScreenshot.UseVisualStyleBackColor = true;
            this.InGameScreenshot.Click += new System.EventHandler(this.InGameScreenshot_Click);
            // 
            // outbreakCrawler
            // 
            this.outbreakCrawler.Location = new System.Drawing.Point(316, 35);
            this.outbreakCrawler.Name = "outbreakCrawler";
            this.outbreakCrawler.Size = new System.Drawing.Size(75, 25);
            this.outbreakCrawler.TabIndex = 31;
            this.outbreakCrawler.Text = "Outbreak";
            this.outbreakCrawler.UseVisualStyleBackColor = true;
            this.outbreakCrawler.Visible = false;
            this.outbreakCrawler.Click += new System.EventHandler(this.OutbreakCrawler_Click);
            // 
            // MainViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(405, 106);
            this.Controls.Add(this.outbreakCrawler);
            this.Controls.Add(this.InGameScreenshot);
            this.Controls.Add(this.DayCareView);
            this.Controls.Add(this.WindowCapture);
            this.Controls.Add(this.OriginIcon);
            this.Controls.Add(this.SwitchIP);
            this.Controls.Add(this.Connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainViewer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PokeViewer.NET";
            this.Load += new System.EventHandler(this.PokeViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OriginIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Connect;
        private TextBox SwitchIP;
        private PictureBox OriginIcon;
        private Button WindowCapture;
        private Button DayCareView;
        private Button InGameScreenshot;
        private Button outbreakCrawler;
    }
}