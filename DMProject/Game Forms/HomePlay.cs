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
        List<int> ints = new List<int>();
        int numOfQuestions;
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
                btn.BackColor = Color.CadetBlue;
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderColor = Color.Black;
            }
            else
            {
                btn.FlatStyle = FlatStyle.Standard;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.White;
                btn.ForeColor = Color.CadetBlue;
                btn.FlatAppearance.BorderColor = Color.White;
            }
            
            for (int i = 0; i < this.Controls.Count; i++)
            {
                var btns = this.Controls[i];
                if (btns is Button && !btns.Name.Contains("btnGo") && ((Button)btns).FlatStyle == FlatStyle.Flat)
                    ints.Add(int.Parse(btns.Text));
            }
            List<int> questionNums = new List<int>() { 0};
            numOfQuestions = ints.Count() * 11 * 2;
            for (int j = 0; j < numOfQuestions; j++)
                questionNums.Add(j+1);
            guna2ComboBox1.DataSource = questionNums;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (ints.Count() <= 0)
            {
                MessageBox.Show("Select One Table At Least", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (guna2ComboBox1.SelectedValue.ToString() == "0")
            {
                guna2ComboBox1.Focus();
                MessageBox.Show("Select The Number Of Questions At Least", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            frmPlay frmPlay = new frmPlay();
            // Tag => Selected Tables , Questions Count, Player Username
            frmPlay.Tag = new object[3] { ints, int.Parse(guna2ComboBox1.SelectedValue.ToString()), player.Username };
            frmPlay.ShowDialog();
            this.Show();

            // Reste The Previous Settings For Buttons Colors
            foreach (Control btn in Controls)
            {
                if (btn is Button && btn.Name.Contains("btnQuestion"))
                {
                    Button btn2 = (Button)btn;
                    btn2.FlatStyle = FlatStyle.Standard;
                    btn2.FlatAppearance.BorderSize = 0;
                    btn2.BackColor = Color.White;
                    btn2.ForeColor = Color.CadetBlue;
                    btn2.FlatAppearance.BorderColor = Color.White;
                }
            }
            guna2ComboBox1.DataSource = new List<int> { 0};
            ints = new List<int>();

            try
            {
                player = DatabaseCongfigurations.GetPlayer(Tag.ToString());
                lblScore.Text = $"Total Score: {player.Score}";
                lblTotalRounds.Text = $"Total Rounds: {DatabaseCongfigurations.RoundsCount(player.Username)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        private void HomePlay_Load(object sender, EventArgs e)
        {
            guna2ComboBox1.DataSource = new List<int> { 0 };
            try
            {
                player = DatabaseCongfigurations.GetPlayer(Tag.ToString());
                lblHello.Text = $"Hello {player.Name}!";
                lblScore.Text = $"Total Score: {player.Score}";
                lblTotalRounds.Text = $"Total Rounds: {DatabaseCongfigurations.RoundsCount(player.Username)}";
                lblLastLogin.Text = $"Last Login At {player.LastLogin}";
                player.LastLogin = DateTime.Now;
                DatabaseCongfigurations.UpdatePlayer(player);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}