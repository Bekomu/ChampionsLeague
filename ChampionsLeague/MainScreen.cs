using ChampionsLeague.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChampionsLeague
{
    public partial class MainScreen : Form
    {
        ChampionsDbContext db = new ChampionsDbContext();
        public MainScreen()
        {
            InitializeComponent();
            dgvMatchesUpdate();
        }

        private void dgvMatchesUpdate()
        {
            dgvMatches.DataSource = null;
            dgvMatches.DataSource = db.Matches.ToList().Select(m => new
            {
                Match = m.Id,
                Home = m.Team1.TeamName,
                Away = m.Team2.TeamName,
                Date = m.MatchTime.ToString("dd-MM-yyyy"),
                Time = m.MatchTime.ToString("HH:mm"),
                Result = m.Score1 + " - " + m.Score2,
                MatchTime = m.MatchTime
            }).OrderByDescending(x => x.MatchTime).ToList();
        }

        private void btnTeams_Click(object sender, EventArgs e)
        {
            TeamsForm form = new TeamsForm(db);
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                return;
            }
        }

        private void btnTeamColors_Click(object sender, EventArgs e)
        {
            ColorsForm form = new ColorsForm(db);
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                return;
            }
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            PlayersForm form = new PlayersForm(db);
            DialogResult dr = form.ShowDialog();
            if(dr == DialogResult.OK)
            {
                return;
            }
        }

        private void btnNewMatch_Click(object sender, EventArgs e)
        {
            NewMatchForm form = new NewMatchForm(db, null);
            DialogResult dr = form.ShowDialog();
            if (dr==DialogResult.OK)
            {
                dgvMatchesUpdate();
                return;
            }
        }

        private void btnDeleteMatch_Click(object sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count > 0)
            {
                int willBeDeleteId = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
                Match willBeDeleteMatch = db.Matches.First(x => x.Id == willBeDeleteId);
                DialogResult dr = MessageBox.Show(
                    "Are you sure you want to delete this match ?",
                    "Delete match ?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if ( dr == DialogResult.Yes )
                {
                    db.Matches.Remove(willBeDeleteMatch);
                    db.SaveChanges();
                    dgvMatchesUpdate();
                }
            }
            else
            {
                MessageBox.Show("You should select one match at least.");
            }
        }

        private void btnEditMatch_Click(object sender, EventArgs e)
        {
            int willBeEditId = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
            Match willBeEditMatch = db.Matches.First(x => x.Id == willBeEditId);
            NewMatchForm form = new NewMatchForm(db, willBeEditMatch);
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dgvMatchesUpdate();
                return;
            }
        }
    }
}
