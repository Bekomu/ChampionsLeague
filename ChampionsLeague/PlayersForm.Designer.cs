namespace ChampionsLeague
{
    partial class PlayersForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTeams = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cboTeams);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPlayerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Name :";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(9, 70);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(182, 25);
            this.txtPlayerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Team :";
            // 
            // cboTeams
            // 
            this.cboTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeams.FormattingEnabled = true;
            this.cboTeams.Location = new System.Drawing.Point(9, 149);
            this.cboTeams.Name = "cboTeams";
            this.cboTeams.Size = new System.Drawing.Size(182, 25);
            this.cboTeams.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(70, 211);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Player";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPlayers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Location = new System.Drawing.Point(228, 47);
            this.dgvPlayers.MultiSelect = false;
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowHeadersVisible = false;
            this.dgvPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayers.Size = new System.Drawing.Size(373, 334);
            this.dgvPlayers.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(471, 390);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 27);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Remove Player";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(228, 391);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 27);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit Player";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Players";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Team :";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(429, 13);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(172, 25);
            this.txtTeamName.TabIndex = 7;
            this.txtTeamName.TextChanged += new System.EventHandler(this.txtTeamName_TextChanged);
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 429);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(629, 468);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(629, 468);
            this.Name = "PlayersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Players";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboTeams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTeamName;
    }
}