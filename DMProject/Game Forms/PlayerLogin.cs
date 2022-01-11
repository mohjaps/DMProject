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
    public partial class PlayerLogin : Form
    {
        public PlayerLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlayerLogin_Load(object sender, EventArgs e)
        {
            gboxNew.Visible = radioBtnNew.Checked;
            gboxLogin.Visible = radioBtnExixtedPlayer.Checked;
        }

        private void radioBtnExixtedPlayer_CheckedChanged(object sender, EventArgs e)
        {
            gboxNew.Visible = radioBtnNew.Checked;
            gboxLogin.Visible = radioBtnExixtedPlayer.Checked;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (radioBtnNew.Checked)
            {
                if (txtUsername.Text.Length > 0 && txtName.Text.Length > 0)
                {Player palyer = new Player()
                {
                    Username = txtUsername.Text.Trim(),
                    Name = txtName.Text.Trim(),
                    Age = int.Parse(txtAge.Text.Trim()),
                };
                try
                {
                    Player playerPlus = DatabaseCongfigurations.GetPlayer(palyer.Username);
                    if (playerPlus == null)
                    {
                        int k = -1;
                            k = DatabaseCongfigurations.AddPlayer(palyer);
                        
                        if (k > 0)
                        {
                            HomePlay frm = new HomePlay();
                            frm.Tag = palyer.Username;
                            this.Hide();
                            frm.ShowDialog();
                            this.Close();
                        }

                    }
                    else
                    {
                        DialogResult res = MessageBox.Show("This Account Is Already Existed Do Youu Want To LogIn By It ?", "Account Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                        {
                            HomePlay frm = new HomePlay();
                            frm.Tag = palyer.Username;
                            this.Hide();
                            frm.ShowDialog();
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
                else
                {
                    MessageBox.Show("Please Fill The Requiered Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                

            }
            else if (radioBtnExixtedPlayer.Checked)
            {
                if (txtUsernameLogin.Text.Length > 0)
                {
                    Player palyer = new Player()
                {
                    Username = txtUsernameLogin.Text
                };

                Player playerPlus = DatabaseCongfigurations.GetPlayer(palyer.Username);
                
                if (playerPlus == null)
                {
                    MessageBox.Show("This Account Is Not Existed", "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    HomePlay frm = new HomePlay();
                    frm.Tag = palyer.Username;
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                }
                else
                {
                    MessageBox.Show("Please Fill The Requiered Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }
    }
}
