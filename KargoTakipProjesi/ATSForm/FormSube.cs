using Google.Apis.Calendar.v3.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoTakipProjesi
{
    public partial class FormSube : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        //Constructor
        public FormSube()
        {
            InitializeComponent();
            random = new Random();
            btnSubeCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelSubeTitleBar.BackColor = color;
                    panelSubeLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnSubeCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelSubelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenSubeChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelSubeDesktopPanell.Controls.Add(childForm);
            this.panelSubeDesktopPanell.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblSubeTitle.Text = childForm.Text;
        }
        private void btnSubeProducts_Click_1(object sender, EventArgs e)
        {
            OpenSubeChildForm(new Forms.FormSubeMusteri(), sender);
        }
        private void btnSubeOrders_Click_1(object sender, EventArgs e)
        {
            OpenSubeChildForm(new Forms.FormSubeKargo(), sender);
        }
        private void btnSubeCustomers_Click_1(object sender, EventArgs e)
        {
            OpenSubeChildForm(new Forms.FormSubeTeslimat(), sender);
        }
        private void btnSubeCloseChildForm_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblSubeTitle.Text = "HOME";
            panelSubeTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelSubeLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnSubeCloseChildForm.Visible = false;
        }
        private void panelSubeTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnSubeClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSubeMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void bntSubeMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormSube_Load(object sender, EventArgs e)
        {

        }

        private void panelSubeDesktopPanell_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSubeTitle_Click(object sender, EventArgs e)
        {

        }
    }
}

