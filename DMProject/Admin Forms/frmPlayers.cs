using DMProject.Game_Forms;
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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        private void frmProducts_Load(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView1.DataSource = DatabaseCongfigurations.GetPlayers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerLogin PL = new PlayerLogin();
            PL.Text = "New Player - Admin";
            PL.ShowDialog();
            guna2DataGridView1.DataSource = DatabaseCongfigurations.GetPlayers();
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selected = guna2DataGridView1.SelectedRows;
            if (selected != null && selected.Count == 1)
            {
                PlayerLogin PL = new PlayerLogin();
                PL.Text = "Update Player - Admin";
                PL.Tag = selected[0].Cells["Username"].Value.ToString();
                PL.ShowDialog();
                guna2DataGridView1.DataSource = DatabaseCongfigurations.GetPlayers();
            }
            else
            {
                MessageBox.Show("You Have To Select One Row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selected = guna2DataGridView1.SelectedRows;
            if (selected != null && selected.Count >0)
            {
                DialogResult res = MessageBox.Show("Are Youu Sure To Delete The Selected Players?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    for (int i = 0; i < selected.Count; i++)
                    {
                        try
                        {
                            DatabaseCongfigurations.DeletePlayer(selected[i].Cells["Username"].Value.ToString());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    guna2DataGridView1.DataSource = DatabaseCongfigurations.GetPlayers();
                }
            }
            else
            {
                MessageBox.Show("You Have To Select One Row At Least", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var selected = guna2DataGridView1.SelectedRows;
            if (selected != null && selected.Count > 0)
            {
                DialogResult res = MessageBox.Show("Are Youu Sure To Delete The Rounds For The Selected Players?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    for (int i = 0; i < selected.Count; i++)
                    {
                        try
                        {
                            Player player = DatabaseCongfigurations.GetPlayer(selected[i].Cells["Username"].Value.ToString());
                            DatabaseCongfigurations.DeletePlayerRounds(player.Username);
                            double cnt = DatabaseCongfigurations.RoundsCount(player.Username);
                            double sum = DatabaseCongfigurations.RoundsTotalScore(player.Username);
                            if (cnt > 0) player.Score = (int)(Math.Round(sum / cnt));
                            else player.Score = 0;
                            DatabaseCongfigurations.UpdatePlayer(player);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    guna2DataGridView1.DataSource = DatabaseCongfigurations.GetPlayers();
                }
            }
            else
            {
                MessageBox.Show("You Have To Select One Row At Least", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
