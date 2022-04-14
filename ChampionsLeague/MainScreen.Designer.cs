namespace ChampionsLeague
{
    partial class MainScreen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlayers = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTeamColors = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.btnNewMatch = new System.Windows.Forms.Button();
            this.btnEditMatch = new System.Windows.Forms.Button();
            this.btnDeleteMatch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTeams,
            this.btnPlayers,
            this.btnTeamColors});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(680, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnTeams
            // 
            this.btnTeams.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Size = new System.Drawing.Size(59, 23);
            this.btnTeams.Text = "Teams";
            this.btnTeams.Click += new System.EventHandler(this.btnTeams_Click);
            // 
            // btnPlayers
            // 
            this.btnPlayers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Size = new System.Drawing.Size(64, 23);
            this.btnPlayers.Text = "Players";
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // btnTeamColors
            // 
            this.btnTeamColors.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTeamColors.Name = "btnTeamColors";
            this.btnTeamColors.Size = new System.Drawing.Size(96, 23);
            this.btnTeamColors.Text = "Team Colors";
            this.btnTeamColors.Click += new System.EventHandler(this.btnTeamColors_Click);
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Location = new System.Drawing.Point(11, 74);
            this.dgvMatches.MultiSelect = false;
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.RowHeadersVisible = false;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(659, 294);
            this.dgvMatches.TabIndex = 1;
            // 
            // btnNewMatch
            // 
            this.btnNewMatch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewMatch.Location = new System.Drawing.Point(564, 35);
            this.btnNewMatch.Name = "btnNewMatch";
            this.btnNewMatch.Size = new System.Drawing.Size(105, 28);
            this.btnNewMatch.TabIndex = 2;
            this.btnNewMatch.Text = "+ New Match";
            this.btnNewMatch.UseVisualStyleBackColor = true;
            this.btnNewMatch.Click += new System.EventHandler(this.btnNewMatch_Click);
            // 
            // btnEditMatch
            // 
            this.btnEditMatch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditMatch.Location = new System.Drawing.Point(11, 382);
            this.btnEditMatch.Name = "btnEditMatch";
            this.btnEditMatch.Size = new System.Drawing.Size(115, 28);
            this.btnEditMatch.TabIndex = 3;
            this.btnEditMatch.Text = "Edit Selection";
            this.btnEditMatch.UseVisualStyleBackColor = true;
            this.btnEditMatch.Click += new System.EventHandler(this.btnEditMatch_Click);
            // 
            // btnDeleteMatch
            // 
            this.btnDeleteMatch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteMatch.Location = new System.Drawing.Point(143, 382);
            this.btnDeleteMatch.Name = "btnDeleteMatch";
            this.btnDeleteMatch.Size = new System.Drawing.Size(131, 28);
            this.btnDeleteMatch.TabIndex = 4;
            this.btnDeleteMatch.Text = "Delete Selection";
            this.btnDeleteMatch.UseVisualStyleBackColor = true;
            this.btnDeleteMatch.Click += new System.EventHandler(this.btnDeleteMatch_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 430);
            this.Controls.Add(this.btnDeleteMatch);
            this.Controls.Add(this.btnEditMatch);
            this.Controls.Add(this.btnNewMatch);
            this.Controls.Add(this.dgvMatches);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(696, 469);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "League Screen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnTeams;
        private System.Windows.Forms.ToolStripMenuItem btnPlayers;
        private System.Windows.Forms.ToolStripMenuItem btnTeamColors;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.Button btnNewMatch;
        private System.Windows.Forms.Button btnEditMatch;
        private System.Windows.Forms.Button btnDeleteMatch;
    }
}