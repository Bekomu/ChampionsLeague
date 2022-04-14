namespace ChampionsLeague
{
    partial class TeamsForm
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
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.lblTeams = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chklstColors = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.pboColor1 = new System.Windows.Forms.PictureBox();
            this.pboColor2 = new System.Windows.Forms.PictureBox();
            this.pboColor3 = new System.Windows.Forms.PictureBox();
            this.pboColor4 = new System.Windows.Forms.PictureBox();
            this.pboColor5 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPlayers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboColor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboColor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboColor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboColor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboColor5)).BeginInit();
            this.SuspendLayout();
            // 
            // lstTeams
            // 
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.ItemHeight = 17;
            this.lstTeams.Location = new System.Drawing.Point(264, 52);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(200, 242);
            this.lstTeams.TabIndex = 0;
            this.lstTeams.SelectedIndexChanged += new System.EventHandler(this.lstTeams_SelectedIndexChanged);
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Location = new System.Drawing.Point(261, 21);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(52, 17);
            this.lblTeams.TabIndex = 1;
            this.lblTeams.Text = "Teams";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.chklstColors);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTeamName);
            this.groupBox1.Location = new System.Drawing.Point(14, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 275);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Teams";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(194, 30);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Team";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chklstColors
            // 
            this.chklstColors.FormattingEnabled = true;
            this.chklstColors.Location = new System.Drawing.Point(13, 100);
            this.chklstColors.Name = "chklstColors";
            this.chklstColors.Size = new System.Drawing.Size(194, 124);
            this.chklstColors.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Team Name :";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(13, 56);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(194, 25);
            this.txtTeamName.TabIndex = 0;
            // 
            // pboColor1
            // 
            this.pboColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboColor1.Location = new System.Drawing.Point(482, 53);
            this.pboColor1.Name = "pboColor1";
            this.pboColor1.Size = new System.Drawing.Size(152, 23);
            this.pboColor1.TabIndex = 3;
            this.pboColor1.TabStop = false;
            // 
            // pboColor2
            // 
            this.pboColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboColor2.Location = new System.Drawing.Point(482, 75);
            this.pboColor2.Name = "pboColor2";
            this.pboColor2.Size = new System.Drawing.Size(152, 23);
            this.pboColor2.TabIndex = 4;
            this.pboColor2.TabStop = false;
            // 
            // pboColor3
            // 
            this.pboColor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboColor3.Location = new System.Drawing.Point(482, 97);
            this.pboColor3.Name = "pboColor3";
            this.pboColor3.Size = new System.Drawing.Size(152, 23);
            this.pboColor3.TabIndex = 5;
            this.pboColor3.TabStop = false;
            // 
            // pboColor4
            // 
            this.pboColor4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboColor4.Location = new System.Drawing.Point(482, 119);
            this.pboColor4.Name = "pboColor4";
            this.pboColor4.Size = new System.Drawing.Size(152, 23);
            this.pboColor4.TabIndex = 6;
            this.pboColor4.TabStop = false;
            // 
            // pboColor5
            // 
            this.pboColor5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboColor5.Location = new System.Drawing.Point(482, 141);
            this.pboColor5.Name = "pboColor5";
            this.pboColor5.Size = new System.Drawing.Size(152, 23);
            this.pboColor5.TabIndex = 7;
            this.pboColor5.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(482, 264);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Team";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(482, 228);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(152, 30);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit Team";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPlayers
            // 
            this.btnPlayers.Location = new System.Drawing.Point(482, 192);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Size = new System.Drawing.Size(152, 30);
            this.btnPlayers.TabIndex = 11;
            this.btnPlayers.Text = "Team Players";
            this.btnPlayers.UseVisualStyleBackColor = true;
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Team Colors";
            // 
            // TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 314);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPlayers);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pboColor5);
            this.Controls.Add(this.pboColor4);
            this.Controls.Add(this.pboColor3);
            this.Controls.Add(this.pboColor2);
            this.Controls.Add(this.pboColor1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTeams);
            this.Controls.Add(this.lstTeams);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(677, 353);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(677, 353);
            this.Name = "TeamsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Teams";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboColor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboColor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboColor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboColor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboColor5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckedListBox chklstColors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.PictureBox pboColor1;
        private System.Windows.Forms.PictureBox pboColor2;
        private System.Windows.Forms.PictureBox pboColor3;
        private System.Windows.Forms.PictureBox pboColor4;
        private System.Windows.Forms.PictureBox pboColor5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPlayers;
        private System.Windows.Forms.Label label2;
    }
}