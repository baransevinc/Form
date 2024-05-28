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
    public partial class FormSubeKargo : Form
    {
        public FormSubeKargo()
        {
            InitializeComponent();

        }

        private void FormSubeKargo_Load(object sender, EventArgs e)
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

        private void Subelabel1_Click(object sender, EventArgs e)
        {

        }

        private void SubepreviousBtn_Click(object sender, EventArgs e)
        {

        }

        private void Subelabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
