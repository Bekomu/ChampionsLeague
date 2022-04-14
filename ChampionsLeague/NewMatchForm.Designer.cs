namespace ChampionsLeague
{
    partial class NewMatchForm
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
            this.dtpMatchTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudScore1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cboHomeTeam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudScore2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cboAwayTeam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpMatchTime
            // 
            this.dtpMatchTime.CustomFormat = " dd.MM.yyyy - - HH:mm";
            this.dtpMatchTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMatchTime.Location = new System.Drawing.Point(191, 57);
            this.dtpMatchTime.Name = "dtpMatchTime";
            this.dtpMatchTime.Size = new System.Drawing.Size(177, 24);
            this.dtpMatchTime.TabIndex = 0;
            this.dtpMatchTime.Value = new System.DateTime(2022, 1, 1, 20, 0, 0, 0);
            this.dtpMatchTime.ValueChanged += new System.EventHandler(this.dtpMatchTime_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Match Time";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudScore1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboHomeTeam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Home Team";
            // 
            // nudScore1
            // 
            this.nudScore1.Location = new System.Drawing.Point(68, 89);
            this.nudScore1.Name = "nudScore1";
            this.nudScore1.Size = new System.Drawing.Size(160, 24);
            this.nudScore1.TabIndex = 7;
            this.nudScore1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Score :";
            // 
            // cboHomeTeam
            // 
            this.cboHomeTeam.FormattingEnabled = true;
            this.cboHomeTeam.Location = new System.Drawing.Point(66, 41);
            this.cboHomeTeam.Name = "cboHomeTeam";
            this.cboHomeTeam.Size = new System.Drawing.Size(162, 26);
            this.cboHomeTeam.TabIndex = 5;
            this.cboHomeTeam.SelectedIndexChanged += new System.EventHandler(this.cboHomeTeam_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Team :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudScore2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboAwayTeam);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(299, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 143);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Away Team";
            // 
            // nudScore2
            // 
            this.nudScore2.Location = new System.Drawing.Point(71, 93);
            this.nudScore2.Name = "nudScore2";
            this.nudScore2.Size = new System.Drawing.Size(160, 24);
            this.nudScore2.TabIndex = 8;
            this.nudScore2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Score :";
            // 
            // cboAwayTeam
            // 
            this.cboAwayTeam.FormattingEnabled = true;
            this.cboAwayTeam.Location = new System.Drawing.Point(69, 44);
            this.cboAwayTeam.Name = "cboAwayTeam";
            this.cboAwayTeam.Size = new System.Drawing.Size(162, 26);
            this.cboAwayTeam.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Team :";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(201, 251);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(151, 39);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create Match";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Time";
            // 
            // NewMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 302);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpMatchTime);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(574, 341);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(574, 341);
            this.Name = "NewMatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Match";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpMatchTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboHomeTeam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboAwayTeam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudScore1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudScore2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}