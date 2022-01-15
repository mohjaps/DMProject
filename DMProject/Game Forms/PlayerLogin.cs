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
        int isPlayer = 0;
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
            if (Text.Contains("New"))
            {
                isPlayer = 1;
                gboxNew.Text = Text;
            }
            else if (Text.Contains("Update"))
            {
                isPlayer = 2;
                gboxNew.Text = Text;
                try
                {
                    Player player = DatabaseCongfigurations.GetPlayer(Tag.ToString());
                    if (player != null)
                    {
                        txtUsername.ReadOnly = true;
                        txtUsername.Text = player.Username;
                        txtName.Text = player.Name;
                        txtAge.Value = player.Age;
                    }
                    else
                    {
                        MessageBox.Show("An Error Was Ocuured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (isPlayer == 0)
            {
                gboxLogin.Visible = radioBtnExixtedPlayer.Checked;
                gboxNew.Visible = radioBtnNew.Checked;
            }
            else
            {
                radioBtnNew.Visible = false;
                radioBtnExixtedPlayer.Visible = false;
                gboxNew.Visible = true;
                gboxLogin.Visible = false;
            }
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
                        if (isPlayer == 0 || isPlayer == 1)
                        {
                            if (playerPlus == null)
                            {
                                int k = -1;
                                k = DatabaseCongfigurations.AddPlayer(palyer);

                                if (k > 0)
                                {
                                    if (isPlayer == 0)
                                    {
                                        HomePlay frm = new HomePlay();
                                        frm.Tag = palyer.Username;
                                        this.Hide();
                                        frm.ShowDialog();
                                        this.Close();
                                    }
                                    else
                                    {
                                        DialogResult res = MessageBox.Show("Player Has Inserted Do You Want To Insert Another One?", "Inf", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                        if (res == DialogResult.Yes)
                                        {
                                            txtUsername.Text = "";
                                            txtName.Text = "";
                                            txtAge.Value = txtAge.Minimum;
                                        }
                                        else Close();
                                    }
                                }

                            }
                            else
                            {
                                if (isPlayer == 0)
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
                                else
                                    MessageBox.Show("This Account Is Already Existed", "Inf", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (isPlayer == 2)
                        {
                            if (playerPlus != null)
                            {
                                palyer.Score = playerPlus.Score;
                                palyer.LastLogin = playerPlus.LastLogin;
                                int res = DatabaseCongfigurations.UpdatePlayer(palyer);
                                if (res > 0) MessageBox.Show("Player Has Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else MessageBox.Show("Player Has Not Updated", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else 
                            {
                                MessageBox.Show("An Error Was Occured Whilt Updating The Player", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Close();
                            };
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

        private void PlayerLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
