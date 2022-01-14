using DMProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMProject
{
    public partial class FormMainMenue : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public FormMainMenue()
        {
            InitializeComponent();
            random = new Random();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
            Text = childForm.Text + " - Admin";
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
                random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[tempIndex];
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
                    currentButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular,GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBox.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    Application.DoEvents();
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenue.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 70);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmProducts(), sender);
        }
        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmOrders(), sender);
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmCustomer(), sender);
        }
        private void btnReporting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmReporting(), sender);
        }
        private void btnNotifications_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmNotifications(), sender);
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmSettings(), sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                DisableButton();
                lblTitle.Text = "Home";
                Text = "Home - Admin";
            }
        }

        private void FormMainMenue_Load(object sender, EventArgs e)
        {
            Text = "Home - Admin";
        }
    }
}
