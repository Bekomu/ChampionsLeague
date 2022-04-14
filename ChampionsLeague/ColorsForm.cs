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
    public partial class ColorsForm : Form
    {
        private readonly ChampionsDbContext _db;

        public ColorsForm(ChampionsDbContext db)
        {
            InitializeComponent();
            _db = db;
            lstColorsUpdate();
        }

        private void lstColorsUpdate()
        {
            lstColors.DataSource = null;
            lstColors.DisplayMember = "ColorName";
            lstColors.ValueMember = "Id";
            lstColors.DataSource = _db.Colors.ToList();
        }

        private void tbarRed_Scroll(object sender, EventArgs e)
        {
            lblRed.Text = tbarRed.Value.ToString();
            pboColorPreview();
        }

        private void tbarGreen_Scroll(object sender, EventArgs e)
        {
            lblGreen.Text = tbarGreen.Value.ToString();
            pboColorPreview();
        }

        private void tbarBlue_Scroll(object sender, EventArgs e)
        {
            lblBlue.Text = tbarBlue.Value.ToString();
            pboColorPreview();
        }

        private void pboColorPreview()
        {
            pboColorPre.BackColor = System.Drawing.Color.FromArgb(tbarRed.Value, tbarGreen.Value, tbarBlue.Value);
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            if (btnAddColor.Text == "Create Color")
            {
                if (!string.IsNullOrEmpty(txtColorName.Text) &&
                    tbarRed.Value <= 255 && tbarRed.Value >= 0 &&
                    tbarGreen.Value <= 255 && tbarGreen.Value >= 0 &&
                    tbarBlue.Value <= 255 && tbarBlue.Value >= 0)
                {
                    _db.Colors.Add(new Models.Color
                    {
                        ColorName = txtColorName.Text,
                        Red = (byte)tbarRed.Value,
                        Green = (byte)tbarGreen.Value,
                        Blue = (byte)tbarBlue.Value
                    });
                    _db.SaveChanges();
                    lstColorsUpdate();
                    FormClean();
                }
                else
                {
                    MessageBox.Show("You should enter color name.");
                }
            }
            if (btnAddColor.Text == "Save Color")
            {
                if (!string.IsNullOrEmpty(txtColorName.Text) &&
                    tbarRed.Value <= 255 && tbarRed.Value >= 0 &&
                    tbarGreen.Value <= 255 && tbarGreen.Value >= 0 &&
                    tbarBlue.Value <= 255 && tbarBlue.Value >= 0)
                {
                    Models.Color selectedColor = (Models.Color)lstColors.SelectedItem;

                    selectedColor.ColorName = txtColorName.Text;
                    selectedColor.Red = (byte)tbarRed.Value;
                    selectedColor.Green = (byte)tbarGreen.Value;
                    selectedColor.Blue = (byte)tbarBlue.Value;
                    
                    _db.SaveChanges();
                    FormClean();
                    btnAddColor.Text = "Create Color";
                    groupBox1.Text = "Create Color";
                    groupBox1.BackColor = System.Drawing.Color.Transparent;
                    lstColors.Enabled = true;
                    btnRemove.Enabled = true;
                    lstColorsUpdate();
                }
                else
                {
                    MessageBox.Show("You should enter color name.");
                }
            }
        }

        private void FormClean()
        {
            tbarRed.Value = 0;
            tbarGreen.Value = 0;
            tbarBlue.Value = 0;
            txtColorName.Text = "";
            lblRed.Text = "0";
            lblGreen.Text = "0";
            lblBlue.Text = "0";
            pboColorPre.BackColor = System.Drawing.Color.Black;
        }

        private void lstColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstColors.SelectedItems.Count > 0)
            {
                Models.Color selectedColor = (Models.Color)lstColors.SelectedItem;
                pboColor.BackColor = System.Drawing.Color.FromArgb(selectedColor.Red, selectedColor.Green, selectedColor.Blue);
            }
            else
            {
                pboColor.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstColors.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show(
                "Are you sure you want to remove this color ?",
                "Color remove ?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                    Models.Color selectedColor = (Models.Color)lstColors.SelectedItem;
                    _db.Colors.Remove(selectedColor);
                    _db.SaveChanges();
                    lstColorsUpdate();
                }
            }
        }

        private void btnColorEdit_Click(object sender, EventArgs e)
        {
            if (lstColors.SelectedItems.Count > 0)
            {
                Models.Color selectedColor = (Models.Color)lstColors.SelectedItem;
                btnAddColor.Text = "Save Color";
                groupBox1.Text = "Edit Color";
                groupBox1.BackColor = System.Drawing.Color.Aqua;
                lstColors.Enabled = false;
                btnRemove.Enabled = false;
                txtColorName.Text = selectedColor.ColorName;
                tbarRed.Value = selectedColor.Red;
                lblRed.Text = tbarRed.Value.ToString();
                tbarGreen.Value = selectedColor.Green;
                lblGreen.Text = tbarGreen.Value.ToString();
                tbarBlue.Value = selectedColor.Blue;
                lblBlue.Text = tbarBlue.Value.ToString();
            }
        }
    }
}
