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
    public partial class PlayersForm : Form
    {
        private readonly ChampionsDbContext _db;

        public PlayersForm(ChampionsDbContext db)
        {
            InitializeComponent();
            _db = db;
            dgvPlayersUpdate(null);
            cboTeamsUpdate();
        }

        private void cboTeamsUpdate()
        {
            cboTeams.DataSource = null;
            cboTeams.DisplayMember = "TeamName";
            cboTeams.ValueMember = "Id";
            for (int i = 0; i < _db.Teams.ToList().Count; i++)
            {
                if (cboTeams.Items.Count == 0)
                {
                    cboTeams.Items.Add("No Team");
                }
                cboTeams.Items.Add(_db.Teams.ToList()[i]);
            }
        }

        private void dgvPlayersUpdate(string searchingText)
        {
            if (searchingText != null)
            {
                dgvPlayers.DataSource = null;
                dgvPlayers.DataSource = _db.Players.Where(x => x.Team.TeamName.Contains(searchingText)).ToList();
            }
            else
            {
                dgvPlayers.DataSource = null;
                dgvPlayers.DataSource = _db.Players.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add Player")
            {
                if (!string.IsNullOrEmpty(txtPlayerName.Text))
                {
                    Player newPlayer = new Player { PlayerName = txtPlayerName.Text };
                    _db.Players.Add(newPlayer);

                    if (cboTeams.SelectedIndex > 0)
                    {
                        Team selectedTeam = _db.Teams.First(x => x.Id == ((Team)cboTeams.SelectedItem).Id);
                        newPlayer.TeamId = selectedTeam.Id;
                    }
                    else
                    {
                        newPlayer.TeamId = null;
                    }
                    _db.SaveChanges();
                    FormClear();
                    dgvPlayersUpdate(null);
                }
                else
                {
                    MessageBox.Show("You should enter player name");
                }
            }
            if (btnAdd.Text == "Save Player")
            {
                if (!string.IsNullOrEmpty(txtPlayerName.Text))
                {
                    int selectedPlayerId = (int)dgvPlayers.SelectedRows[0].Cells[0].Value;
                    Player selectedPlayer = _db.Players.First(x => x.Id == selectedPlayerId);

                    selectedPlayer.PlayerName = txtPlayerName.Text;
                    if (cboTeams.SelectedIndex > 0)
                    {
                        Team selectedTeam = _db.Teams.First(x => x.Id == ((Team)cboTeams.SelectedItem).Id);
                        selectedPlayer.TeamId = selectedTeam.Id;
                    }
                    else
                    {
                        selectedPlayer.TeamId = null;
                    }
                    _db.SaveChanges();
                    groupBox1.Text = "Add Player";
                    btnAdd.Text = "Add Player";
                    groupBox1.BackColor = System.Drawing.Color.Transparent;
                    dgvPlayers.Enabled = true;
                    btnDelete.Enabled = true;
                    FormClear();
                    dgvPlayersUpdate(null);
                }
                else
                {
                    MessageBox.Show("You should enter player name");
                }
            }
        }

        private void FormClear()
        {
            txtPlayerName.Text = "";
            cboTeams.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPlayers.SelectedRows.Count == 1)
            {
                int selectedPlayerId = (int)dgvPlayers.SelectedRows[0].Cells[0].Value;
                Player selectedPlayer = _db.Players.First(x => x.Id == selectedPlayerId);
                DialogResult dr = MessageBox.Show(
                    "Are you sure you want to remove this player ?",
                    "Remove player ?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    _db.Players.Remove(selectedPlayer);
                    _db.SaveChanges();
                    dgvPlayersUpdate(null);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPlayers.SelectedRows.Count > 0)
            {
                groupBox1.Text = "Edit Player";
                btnAdd.Text = "Save Player";
                groupBox1.BackColor = System.Drawing.Color.Aqua;
                dgvPlayers.Enabled = false;
                btnDelete.Enabled = false;

                int selectedPlayerId = (int)dgvPlayers.SelectedRows[0].Cells[0].Value;
                Player selectedPlayer = _db.Players.First(x => x.Id == selectedPlayerId);
                txtPlayerName.Text = selectedPlayer.PlayerName;
                if (selectedPlayer.TeamId != null)
                {
                    cboTeams.SelectedItem = selectedPlayer.Team;
                }
                else
                {
                    cboTeams.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("You should select one player at least");
            }
        }

        private void txtTeamName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTeamName.Text))
            {
                txtTeamName.BackColor = System.Drawing.Color.Aqua;
                dgvPlayersUpdate(txtTeamName.Text);
            }
            else
            {
                txtTeamName.BackColor = System.Drawing.Color.White;
                dgvPlayersUpdate(null);
            }
        }
    }
}
