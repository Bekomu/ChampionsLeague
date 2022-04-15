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
    public partial class TeamsForm : Form
    {
        private readonly ChampionsDbContext _db;

        public TeamsForm(ChampionsDbContext db)
        {
            InitializeComponent();
            _db = db;
            chklstColorsUpdate();
            lstTeamsUpdate();
            teamColorsUpdate();
        }

        private void teamColorsUpdate()
        {
            if (lstTeams.SelectedItems.Count > 0)
            {
                Team selectedTeam = (Team)lstTeams.SelectedItem;
                List<Models.Color> selectedTeamColors = selectedTeam.Colors.ToList();

                for (int i = -1; i < selectedTeamColors.Count; i++)
                {
                    switch (i)
                    {
                        case -1:
                            pboColor1.BackColor = System.Drawing.Color.Gray;
                            pboColor2.BackColor = System.Drawing.Color.Gray;
                            pboColor3.BackColor = System.Drawing.Color.Gray;
                            pboColor4.BackColor = System.Drawing.Color.Gray;
                            pboColor5.BackColor = System.Drawing.Color.Gray;
                            break;
                        case 0:
                            pboColor1.BackColor = System.Drawing.Color.FromArgb(selectedTeamColors[i].Red, selectedTeamColors[i].Green, selectedTeamColors[i].Blue);
                            break;
                        case 1:
                            pboColor2.BackColor = System.Drawing.Color.FromArgb(selectedTeamColors[i].Red, selectedTeamColors[i].Green, selectedTeamColors[i].Blue);
                            break;
                        case 2:
                            pboColor3.BackColor = System.Drawing.Color.FromArgb(selectedTeamColors[i].Red, selectedTeamColors[i].Green, selectedTeamColors[i].Blue);
                            break;
                        case 3:
                            pboColor4.BackColor = System.Drawing.Color.FromArgb(selectedTeamColors[i].Red, selectedTeamColors[i].Green, selectedTeamColors[i].Blue);
                            break;
                        case 4:
                            pboColor5.BackColor = System.Drawing.Color.FromArgb(selectedTeamColors[i].Red, selectedTeamColors[i].Green, selectedTeamColors[i].Blue);
                            break;

                    }
                }
            }
        }

        private void lstTeamsUpdate()
        {
            lstTeams.DataSource = null;
            lstTeams.DisplayMember = "TeamName";
            lstTeams.ValueMember = "Id";
            lstTeams.DataSource = _db.Teams.ToList();
        }

        private void chklstColorsUpdate()
        {
            chklstColors.DataSource = null;
            chklstColors.DisplayMember = "ColorName";
            chklstColors.ValueMember = "Id";
            chklstColors.DataSource = _db.Colors.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAddTeam.Text == "Add Team")
            {
                if (!string.IsNullOrEmpty(txtTeamName.Text) && chklstColors.CheckedItems.Count > 0)
                {
                    Team newTeam = new Team { TeamName = txtTeamName.Text };
                    _db.Teams.Add(newTeam);

                    foreach (var item in chklstColors.CheckedItems)
                    {
                        newTeam.Colors.Add((Models.Color)item);
                    }

                    _db.SaveChanges();
                    lstTeamsUpdate();
                    FormClean();
                }
                else
                {
                    MessageBox.Show("You should enter Team Name and check one color at least.");
                }
            }
            if (btnAddTeam.Text == "Save Team")
            {
                if (!string.IsNullOrEmpty(txtTeamName.Text) && chklstColors.CheckedItems.Count > 0)
                {
                    Team selectedTeam = (Team)lstTeams.SelectedItem;
                    selectedTeam.TeamName = txtTeamName.Text;
                    selectedTeam.Colors.Clear();

                    foreach (var item in chklstColors.CheckedItems)
                    {
                        selectedTeam.Colors.Add((Models.Color)item);
                    }

                    _db.SaveChanges();
                    lstTeamsUpdate();
                    FormClean();
                    lstTeams.Enabled = true;
                    groupBox1.Text = "Add Team";
                    groupBox1.BackColor = System.Drawing.Color.Transparent;
                    btnAddTeam.Text = "Add Team";
                    btnDelete.Enabled = true;
                    btnPlayers.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You should enter Team Name and check one color at least.");
                }
            }

        }

        private void FormClean()
        {
            txtTeamName.Text = "";
            foreach (int i in chklstColors.CheckedIndices)
            {
                chklstColors.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamColorsUpdate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTeams.SelectedItems.Count > 0)
            {
                Team selectedTeam = (Team)lstTeams.SelectedItem;
                DialogResult dr = MessageBox.Show(
                    "Are you sure you want to remove team ?",
                    "Remove team ?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    _db.Teams.Remove(selectedTeam);
                    _db.SaveChanges();
                    lstTeamsUpdate();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Team selectedTeam = (Team)lstTeams.SelectedItem;

            for (int i = 0; i < chklstColors.Items.Count; i++)
            {
                if (selectedTeam.Colors.Contains(chklstColors.Items[i]))
                {
                    chklstColors.SetItemChecked(i, true);
                }
            }

            lstTeams.Enabled = false;
            txtTeamName.Text = selectedTeam.TeamName;
            groupBox1.Text = "Edit Team";
            groupBox1.BackColor = System.Drawing.Color.Aqua;
            btnAddTeam.Text = "Save Team";
            btnDelete.Enabled = false;
            btnPlayers.Enabled = false;
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            if (lstTeams.SelectedItems.Count > 0)
            {
                Team selectedTeam = (Team)lstTeams.SelectedItem;
                TeamPlayersForm form = new TeamPlayersForm(selectedTeam, _db);
                DialogResult dr = form.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    return;
                }
            }
        }
    }
}
