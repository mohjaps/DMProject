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

namespace DMProject.Admin_Forms
{
    public partial class frmRoundsDetails : Form
    {
        public frmRoundsDetails()
        {
            InitializeComponent();
        }

        private void frmRoundsDetails_Load(object sender, EventArgs e)
        {
            Round round = (Round)Tag;
            txtId.Text = round.Id.ToString();
            txtUsername.Text = round.PlayerUsername.ToString();
            txtTotalQuestions.Text = round.totalQuestions.ToString();
            txtSelectedTables.Text = round.selectedTables.ToString();
            txtTimeConsumed.Text = round.timeConsumed.ToString();
            txtCorrect.Text = round.correct.ToString();
            txtWrong.Text = round.wrong.ToString();
            txtScore.Text = round.Score.ToString();
            txtDateTime.Text = round.RoundDateTime.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                ;
                Round round = DatabaseCongfigurations.GetRound(int.Parse(txtId.Text));
                Player player = DatabaseCongfigurations.GetPlayer(round.PlayerUsername);

                DatabaseCongfigurations.DeleteRound(round.Id);

                double cnt = DatabaseCongfigurations.RoundsCount(player.Username);
                double sum = DatabaseCongfigurations.RoundsTotalScore(player.Username);
                if (cnt > 0) player.Score = (int)(Math.Round(sum / cnt));
                else player.Score = 0;
                DatabaseCongfigurations.UpdatePlayer(player);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
