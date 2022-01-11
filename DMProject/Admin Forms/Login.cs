using DMProject.Models;
using DMProject.Models.Principles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMProject.Game_Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            //if (((TextBox)sender).Text == "Place Holder text...")
            //{
            //    ((TextBox)sender).Text = "";
            //}
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            //if (((TextBox)sender).Text == "")
            //{
            //    ((TextBox)sender).Text = "Place Holder text...";

            //}
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Admin admin = DatabaseCongfigurations.GetAdmin(txtLogin.Text);
                if (admin != null && txtLogin.Text.Trim() == admin.Username)
                {
                    if (txtPassword.Text.Trim() == admin.Password)
                    {
                        this.Hide();
                        new FormMainMenue().ShowDialog();
                        this.Show();
                    }
                    else MessageBox.Show("Password Is Wrong...", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Account Is Not Existed...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error Has Occured...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
