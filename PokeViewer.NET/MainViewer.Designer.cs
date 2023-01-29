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
            this.View = new System.Windows.Forms.Button();
            this.ViewBox = new System.Windows.Forms.TextBox();
            this.PokeSprite = new System.Windows.Forms.PictureBox();
            this.Specialty = new System.Windows.Forms.PictureBox();
            this.OriginIcon = new System.Windows.Forms.PictureBox();
            this.Typing1 = new System.Windows.Forms.PictureBox();
            this.HidePIDEC = new System.Windows.Forms.CheckBox();
            this.Typing2 = new System.Windows.Forms.PictureBox();
            this.LiveStats = new System.Windows.Forms.TextBox();
            this.RefreshStats = new System.Windows.Forms.CheckBox();
            this.RefreshBox = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.Label();
            this.TodaysDate = new System.Windows.Forms.Label();
            this.WindowCapture = new System.Windows.Forms.Button();
            this.HpLabel = new System.Windows.Forms.Label();
            this.UniqueBox = new System.Windows.Forms.CheckBox();
            this.UniqueBox2 = new System.Windows.Forms.CheckBox();
            this.WideView = new System.Windows.Forms.Button();
            this.BoxViewer = new System.Windows.Forms.Button();
            this.TrainerView = new System.Windows.Forms.Button();
            this.DayCareView = new System.Windows.Forms.Button();
            this.OverworldView = new System.Windows.Forms.Button();
            this.InGameScreenshot = new System.Windows.Forms.Button();
            this.Raids = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PokeSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Specialty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Typing1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Typing2)).BeginInit();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(27, 53);
            this.Connect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(107, 42);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // SwitchIP
            // 
            this.SwitchIP.Location = new System.Drawing.Point(27, 10);
            this.SwitchIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SwitchIP.Name = "SwitchIP";
            this.SwitchIP.Size = new System.Drawing.Size(181, 31);
            this.SwitchIP.TabIndex = 2;
            this.SwitchIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SwitchIP.TextChanged += new System.EventHandler(this.CheckForIP);
            // 
            // View
            // 
            this.View.Enabled = false;
            this.View.Location = new System.Drawing.Point(254, 435);
            this.View.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(67, 38);
            this.View.TabIndex = 3;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Visible = false;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // ViewBox
            // 
            this.ViewBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ViewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ViewBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ViewBox.Location = new System.Drawing.Point(27, 167);
            this.ViewBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewBox.Multiline = true;
            this.ViewBox.Name = "ViewBox";
            this.ViewBox.ReadOnly = true;
            this.ViewBox.Size = new System.Drawing.Size(229, 235);
            this.ViewBox.TabIndex = 4;
            this.ViewBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ViewBox.Visible = false;
            // 
            // PokeSprite
            // 
            this.PokeSprite.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PokeSprite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PokeSprite.Location = new System.Drawing.Point(317, 167);
            this.PokeSprite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PokeSprite.Name = "PokeSprite";
            this.PokeSprite.Size = new System.Drawing.Size(229, 235);
            this.PokeSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PokeSprite.TabIndex = 7;
            this.PokeSprite.TabStop = false;
            // 
            // Specialty
            // 
            this.Specialty.Location = new System.Drawing.Point(254, 480);
            this.Specialty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Specialty.Name = "Specialty";
            this.Specialty.Size = new System.Drawing.Size(67, 68);
            this.Specialty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Specialty.TabIndex = 8;
            this.Specialty.TabStop = false;
            // 
            // OriginIcon
            // 
            this.OriginIcon.ImageLocation = "https://raw.githubusercontent.com/zyro670/PokeTextures/main/OriginMarks/icon_gene" +
    "ration_00%5Esb.png";
            this.OriginIcon.Location = new System.Drawing.Point(241, 52);
            this.OriginIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OriginIcon.Name = "OriginIcon";
            this.OriginIcon.Size = new System.Drawing.Size(64, 64);
            this.OriginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OriginIcon.TabIndex = 10;
            this.OriginIcon.TabStop = false;
            this.OriginIcon.Click += new System.EventHandler(this.OriginIcon_Click);
            // 
            // Typing1
            // 
            this.Typing1.Location = new System.Drawing.Point(341, 437);
            this.Typing1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Typing1.Name = "Typing1";
            this.Typing1.Size = new System.Drawing.Size(206, 45);
            this.Typing1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Typing1.TabIndex = 12;
            this.Typing1.TabStop = false;
            // 
            // HidePIDEC
            // 
            this.HidePIDEC.AutoSize = true;
            this.HidePIDEC.Location = new System.Drawing.Point(27, 113);
            this.HidePIDEC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HidePIDEC.Name = "HidePIDEC";
            this.HidePIDEC.Size = new System.Drawing.Size(135, 29);
            this.HidePIDEC.TabIndex = 13;
            this.HidePIDEC.Text = "Hide PID/EC";
            this.HidePIDEC.UseVisualStyleBackColor = true;
            this.HidePIDEC.Visible = false;
            this.HidePIDEC.CheckedChanged += new System.EventHandler(this.CheckForHide);
            // 
            // Typing2
            // 
            this.Typing2.Location = new System.Drawing.Point(343, 492);
            this.Typing2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Typing2.Name = "Typing2";
            this.Typing2.Size = new System.Drawing.Size(204, 43);
            this.Typing2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Typing2.TabIndex = 14;
            this.Typing2.TabStop = false;
            // 
            // LiveStats
            // 
            this.LiveStats.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LiveStats.Location = new System.Drawing.Point(27, 437);
            this.LiveStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LiveStats.Multiline = true;
            this.LiveStats.Name = "LiveStats";
            this.LiveStats.ReadOnly = true;
            this.LiveStats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LiveStats.Size = new System.Drawing.Size(205, 109);
            this.LiveStats.TabIndex = 15;
            this.LiveStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RefreshStats
            // 
            this.RefreshStats.AutoSize = true;
            this.RefreshStats.Location = new System.Drawing.Point(27, 405);
            this.RefreshStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RefreshStats.Name = "RefreshStats";
            this.RefreshStats.Size = new System.Drawing.Size(106, 29);
            this.RefreshStats.TabIndex = 16;
            this.RefreshStats.Text = "LiveStats";
            this.RefreshStats.UseVisualStyleBackColor = true;
            this.RefreshStats.CheckedChanged += new System.EventHandler(this.RefreshStats_CheckedChanged);
            // 
            // RefreshBox
            // 
            this.RefreshBox.Location = new System.Drawing.Point(146, 552);
            this.RefreshBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RefreshBox.Name = "RefreshBox";
            this.RefreshBox.Size = new System.Drawing.Size(63, 31);
            this.RefreshBox.TabIndex = 17;
            this.RefreshBox.Text = "2000";
            this.RefreshBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RefreshBox.Visible = false;
            // 
            // Refresh
            // 
            this.Refresh.AutoSize = true;
            this.Refresh.Location = new System.Drawing.Point(34, 558);
            this.Refresh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(114, 25);
            this.Refresh.TabIndex = 18;
            this.Refresh.Text = "Refresh Rate:";
            this.Refresh.Visible = false;
            // 
            // TodaysDate
            // 
            this.TodaysDate.AutoSize = true;
            this.TodaysDate.Location = new System.Drawing.Point(356, 558);
            this.TodaysDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TodaysDate.Name = "TodaysDate";
            this.TodaysDate.Size = new System.Drawing.Size(87, 25);
            this.TodaysDate.TabIndex = 19;
            this.TodaysDate.Text = "DateTime";
            // 
            // WindowCapture
            // 
            this.WindowCapture.Image = ((System.Drawing.Image)(resources.GetObject("WindowCapture.Image")));
            this.WindowCapture.Location = new System.Drawing.Point(156, 55);
            this.WindowCapture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WindowCapture.Name = "WindowCapture";
            this.WindowCapture.Size = new System.Drawing.Size(53, 42);
            this.WindowCapture.TabIndex = 20;
            this.WindowCapture.UseVisualStyleBackColor = true;
            this.WindowCapture.Click += new System.EventHandler(this.CaptureWindow_Click);
            // 
            // HpLabel
            // 
            this.HpLabel.AutoSize = true;
            this.HpLabel.Location = new System.Drawing.Point(151, 407);
            this.HpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HpLabel.Name = "HpLabel";
            this.HpLabel.Size = new System.Drawing.Size(100, 25);
            this.HpLabel.TabIndex = 21;
            this.HpLabel.Text = "          HP%";
            // 
            // UniqueBox
            // 
            this.UniqueBox.AutoSize = true;
            this.UniqueBox.Location = new System.Drawing.Point(343, 405);
            this.UniqueBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UniqueBox.Name = "UniqueBox";
            this.UniqueBox.Size = new System.Drawing.Size(123, 29);
            this.UniqueBox.TabIndex = 22;
            this.UniqueBox.Text = "UniqueBox";
            this.UniqueBox.UseVisualStyleBackColor = true;
            // 
            // UniqueBox2
            // 
            this.UniqueBox2.AutoSize = true;
            this.UniqueBox2.Location = new System.Drawing.Point(449, 405);
            this.UniqueBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UniqueBox2.Name = "UniqueBox2";
            this.UniqueBox2.Size = new System.Drawing.Size(133, 29);
            this.UniqueBox2.TabIndex = 23;
            this.UniqueBox2.Text = "UniqueBox2";
            this.UniqueBox2.UseVisualStyleBackColor = true;
            // 
            // WideView
            // 
            this.WideView.Enabled = false;
            this.WideView.Location = new System.Drawing.Point(451, 107);
            this.WideView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WideView.Name = "WideView";
            this.WideView.Size = new System.Drawing.Size(107, 42);
            this.WideView.TabIndex = 24;
            this.WideView.Text = "Wide View";
            this.WideView.UseVisualStyleBackColor = true;
            this.WideView.Visible = false;
            this.WideView.Click += new System.EventHandler(this.WideView_Click);
            // 
            // BoxViewer
            // 
            this.BoxViewer.Enabled = false;
            this.BoxViewer.Location = new System.Drawing.Point(336, 107);
            this.BoxViewer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BoxViewer.Name = "BoxViewer";
            this.BoxViewer.Size = new System.Drawing.Size(107, 42);
            this.BoxViewer.TabIndex = 25;
            this.BoxViewer.Text = "Box View";
            this.BoxViewer.UseVisualStyleBackColor = true;
            this.BoxViewer.Visible = false;
            this.BoxViewer.Click += new System.EventHandler(this.BoxView_Click);
            // 
            // TrainerView
            // 
            this.TrainerView.Location = new System.Drawing.Point(336, 7);
            this.TrainerView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TrainerView.Name = "TrainerView";
            this.TrainerView.Size = new System.Drawing.Size(107, 42);
            this.TrainerView.TabIndex = 26;
            this.TrainerView.Text = "Trainer";
            this.TrainerView.UseVisualStyleBackColor = true;
            this.TrainerView.Visible = false;
            this.TrainerView.Click += new System.EventHandler(this.BattleView_Click);
            // 
            // DayCareView
            // 
            this.DayCareView.Location = new System.Drawing.Point(451, 7);
            this.DayCareView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DayCareView.Name = "DayCareView";
            this.DayCareView.Size = new System.Drawing.Size(107, 42);
            this.DayCareView.TabIndex = 27;
            this.DayCareView.Text = "Egg View";
            this.DayCareView.UseVisualStyleBackColor = true;
            this.DayCareView.Visible = false;
            this.DayCareView.Click += new System.EventHandler(this.DayCareView_Click);
            // 
            // OverworldView
            // 
            this.OverworldView.Location = new System.Drawing.Point(451, 58);
            this.OverworldView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OverworldView.Name = "OverworldView";
            this.OverworldView.Size = new System.Drawing.Size(107, 38);
            this.OverworldView.TabIndex = 29;
            this.OverworldView.Text = "Overworld View";
            this.OverworldView.UseVisualStyleBackColor = true;
            this.OverworldView.Visible = false;
            this.OverworldView.Click += new System.EventHandler(this.OverworldView_Click);
            // 
            // InGameScreenshot
            // 
            this.InGameScreenshot.Image = ((System.Drawing.Image)(resources.GetObject("InGameScreenshot.Image")));
            this.InGameScreenshot.Location = new System.Drawing.Point(156, 107);
            this.InGameScreenshot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InGameScreenshot.Name = "InGameScreenshot";
            this.InGameScreenshot.Size = new System.Drawing.Size(53, 42);
            this.InGameScreenshot.TabIndex = 30;
            this.InGameScreenshot.UseVisualStyleBackColor = true;
            this.InGameScreenshot.Click += new System.EventHandler(this.InGameScreenshot_Click);
            // 
            // Raids
            // 
            this.Raids.Enabled = false;
            this.Raids.Location = new System.Drawing.Point(336, 58);
            this.Raids.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Raids.Name = "Raids";
            this.Raids.Size = new System.Drawing.Size(107, 38);
            this.Raids.TabIndex = 31;
            this.Raids.Text = "Raids";
            this.Raids.UseVisualStyleBackColor = true;
            this.Raids.Visible = false;
            this.Raids.Click += new System.EventHandler(this.Raids_Click);
            // 
            // MainViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(579, 653);
            this.Controls.Add(this.Raids);
            this.Controls.Add(this.InGameScreenshot);
            this.Controls.Add(this.OverworldView);
            this.Controls.Add(this.DayCareView);
            this.Controls.Add(this.TrainerView);
            this.Controls.Add(this.BoxViewer);
            this.Controls.Add(this.WideView);
            this.Controls.Add(this.UniqueBox2);
            this.Controls.Add(this.UniqueBox);
            this.Controls.Add(this.HpLabel);
            this.Controls.Add(this.WindowCapture);
            this.Controls.Add(this.TodaysDate);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.RefreshBox);
            this.Controls.Add(this.RefreshStats);
            this.Controls.Add(this.LiveStats);
            this.Controls.Add(this.HidePIDEC);
            this.Controls.Add(this.OriginIcon);
            this.Controls.Add(this.Specialty);
            this.Controls.Add(this.PokeSprite);
            this.Controls.Add(this.ViewBox);
            this.Controls.Add(this.View);
            this.Controls.Add(this.SwitchIP);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.Typing2);
            this.Controls.Add(this.Typing1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainViewer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PokeViewer.NET";
            this.Load += new System.EventHandler(this.PokeViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PokeSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Specialty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Typing1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Typing2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Connect;
        private TextBox SwitchIP;
        private Button View;
        private TextBox ViewBox;
        private PictureBox PokeSprite;
        private PictureBox Specialty;
        private PictureBox OriginIcon;
        private PictureBox Typing1;
        private CheckBox HidePIDEC;
        private PictureBox Typing2;
        private TextBox LiveStats;
        private CheckBox RefreshStats;
        private TextBox RefreshBox;
        private new Label Refresh;
        private Label TodaysDate;
        private Button WindowCapture;
        private Label HpLabel;
        private CheckBox UniqueBox;
        private CheckBox UniqueBox2;
        private Button WideView;
        private Button BoxViewer;
        private Button TrainerView;
        private Button DayCareView;
        private Button OverworldView;
        private Button InGameScreenshot;
        private Button Raids;
    }
}