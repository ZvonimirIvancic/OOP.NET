namespace WinForms
{
    partial class ConfirmDialog
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
            lblMessage = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(72, 27);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(136, 15);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Are you sure about that?";
            // 
            // btnConfirm
            // 
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.DialogResult = DialogResult.OK;
            btnConfirm.Location = new Point(43, 61);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.KeyDown += Buttons_KeyDown;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(156, 61);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.KeyDown += Buttons_KeyDown;
            // 
            // ConfirmDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 111);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(lblMessage);
            Name = "ConfirmDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private Button btnConfirm;
        private Button btnCancel;
    }
}