using DMProject.Admin_Forms;
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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = DatabaseCongfigurations.GetRoundView();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selected = guna2DataGridView1.SelectedRows;
            if (selected != null && selected.Count > 0)
            {
                DialogResult res = MessageBox.Show("Are Youu Sure To Delete The Selected Rounds?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    for (int i = 0; i < selected.Count; i++)
                    {
                        try
                        {
                            Round round = DatabaseCongfigurations.GetRound(int.Parse(selected[i].Cells["Id"].Value.ToString()));
                            Player player = DatabaseCongfigurations.GetPlayer(round.PlayerUsername);

                            DatabaseCongfigurations.DeleteRound(round.Id);

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
                    guna2DataGridView1.DataSource = DatabaseCongfigurations.GetRoundView();
                }
            }
            else
            {
                MessageBox.Show("You Have To Select One Row At Least", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = guna2DataGridView1.SelectedRows;
                if (selected.Count != 1)
                {
                    MessageBox.Show("You Have To Select One Row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Round round = DatabaseCongfigurations.GetRound(int.Parse(selected[0].Cells["Id"].Value.ToString()));
                frmRoundsDetails RD = new frmRoundsDetails();
                RD.Tag = round;
                RD.ShowDialog();
                guna2DataGridView1.DataSource = DatabaseCongfigurations.GetRoundView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
