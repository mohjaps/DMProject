using DMProject.Models;
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
        private Random random= new Random();
        private int tempIndex;
        List<int> ints = new List<int>();
        int numOfQuestions;
        //int m = 9, s = 1;
        public HomePlay()
        {
            InitializeComponent();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[tempIndex];
            return ColorTranslator.FromHtml(color);
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
                frmPlay.Tag = new object[2]{ints ,int.Parse(guna2ComboBox1.SelectedValue.ToString())};
                frmPlay.ShowDialog();
                this.Show();
            }
        }
    }
}
