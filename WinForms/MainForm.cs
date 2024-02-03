using DAL.Model;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class MainForm : Form
    {
        string? championship;
        string? language;
        IRepo repo;

        public MainForm()
        {
            InitializeComponent();
            LoadSettings();
            InitRepo();
            InitComboBox();
            LoadFavourites();
        }

        private void LoadSettings(bool startup = true)
        {
            try
            {
                if (FileRepo.HasConfig() && startup)
                {
                    Dictionary<string, string> settings = FileRepo.GetConfig();
                    championship = settings["cbChampionship"];
                    language = settings["gbLanguage"];
                    SetLocalization(language);
                }
                else
                {
                    Settings settingsForm = new();
                    settingsForm.ShowDialog();
                    LoadSettings();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Files folder missing!{Environment.NewLine}Message: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void SetLocalization(string language)
            => Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture = new CultureInfo(language);

        private void InitRepo() => repo = RepoFactory.GetRepo(championship);

        private void InitComboBox()
        {
            cbTeam.DisplayMember = "Country";
            cbTeam.ValueMember = "FifaCode";
            cbTeam.DataSource = repo.GetTeams();
        }

        private void LoadFavourites()
        {
            if (FileRepo.HasFavourites())
            {
                FileRepo.GetFavourites().ForEach(p => pnlFavouritePlayers.Controls.Add(new Player(p, true)));
            }
            if (FileRepo.HasSavedTeam())
            {
                cbTeam.SelectedValue = FileRepo.GetSavedTeam();
            }
        }

        private void LoadPlayers()
        {
            Cursor.Current = Cursors.WaitCursor;
            List<StartingEleven> players = repo.GetAllPlayersCountry(cbTeam.SelectedValue.ToString());
            pnlAllPlayers.Controls.Clear();
            players.ForEach(player => pnlAllPlayers.Controls.Add(new Player(player, false)));
            Cursor.Current = Cursors.Default;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConfirmDialog confirmDialog = new();
            e.Cancel = confirmDialog.ShowDialog() == DialogResult.Cancel;
            FileRepo.SaveTeam(cbTeam.SelectedValue.ToString());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            LoadSettings(startup: false);
            Controls.Clear();
            FormClosing -= new FormClosingEventHandler(MainForm_FormClosing);
            InitializeComponent();
            InitRepo();
            InitComboBox();
            LoadFavourites();
        }

        private void CbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlayers();
            pnlContainer.Controls.Clear();
        }

        private void btnTopScorers_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            List<StartingEleven> players = repo.GetAllPlayersCountry(cbTeam.SelectedValue.ToString());
            List<Match> matches = repo.GetMatchesCountry(cbTeam.SelectedValue.ToString());
            foreach (Match match in matches)
            {
                players.ForEach(p => p.Filter += match.GetGoalsScoredByPlayer(p.Name));
            }
            players.Sort((x, y) => y.Filter.CompareTo(x.Filter));
            players.ForEach(p => pnlContainer.Controls.Add(new Player(p, false)));
        }

        private void btnMatches_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            List<string> matchesDisplay = repo.GetMatchesCountry(cbTeam.SelectedValue.ToString())
                .Select(m => $"Location: {m.Venue}{Environment.NewLine}{m.HomeTeamCountry} - {m.AwayTeamCountry}{Environment.NewLine}{m.Attendance} visitors")
                .ToList();

            foreach (string matchText in matchesDisplay)
            {
                TextBox tb = new()
                {
                    Multiline = true,
                    ReadOnly = true,
                    Height = 80,
                    Width = 200,
                    Text = matchText
                };
                pnlContainer.Controls.Add(tb);
            }
        }

        private void btnYellowCards_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            List<StartingEleven> players = repo.GetAllPlayersCountry(cbTeam.SelectedValue.ToString());
            List<Match> matches = repo.GetMatchesCountry(cbTeam.SelectedValue.ToString());
            foreach (Match match in matches)
            {
                players.ForEach(p => p.Filter += match.GetYellowCardsByPlayer(p.Name));
            }
            players.Sort((x, y) => y.Filter.CompareTo(x.Filter));
            players.ForEach(p => pnlContainer.Controls.Add(new Player(p, false)));
        }

        private void btnSaveFavourites_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Player> favouritePlayers = pnlFavouritePlayers.Controls.OfType<Player>();
                List<StartingEleven> favourites = new();
                foreach (Player player in favouritePlayers)
                {
                    favourites.Add(player.GetAsStartingElevenType());
                }

                if (favourites.Count > 0)
                {
                    FileRepo.SaveFavourites(favourites);
                    MessageBox.Show("Items saved successfully!", "Save success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No favourite players to save.", "Save setup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving favourite players:{Environment.NewLine}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PnlAllPlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void PnlFavouritePlayers_DragDrop(object sender, DragEventArgs e)
        {
            Player player = (Player)e.Data.GetData(typeof(Player));
            if (!pnlFavouritePlayers.Controls.Contains(player))
            {
                pnlFavouritePlayers.Controls.Add(player);
                player.SetFavourite(true);
                pnlAllPlayers.Controls.Remove(player);
            }
        }

        private void PnlAllPlayers_DragDrop(object sender, DragEventArgs e)
        {
            Player player = (Player)e.Data.GetData(typeof(Player));
            if (!pnlAllPlayers.Controls.Contains(player))
            {
                pnlAllPlayers.Controls.Add(player);
                player.SetFavourite(false);
                pnlFavouritePlayers.Controls.Remove(player);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (pnlContainer.Controls.Count == 0)
            {
                MessageBox.Show("Select something to print first.", "Nothing selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (printPreviewDialog.ShowDialog() != DialogResult.Cancel)
            {
                printDocument.Print();
            }
        }

        private int pageNumber = 1;
        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int totalHeight = pnlContainer.DisplayRectangle.Height;

            int startAt = (pageNumber - 1) * e.PageBounds.Height;
            int endAt = Math.Min(startAt + e.PageBounds.Height, totalHeight);

            Bitmap bmp = new Bitmap(pnlContainer.Width, pnlContainer.Height);

            pnlContainer.DrawToBitmap(bmp, new Rectangle(0, 0, pnlContainer.Width, pnlContainer.Height));

            e.Graphics?.DrawImage(bmp, 0, 0, pnlContainer.Width, endAt - startAt);

            if (endAt < totalHeight)
            {
                e.HasMorePages = true;
                pageNumber++;
            }
            else
            {
                e.HasMorePages = false;
                pageNumber = 1; 
            }

            bmp.Dispose();
        }
    }
}
