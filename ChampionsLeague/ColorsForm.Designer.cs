namespace ChampionsLeague
{
    partial class ColorsForm
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.pboColor = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pboColorPre = new System.Windows.Forms.PictureBox();
            this.tbarBlue = new System.Windows.Forms.TrackBar();
            this.tbarGreen = new System.Windows.Forms.TrackBar();
            this.tbarRed = new System.Windows.Forms.TrackBar();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.lstColors = new System.Windows.Forms.ListBox();
            this.btnColorEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboColor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboColorPre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarRed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(416, 298);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 30);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove Color";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pboColor
            // 
            this.pboColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboColor.Location = new System.Drawing.Point(332, 259);
            this.pboColor.Name = "pboColor";
            this.pboColor.Size = new System.Drawing.Size(194, 34);
            this.pboColor.TabIndex = 17;
            this.pboColor.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBlue);
            this.groupBox1.Controls.Add(this.lblGreen);
            this.groupBox1.Controls.Add(this.lblRed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pboColorPre);
            this.groupBox1.Controls.Add(this.tbarBlue);
            this.groupBox1.Controls.Add(this.tbarGreen);
            this.groupBox1.Controls.Add(this.tbarRed);
            this.groupBox1.Controls.Add(this.btnAddColor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtColorName);
            this.groupBox1.Location = new System.Drawing.Point(16, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 309);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Color";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(206, 209);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(16, 17);
            this.lblBlue.TabIndex = 27;
            this.lblBlue.Text = "0";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(206, 159);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(16, 17);
            this.lblGreen.TabIndex = 26;
            this.lblGreen.Text = "0";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(206, 106);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(16, 17);
            this.lblRed.TabIndex = 25;
            this.lblRed.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Blue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Green";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Red";
            // 
            // pboColorPre
            // 
            this.pboColorPre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pboColorPre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboColorPre.Location = new System.Drawing.Point(254, 56);
            this.pboColorPre.Name = "pboColorPre";
            this.pboColorPre.Size = new System.Drawing.Size(37, 238);
            this.pboColorPre.TabIndex = 21;
            this.pboColorPre.TabStop = false;
            // 
            // tbarBlue
            // 
            this.tbarBlue.Location = new System.Drawing.Point(56, 205);
            this.tbarBlue.Maximum = 255;
            this.tbarBlue.Name = "tbarBlue";
            this.tbarBlue.Size = new System.Drawing.Size(144, 45);
            this.tbarBlue.TabIndex = 12;
            this.tbarBlue.Scroll += new System.EventHandler(this.tbarBlue_Scroll);
            // 
            // tbarGreen
            // 
            this.tbarGreen.Location = new System.Drawing.Point(56, 154);
            this.tbarGreen.Maximum = 255;
            this.tbarGreen.Name = "tbarGreen";
            this.tbarGreen.Size = new System.Drawing.Size(144, 45);
            this.tbarGreen.TabIndex = 11;
            this.tbarGreen.Scroll += new System.EventHandler(this.tbarGreen_Scroll);
            // 
            // tbarRed
            // 
            this.tbarRed.Location = new System.Drawing.Point(56, 103);
            this.tbarRed.Maximum = 255;
            this.tbarRed.Name = "tbarRed";
            this.tbarRed.Size = new System.Drawing.Size(144, 45);
            this.tbarRed.TabIndex = 10;
            this.tbarRed.Scroll += new System.EventHandler(this.tbarRed_Scroll);
            // 
            // btnAddColor
            // 
            this.btnAddColor.Location = new System.Drawing.Point(13, 264);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(226, 30);
            this.btnAddColor.TabIndex = 9;
            this.btnAddColor.Text = "Create Color";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Color Name :";
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(13, 56);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(226, 25);
            this.txtColorName.TabIndex = 0;
            // 
            // lstColors
            // 
            this.lstColors.FormattingEnabled = true;
            this.lstColors.ItemHeight = 17;
            this.lstColors.Location = new System.Drawing.Point(332, 45);
            this.lstColors.Name = "lstColors";
            this.lstColors.Size = new System.Drawing.Size(194, 208);
            this.lstColors.TabIndex = 10;
            this.lstColors.SelectedIndexChanged += new System.EventHandler(this.lstColors_SelectedIndexChanged);
            // 
            // btnColorEdit
            // 
            this.btnColorEdit.Location = new System.Drawing.Point(332, 298);
            this.btnColorEdit.Name = "btnColorEdit";
            this.btnColorEdit.Size = new System.Drawing.Size(80, 30);
            this.btnColorEdit.TabIndex = 20;
            this.btnColorEdit.Text = "Edit Color";
            this.btnColorEdit.UseVisualStyleBackColor = true;
            this.btnColorEdit.Click += new System.EventHandler(this.btnColorEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Colors";
            // 
            // ColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 349);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnColorEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.pboColor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstColors);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(559, 388);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(559, 388);
            this.Name = "ColorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Colors";
            ((System.ComponentModel.ISupportInitialize)(this.pboColor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboColorPre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox pboColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.ListBox lstColors;
        private System.Windows.Forms.Button btnColorEdit;
        private System.Windows.Forms.PictureBox pboColorPre;
        private System.Windows.Forms.TrackBar tbarBlue;
        private System.Windows.Forms.TrackBar tbarGreen;
        private System.Windows.Forms.TrackBar tbarRed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label label5;
    }
}