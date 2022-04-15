## Soccer / Football League Table App
This is the .Net Framework(C#) Windows Forms App which you can create teams, team colors, players and played/unplayed matches. 
Also it creates database and tables with code. You should just change connection strings for your database.

### Main Screen
You can see played matches and matches which will play.

![main_screen](https://i.hizliresim.com/m807soc.png)
----

### Colors Screen
You can create colors in this screen.

![colors_screen](https://i.hizliresim.com/59xbx7m.png)
----

### Teams Screen
You can add teams and edit in this screen. Also see 5 of colors of selected team. 
If you want to arrange players of team, you should open Team Players screen with button.
 
![teams_screen](https://i.hizliresim.com/hn1dknv.png)

----

![teams_players_screen](https://i.hizliresim.com/echoztq.png)
----

### Players Screen
You can add players and edit in this screen. 

![players_screen](https://i.hizliresim.com/1aqzdqa.png)
----

### Match Screen
You can create or edit matches in this screen.
Creating :

![match_create_screen](https://i.hizliresim.com/36vaqhn.png)

----
Editing:

![match_editing_screen](https://i.hizliresim.com/felivlm.png)

----

##### Code Sample

```cs
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
```  
----
