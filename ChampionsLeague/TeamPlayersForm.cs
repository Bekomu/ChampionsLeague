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
    public partial class TeamPlayersForm : Form
    {
        private readonly Team _team;
        private readonly ChampionsDbContext _db;

        public TeamPlayersForm(Team team, ChampionsDbContext db)
        {
            InitializeComponent();
            _team = team;
            _db = db;
            gboxTeamPlayers.Text = $"Players of {_team.TeamName}";
            gboxAll.Text = $"All football players except {_team.TeamName}";
            btnDelete.Text = $"Remove player from {_team.TeamName}  =>";
            btnAdd.Text = $"<=  Add player to {_team.TeamName}";
            dgvAllPlayersUpdate();
            dgvTeamPlayersUpdate();
        }

        private void dgvAllPlayersUpdate()
        {
            dgvAllPlayers.DataSource = null;
            dgvAllPlayers.DataSource = _db.Players.Where(x => x.TeamId != _team.Id).ToList();
        }

        private void dgvTeamPlayersUpdate()
        {
            dgvTeamPlayers.DataSource = null;
            dgvTeamPlayers.DataSource = _db.Players.Where(x => x.TeamId == _team.Id).ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTeamPlayers.SelectedRows.Count > 0)
            {
                int selectedPlayerId = (int)dgvTeamPlayers.SelectedRows[0].Cells[0].Value;
                Player selectedPlayer = _db.Players.First(x => x.Id == selectedPlayerId);

                DialogResult dr = MessageBox.Show(
                    "Are you sure you want to remove this player from team and move all player list ?",
                    "Remove player ?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    selectedPlayer.TeamId = null;
                    _db.SaveChanges();
                    dgvAllPlayersUpdate();
                    dgvTeamPlayersUpdate();
                }
            }
            else
            {
                MessageBox.Show("You should select one player at least.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvAllPlayers.SelectedRows.Count > 0)
            {
                int selectedPlayerId = (int)dgvAllPlayers.SelectedRows[0].Cells[0].Value;
                Player selectedPlayer = _db.Players.First(x => x.Id == selectedPlayerId);

                DialogResult dr = MessageBox.Show(
                    "Are you sure you want to add this player to team ?",
                    "Add player ?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    selectedPlayer.TeamId = _team.Id;
                    _db.SaveChanges();
                    dgvAllPlayersUpdate();
                    dgvTeamPlayersUpdate();
                }
            }
            else
            {
                MessageBox.Show("You should select one player at least.");
            }
        }
    }
}
