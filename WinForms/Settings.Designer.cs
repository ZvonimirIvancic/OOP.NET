namespace WinForms
{
    partial class Settings
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
            btnConfim = new Button();
            lblChampionship = new Label();
            lblLanguage = new Label();
            rbCroatian = new RadioButton();
            rbEnglish = new RadioButton();
            lblResolution = new Label();
            rbFullScreen = new RadioButton();
            rbMedium = new RadioButton();
            rbSmall = new RadioButton();
            cbChampionship = new ComboBox();
            gbLanguage = new GroupBox();
            gbResolution = new GroupBox();
            gbLanguage.SuspendLayout();
            gbResolution.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfim
            // 
            btnConfim.Location = new Point(100, 400);
            btnConfim.Name = "btnConfim";
            btnConfim.Size = new Size(197, 37);
            btnConfim.TabIndex = 0;
            btnConfim.Text = "Confirm";
            btnConfim.UseVisualStyleBackColor = true;
            btnConfim.Click += btnConfim_Click;
            // 
            // lblChampionship
            // 
            lblChampionship.AutoSize = true;
            lblChampionship.Location = new Point(148, 29);
            lblChampionship.Name = "lblChampionship";
            lblChampionship.Size = new Size(88, 15);
            lblChampionship.TabIndex = 1;
            lblChampionship.Text = "Championship:";
            // 
            // lblLanguage
            // 
            lblLanguage.Location = new Point(161, 139);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(100, 23);
            lblLanguage.TabIndex = 2;
            lblLanguage.Text = "Language:";
            // 
            // rbCroatian
            // 
            rbCroatian.AutoSize = true;
            rbCroatian.Location = new Point(6, 42);
            rbCroatian.Name = "rbCroatian";
            rbCroatian.Size = new Size(70, 19);
            rbCroatian.TabIndex = 3;
            rbCroatian.Tag = "hr";
            rbCroatian.Text = "Croatian";
            rbCroatian.UseVisualStyleBackColor = true;
            // 
            // rbEnglish
            // 
            rbEnglish.AutoSize = true;
            rbEnglish.Checked = true;
            rbEnglish.Location = new Point(128, 42);
            rbEnglish.Name = "rbEnglish";
            rbEnglish.Size = new Size(63, 19);
            rbEnglish.TabIndex = 4;
            rbEnglish.TabStop = true;
            rbEnglish.Tag = "en-GB";
            rbEnglish.Text = "English";
            rbEnglish.UseVisualStyleBackColor = true;
            // 
            // lblResolution
            // 
            lblResolution.AutoSize = true;
            lblResolution.Location = new Point(157, 255);
            lblResolution.Name = "lblResolution";
            lblResolution.Size = new Size(66, 15);
            lblResolution.TabIndex = 5;
            lblResolution.Text = "Resolution:";
            // 
            // rbFullScreen
            // 
            rbFullScreen.AutoSize = true;
            rbFullScreen.Location = new Point(214, 48);
            rbFullScreen.Name = "rbFullScreen";
            rbFullScreen.Size = new Size(78, 19);
            rbFullScreen.TabIndex = 6;
            rbFullScreen.TabStop = true;
            rbFullScreen.Tag = "FullScreen";
            rbFullScreen.Text = "Fullscreen";
            rbFullScreen.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            rbMedium.AutoSize = true;
            rbMedium.Location = new Point(115, 48);
            rbMedium.Name = "rbMedium";
            rbMedium.Size = new Size(79, 19);
            rbMedium.TabIndex = 7;
            rbMedium.TabStop = true;
            rbMedium.Tag = "1920x1080";
            rbMedium.Text = "1920x1080";
            rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            rbSmall.AutoSize = true;
            rbSmall.Checked = true;
            rbSmall.Location = new Point(16, 48);
            rbSmall.Name = "rbSmall";
            rbSmall.Size = new Size(73, 19);
            rbSmall.TabIndex = 8;
            rbSmall.TabStop = true;
            rbSmall.Tag = "1280x720";
            rbSmall.Text = "1280x720";
            rbSmall.UseVisualStyleBackColor = true;
            // 
            // cbChampionship
            // 
            cbChampionship.FormattingEnabled = true;
            cbChampionship.Location = new Point(75, 74);
            cbChampionship.Name = "cbChampionship";
            cbChampionship.Size = new Size(222, 23);
            cbChampionship.TabIndex = 9;
            // 
            // gbLanguage
            // 
            gbLanguage.Controls.Add(rbCroatian);
            gbLanguage.Controls.Add(rbEnglish);
            gbLanguage.Location = new Point(97, 167);
            gbLanguage.Name = "gbLanguage";
            gbLanguage.Size = new Size(197, 67);
            gbLanguage.TabIndex = 10;
            gbLanguage.TabStop = false;
            // 
            // gbResolution
            // 
            gbResolution.Controls.Add(rbSmall);
            gbResolution.Controls.Add(rbMedium);
            gbResolution.Controls.Add(rbFullScreen);
            gbResolution.Location = new Point(42, 273);
            gbResolution.Name = "gbResolution";
            gbResolution.Size = new Size(298, 100);
            gbResolution.TabIndex = 11;
            gbResolution.TabStop = false;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 461);
            Controls.Add(gbResolution);
            Controls.Add(gbLanguage);
            Controls.Add(cbChampionship);
            Controls.Add(lblResolution);
            Controls.Add(lblLanguage);
            Controls.Add(lblChampionship);
            Controls.Add(btnConfim);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            gbLanguage.ResumeLayout(false);
            gbLanguage.PerformLayout();
            gbResolution.ResumeLayout(false);
            gbResolution.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfim;
        private Label lblChampionship;
        private Label lblLanguage;
        private RadioButton rbCroatian;
        private RadioButton rbEnglish;
        private Label lblResolution;
        private RadioButton rbFullScreen;
        private RadioButton rbMedium;
        private RadioButton rbSmall;
        private ComboBox cbChampionship;
        private GroupBox gbLanguage;
        private GroupBox gbResolution;
    }
}