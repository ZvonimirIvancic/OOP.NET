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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
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
            resources.ApplyResources(btnConfim, "btnConfim");
            btnConfim.Name = "btnConfim";
            btnConfim.UseVisualStyleBackColor = true;
            btnConfim.Click += btnConfim_Click;
            // 
            // lblChampionship
            // 
            resources.ApplyResources(lblChampionship, "lblChampionship");
            lblChampionship.Name = "lblChampionship";
            // 
            // lblLanguage
            // 
            resources.ApplyResources(lblLanguage, "lblLanguage");
            lblLanguage.Name = "lblLanguage";
            // 
            // rbCroatian
            // 
            resources.ApplyResources(rbCroatian, "rbCroatian");
            rbCroatian.Name = "rbCroatian";
            rbCroatian.Tag = "hr";
            rbCroatian.UseVisualStyleBackColor = true;
            // 
            // rbEnglish
            // 
            resources.ApplyResources(rbEnglish, "rbEnglish");
            rbEnglish.Checked = true;
            rbEnglish.Name = "rbEnglish";
            rbEnglish.TabStop = true;
            rbEnglish.Tag = "en-GB";
            rbEnglish.UseVisualStyleBackColor = true;
            // 
            // lblResolution
            // 
            resources.ApplyResources(lblResolution, "lblResolution");
            lblResolution.Name = "lblResolution";
            // 
            // rbFullScreen
            // 
            resources.ApplyResources(rbFullScreen, "rbFullScreen");
            rbFullScreen.Name = "rbFullScreen";
            rbFullScreen.Tag = "FullScreen";
            rbFullScreen.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            resources.ApplyResources(rbMedium, "rbMedium");
            rbMedium.Name = "rbMedium";
            rbMedium.Tag = "1920x1080";
            rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            resources.ApplyResources(rbSmall, "rbSmall");
            rbSmall.Name = "rbSmall";
            rbSmall.Tag = "1280x720";
            rbSmall.UseVisualStyleBackColor = true;
            // 
            // cbChampionship
            // 
            resources.ApplyResources(cbChampionship, "cbChampionship");
            cbChampionship.FormattingEnabled = true;
            cbChampionship.Name = "cbChampionship";
            // 
            // gbLanguage
            // 
            resources.ApplyResources(gbLanguage, "gbLanguage");
            gbLanguage.Controls.Add(rbCroatian);
            gbLanguage.Controls.Add(rbEnglish);
            gbLanguage.Name = "gbLanguage";
            gbLanguage.TabStop = false;
            // 
            // gbResolution
            // 
            resources.ApplyResources(gbResolution, "gbResolution");
            gbResolution.Controls.Add(rbSmall);
            gbResolution.Controls.Add(rbMedium);
            gbResolution.Controls.Add(rbFullScreen);
            gbResolution.Name = "gbResolution";
            gbResolution.TabStop = false;
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbResolution);
            Controls.Add(gbLanguage);
            Controls.Add(cbChampionship);
            Controls.Add(lblResolution);
            Controls.Add(lblLanguage);
            Controls.Add(lblChampionship);
            Controls.Add(btnConfim);
            Name = "Settings";
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