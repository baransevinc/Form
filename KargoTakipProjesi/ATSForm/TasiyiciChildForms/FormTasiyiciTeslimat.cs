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
    public partial class FormTasiyiciTeslimat : Form
    {
        public FormTasiyiciTeslimat()
        {
            InitializeComponent();

        }
        private void FormTasiyiciTeslimat_Load(Object sender, EventArgs e)
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
            Tasiyicilabel4.ForeColor = ThemeColor.SecondaryColor;
            Tasiyicilabel5.ForeColor = ThemeColor.PrimaryColor;

        }

        private void Tasiyicibutton1_Click(object sender, EventArgs e)
        {

        }

        private void TasiyicitextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TasiyicitextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tasiyicilabel5_Click(object sender, EventArgs e)
        {

        }

        private void TasiyicitextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
