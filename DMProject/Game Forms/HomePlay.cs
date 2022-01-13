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
using System.Timers;
using System.Windows.Forms;

namespace DMProject.Game_Forms
{
    public partial class HomePlay : Form
    {
        Player player = new Player();
        private Random random= new Random();
        private int tempIndex;
        List<int> ints = new List<int>();
        int numOfQuestions;
        //int m = 9, s = 1;
        public HomePlay()
        {
            InitializeComponent();
        }

        private void btnQuestion9_Click(object sender, EventArgs e)
        {
            Button btn = ((Button)sender); // Gets The Clicked Button.  
            ints = new List<int>();


            if (btn.FlatStyle == FlatStyle.Standard)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 3;
                btn.FlatAppearance.BorderColor = Color.CadetBlue;
            }
            else
            {
                btn.FlatStyle = FlatStyle.Standard;
                btn.FlatAppearance.BorderSize = 0;
            }
            
            for (int i = 0; i < this.Controls.Count; i++)
            {
                var btns = this.Controls[i];
                if (btns is Button && !btns.Name.Contains("btnGo") && ((Button)btns).FlatStyle == FlatStyle.Flat)
                    ints.Add(int.Parse(btns.Text));
            }
            List<int> questionNums = new List<int>();
            numOfQuestions = ints.Count() * 11 * 2;
            for (int j = 0; j < numOfQuestions; j++)
                questionNums.Add(j+1);
            guna2ComboBox1.DataSource = questionNums;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (ints.Count() > 0 && guna2ComboBox1.SelectedValue.ToString().Length > 0)
            {
                this.Hide();
                frmPlay frmPlay = new frmPlay();
                frmPlay.Tag = new object[3]{ints ,int.Parse(guna2ComboBox1.SelectedValue.ToString()), player.Username};
                frmPlay.ShowDialog();
                this.Show();
                player = DatabaseCongfigurations.GetPlayer(Tag.ToString());
                lblScore.Text = $"Total Score: {player.Score}";
                lblTotalRounds.Text = $"Total Rounds: {DatabaseCongfigurations.RoundsCount(player.Username)}";

            }
        }

        private void HomePlay_Load(object sender, EventArgs e)
        {
            player = DatabaseCongfigurations.GetPlayer(Tag.ToString());
            lblHello.Text = $"Hello {player.Name}!";
            lblScore.Text = $"Total Score: {player.Score}";
            lblTotalRounds.Text = $"Total Rounds: {DatabaseCongfigurations.RoundsCount(player.Username)}";
            lblLastLogin.Text = $"Last Login At {player.LastLogin}";
            player.LastLogin = DateTime.Now;
            DatabaseCongfigurations.UpdatePlayer(player);
        }
    }
}
