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
    public partial class userDetails : Form
    {
        Player player = new Player();
        public userDetails()
        {
            InitializeComponent();
        }

        private void userDetails_Load(object sender, EventArgs e)
        {
            player = (Player)Tag;
            try
            {
                lblTotalRounds.Text = "Rounds For Player: " + player.Name;
                guna2DataGridView1.DataSource = DatabaseCongfigurations.GetRoundViewByUsername(player.Username);
                guna2DataGridView1.Columns[0].Visible = false;
                guna2DataGridView1.Columns[1].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
