namespace WinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lblTeam = new Label();
            cbTeam = new ComboBox();
            btnTopScorers = new Button();
            btnPrint = new Button();
            btnSettings = new Button();
            btnSaveFavourites = new Button();
            btnMatches = new Button();
            btnYellowCards = new Button();
            lblAllPlayers = new Label();
            lblFavouritePlayers = new Label();
            pnlContainer = new FlowLayoutPanel();
            pnlAllPlayers = new FlowLayoutPanel();
            pnlFavouritePlayers = new FlowLayoutPanel();
            printPreviewDialog = new PrintPreviewDialog();
            printDocument = new System.Drawing.Printing.PrintDocument();
            lblFavourites = new Label();
            SuspendLayout();
            // 
            // lblTeam
            // 
            resources.ApplyResources(lblTeam, "lblTeam");
            lblTeam.Name = "lblTeam";
            // 
            // cbTeam
            // 
            cbTeam.FormattingEnabled = true;
            resources.ApplyResources(cbTeam, "cbTeam");
            cbTeam.Name = "cbTeam";
            cbTeam.SelectedIndexChanged += CbTeam_SelectedIndexChanged;
            // 
            // btnTopScorers
            // 
            resources.ApplyResources(btnTopScorers, "btnTopScorers");
            btnTopScorers.Name = "btnTopScorers";
            btnTopScorers.UseVisualStyleBackColor = true;
            btnTopScorers.Click += btnTopScorers_Click;
            // 
            // btnPrint
            // 
            resources.ApplyResources(btnPrint, "btnPrint");
            btnPrint.Name = "btnPrint";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnSettings
            // 
            resources.ApplyResources(btnSettings, "btnSettings");
            btnSettings.Name = "btnSettings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnSaveFavourites
            // 
            resources.ApplyResources(btnSaveFavourites, "btnSaveFavourites");
            btnSaveFavourites.Name = "btnSaveFavourites";
            btnSaveFavourites.UseVisualStyleBackColor = true;
            btnSaveFavourites.Click += btnSaveFavourites_Click;
            // 
            // btnMatches
            // 
            resources.ApplyResources(btnMatches, "btnMatches");
            btnMatches.Name = "btnMatches";
            btnMatches.UseVisualStyleBackColor = true;
            btnMatches.Click += btnMatches_Click;
            // 
            // btnYellowCards
            // 
            resources.ApplyResources(btnYellowCards, "btnYellowCards");
            btnYellowCards.Name = "btnYellowCards";
            btnYellowCards.UseVisualStyleBackColor = true;
            btnYellowCards.Click += btnYellowCards_Click;
            // 
            // lblAllPlayers
            // 
            resources.ApplyResources(lblAllPlayers, "lblAllPlayers");
            lblAllPlayers.Name = "lblAllPlayers";
            // 
            // lblFavouritePlayers
            // 
            resources.ApplyResources(lblFavouritePlayers, "lblFavouritePlayers");
            lblFavouritePlayers.Name = "lblFavouritePlayers";
            // 
            // pnlContainer
            // 
            pnlContainer.AllowDrop = true;
            resources.ApplyResources(pnlContainer, "pnlContainer");
            pnlContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlContainer.Name = "pnlContainer";
            // 
            // pnlAllPlayers
            // 
            pnlAllPlayers.AllowDrop = true;
            resources.ApplyResources(pnlAllPlayers, "pnlAllPlayers");
            pnlAllPlayers.BorderStyle = BorderStyle.FixedSingle;
            pnlAllPlayers.Name = "pnlAllPlayers";
            pnlAllPlayers.DragDrop += PnlAllPlayers_DragDrop;
            pnlAllPlayers.DragEnter += PnlAllPlayers_DragEnter;
            // 
            // pnlFavouritePlayers
            // 
            pnlFavouritePlayers.AllowDrop = true;
            resources.ApplyResources(pnlFavouritePlayers, "pnlFavouritePlayers");
            pnlFavouritePlayers.BorderStyle = BorderStyle.FixedSingle;
            pnlFavouritePlayers.Name = "pnlFavouritePlayers";
            pnlFavouritePlayers.DragDrop += PnlFavouritePlayers_DragDrop;
            pnlFavouritePlayers.DragEnter += PnlAllPlayers_DragEnter;
            // 
            // printPreviewDialog
            // 
            resources.ApplyResources(printPreviewDialog, "printPreviewDialog");
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Name = "printPreviewDialog";
            // 
            // printDocument
            // 
            printDocument.PrintPage += PrintDocument_PrintPage;
            // 
            // lblFavourites
            // 
            resources.ApplyResources(lblFavourites, "lblFavourites");
            lblFavourites.Name = "lblFavourites";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblFavourites);
            Controls.Add(btnMatches);
            Controls.Add(pnlFavouritePlayers);
            Controls.Add(pnlAllPlayers);
            Controls.Add(pnlContainer);
            Controls.Add(lblFavouritePlayers);
            Controls.Add(lblAllPlayers);
            Controls.Add(btnYellowCards);
            Controls.Add(btnSaveFavourites);
            Controls.Add(btnSettings);
            Controls.Add(btnPrint);
            Controls.Add(btnTopScorers);
            Controls.Add(cbTeam);
            Controls.Add(lblTeam);
            Name = "MainForm";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTeam;
        private ComboBox cbTeam;
        private Button btnTopScorers;
        private Button btnPrint;
        private Button btnSettings;
        private Button btnSaveFavourites;
        private Button btnMatches;
        private Button btnYellowCards;
        private Label lblAllPlayers;
        private Label lblFavouritePlayers;
        private FlowLayoutPanel pnlContainer;
        private FlowLayoutPanel pnlAllPlayers;
        private FlowLayoutPanel pnlFavouritePlayers;
        private PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private Label lblFavourites;
    }
}