namespace WinForms
{
    partial class Player
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbIcon = new PictureBox();
            pbFavourite = new PictureBox();
            lblName = new Label();
            lblPosition = new Label();
            lblShirtNumber = new Label();
            lblCaptain = new Label();
            lblFilter = new Label();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFavourite).BeginInit();
            SuspendLayout();
            // 
            // pbIcon
            // 
            pbIcon.Dock = DockStyle.Top;
            pbIcon.ErrorImage = Properties.Resources.person;
            pbIcon.InitialImage = null;
            pbIcon.Location = new Point(0, 0);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(150, 95);
            pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbIcon.TabIndex = 0;
            pbIcon.TabStop = false;
            // 
            // pbFavourite
            // 
            pbFavourite.Image = Properties.Resources.star;
            pbFavourite.Location = new Point(121, 123);
            pbFavourite.Name = "pbFavourite";
            pbFavourite.Size = new Size(26, 24);
            pbFavourite.SizeMode = PictureBoxSizeMode.Zoom;
            pbFavourite.TabIndex = 1;
            pbFavourite.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(3, 98);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 15);
            lblName.TabIndex = 2;
            lblName.Text = "label1";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(3, 117);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(38, 15);
            lblPosition.TabIndex = 3;
            lblPosition.Text = "label1";
            // 
            // lblShirtNumber
            // 
            lblShirtNumber.AutoSize = true;
            lblShirtNumber.Location = new Point(3, 135);
            lblShirtNumber.Name = "lblShirtNumber";
            lblShirtNumber.Size = new Size(38, 15);
            lblShirtNumber.TabIndex = 4;
            lblShirtNumber.Text = "label1";
            // 
            // lblCaptain
            // 
            lblCaptain.AutoSize = true;
            lblCaptain.Location = new Point(64, 126);
            lblCaptain.Name = "lblCaptain";
            lblCaptain.Size = new Size(38, 15);
            lblCaptain.TabIndex = 5;
            lblCaptain.Text = "label1";
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(109, 99);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(38, 15);
            lblFilter.TabIndex = 6;
            lblFilter.Text = "label1";
            // 
            // Player
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            Controls.Add(lblFilter);
            Controls.Add(lblCaptain);
            Controls.Add(lblShirtNumber);
            Controls.Add(lblPosition);
            Controls.Add(lblName);
            Controls.Add(pbFavourite);
            Controls.Add(pbIcon);
            Name = "Player";
            MouseDown += Player_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFavourite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbIcon;
        private PictureBox pbFavourite;
        private Label lblName;
        private Label lblPosition;
        private Label lblShirtNumber;
        private Label lblCaptain;
        private Label lblFilter;
    }
}
