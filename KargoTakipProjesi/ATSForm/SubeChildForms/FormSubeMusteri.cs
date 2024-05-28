using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoTakipProjesi.Forms
{
    public partial class FormSubeMusteri : Form
    {
        public FormSubeMusteri()
        {
            InitializeComponent();

        }
        private void FormAdminKullanıcı_Load(Object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            Subelabel4.ForeColor = ThemeColor.SecondaryColor;
            Subelabel5.ForeColor = ThemeColor.PrimaryColor;

        }

        private void Subebutton1_Click(object sender, EventArgs e)
        {

        }

        private void SubetextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubetextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Subelabel5_Click(object sender, EventArgs e)
        {

        }

        private void SubetextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
