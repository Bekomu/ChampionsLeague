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
    public partial class NewMatchForm : Form
    {
        private readonly ChampionsDbContext _db;
        private readonly Match _match;

        public NewMatchForm(ChampionsDbContext db, Match match)
        {
            InitializeComponent();
            _db = db;
            _match = match;
            cboHomeTeam.DisplayMember = "TeamName";
            cboHomeTeam.ValueMember = "Id";
            cboHomeTeam.DataSource = _db.Teams.ToList();
            MatchNullCheck();
        }

        private void MatchNullCheck()
        {
            if (_match != null)
            {
                btnCreate.Text = "Edit Match";
                this.Text = $"Edit --- > {_match.Team1}:{_match.Score1} - {_match.Team2}:{_match.Score1} ______ {_match.MatchTime}";
                if (_match.Score1 != null && _match.Score2 != null)
                {
                    nudScore1.Value = (int)_match.Score1;
                    nudScore2.Value = (int)_match.Score2;
                }
                dtpMatchTime.Value = _match.MatchTime;
                cboHomeTeam.SelectedValue = _match.Team1.Id;
                cboAwayTeam.SelectedValue = _match.Team2.Id;
            }
        }

        private void dtpMatchTime_ValueChanged(object sender, EventArgs e)
        {
            if (dtpMatchTime.Value > DateTime.Now)
            {
                nudScore1.Enabled = false;
                nudScore2.Enabled = false;
            }
            else
            {
                nudScore1.Enabled = true;
                nudScore2.Enabled = true;
            }
        }

        private void cboHomeTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboAwayUpdate();
        }

        private void cboAwayUpdate()
        {
            cboAwayTeam.DisplayMember = "TeamName";
            cboAwayTeam.ValueMember = "Id";
            cboAwayTeam.DataSource = _db.Teams.Where(x => x.Id != ((Team)cboHomeTeam.SelectedItem).Id).ToList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnCreate.Text == "Create Match")
            {
                if (cboHomeTeam.SelectedIndex != -1 && cboAwayTeam.SelectedIndex != -1)
                {
                    if (nudScore1.Enabled == false && nudScore2.Enabled == false)
                    {
                        _db.Matches.Add(new Match
                        {
                            MatchTime = dtpMatchTime.Value,
                            Team1 = (Team)cboHomeTeam.SelectedItem,
                            Team2 = (Team)cboAwayTeam.SelectedItem,
                            Score1 = null,
                            Score2 = null
                        });
                    }
                    else
                    {
                        _db.Matches.Add(new Match
                        {
                            MatchTime = dtpMatchTime.Value,
                            Team1 = (Team)cboHomeTeam.SelectedItem,
                            Team2 = (Team)cboAwayTeam.SelectedItem,
                            Score1 = (int)nudScore1.Value,
                            Score2 = (int)nudScore2.Value
                        });
                    }
                    _db.SaveChanges();
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You should select home and away teams");
                }
            }
            if (btnCreate.Text == "Edit Match")
            {
                if (cboHomeTeam.SelectedIndex != -1 && cboAwayTeam.SelectedIndex != -1)
                {
                    if (nudScore1.Enabled == false && nudScore2.Enabled == false)
                    {
                        _match.MatchTime = dtpMatchTime.Value;
                        _match.Team1 = (Team)cboHomeTeam.SelectedItem;
                        _match.Team2 = (Team)cboAwayTeam.SelectedItem;
                        _match.Score1 = null;
                        _match.Score2 = null;
                    }
                    else
                    {
                        _match.MatchTime = dtpMatchTime.Value;
                        _match.Team1 = (Team)cboHomeTeam.SelectedItem;
                        _match.Team2 = (Team)cboAwayTeam.SelectedItem;
                        _match.Score1 = (int)nudScore1.Value;
                        _match.Score2 = (int)nudScore2.Value;
                    }
                    _db.SaveChanges();
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You should select home and away teams");
                }
            }
        }
    }
}
