namespace ChampionsLeague
{
    partial class TeamPlayersForm
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
            this.gboxTeamPlayers = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvTeamPlayers = new System.Windows.Forms.DataGridView();
            this.gboxAll = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAllPlayers = new System.Windows.Forms.DataGridView();
            this.gboxTeamPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamPlayers)).BeginInit();
            this.gboxAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxTeamPlayers
            // 
            this.gboxTeamPlayers.Controls.Add(this.btnDelete);
            this.gboxTeamPlayers.Controls.Add(this.dgvTeamPlayers);
            this.gboxTeamPlayers.Location = new System.Drawing.Point(15, 12);
            this.gboxTeamPlayers.Name = "gboxTeamPlayers";
            this.gboxTeamPlayers.Size = new System.Drawing.Size(375, 491);
            this.gboxTeamPlayers.TabIndex = 5;
            this.gboxTeamPlayers.TabStop = false;
            this.gboxTeamPlayers.Text = "Team Players";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(6, 448);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(363, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "button1";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvTeamPlayers
            // 
            this.dgvTeamPlayers.AllowUserToAddRows = false;
            this.dgvTeamPlayers.AllowUserToDeleteRows = false;
            this.dgvTeamPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTeamPlayers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTeamPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamPlayers.Location = new System.Drawing.Point(6, 24);
            this.dgvTeamPlayers.MultiSelect = false;
            this.dgvTeamPlayers.Name = "dgvTeamPlayers";
            this.dgvTeamPlayers.ReadOnly = true;
            this.dgvTeamPlayers.RowHeadersVisible = false;
            this.dgvTeamPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeamPlayers.Size = new System.Drawing.Size(363, 407);
            this.dgvTeamPlayers.TabIndex = 2;
            // 
            // gboxAll
            // 
            this.gboxAll.Controls.Add(this.btnAdd);
            this.gboxAll.Controls.Add(this.dgvAllPlayers);
            this.gboxAll.Location = new System.Drawing.Point(425, 12);
            this.gboxAll.Name = "gboxAll";
            this.gboxAll.Size = new System.Drawing.Size(375, 491);
            this.gboxAll.TabIndex = 6;
            this.gboxAll.TabStop = false;
            this.gboxAll.Text = "All Players";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(6, 448);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(363, 37);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAllPlayers
            // 
            this.dgvAllPlayers.AllowUserToAddRows = false;
            this.dgvAllPlayers.AllowUserToDeleteRows = false;
            this.dgvAllPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAllPlayers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAllPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPlayers.Location = new System.Drawing.Point(6, 24);
            this.dgvAllPlayers.MultiSelect = false;
            this.dgvAllPlayers.Name = "dgvAllPlayers";
            this.dgvAllPlayers.ReadOnly = true;
            this.dgvAllPlayers.RowHeadersVisible = false;
            this.dgvAllPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllPlayers.Size = new System.Drawing.Size(364, 407);
            this.dgvAllPlayers.TabIndex = 2;
            // 
            // TeamPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 521);
            this.Controls.Add(this.gboxAll);
            this.Controls.Add(this.gboxTeamPlayers);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(830, 560);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(830, 560);
            this.Name = "TeamPlayersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Team Players";
            this.gboxTeamPlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamPlayers)).EndInit();
            this.gboxAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxTeamPlayers;
        private System.Windows.Forms.DataGridView dgvTeamPlayers;
        private System.Windows.Forms.GroupBox gboxAll;
        private System.Windows.Forms.DataGridView dgvAllPlayers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}