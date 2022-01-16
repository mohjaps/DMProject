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

namespace DMProject.Forms
{
    public partial class frmSettings : Form
    {
        Admin admin = null;
        public frmSettings()
        {
            InitializeComponent();
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtCurrentPass.Text.Length <= 0 || txtNewPass.Text.Length <= 0 || txtRetypePass.Text.Length <= 0)
            {
                lblError.Visible = true;
                lblError.Text = "Retype Empty Fields";
                return;
            }
            if (txtCurrentPass.Text != admin.Password)
            {
                lblError.Visible = true;
                lblError.Text = "Wrong Password";
                return;
            }
            if (txtNewPass.Text != txtRetypePass.Text)
            {
                lblError.Visible = true;
                lblError.Text = "Password Retype The Password Correctly";
                return;
            }
            try
            {
                admin.Password = txtNewPass.Text;
                DatabaseCongfigurations.UpdateAdminPassword(admin);
                lblError.Visible = true;
                lblError.Text = "Password Updated Successfully";
                txtCurrentPass.Text = "";
                txtNewPass.Text = "";
                txtRetypePass.Text = "";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            admin = (Admin)Tag;
            txtNewName.Text = admin.FullName;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtCurrentName.Text.Length <= 0)
            {
                lblError2.Visible = true;
                lblError2.Text = "Enter The New Name";
                return;
            }
            try
            {
                admin.FullName = txtNewName.Text;
                DatabaseCongfigurations.UpdateAdminName(admin);
                lblError2.Visible = true;
                lblError.Text = "Name Updated Successfully";
                txtNewName.Text = "";
            }
            catch (Exception ex)
            {
                lblError2.Text = ex.Message;
            }
        }
    }
}
