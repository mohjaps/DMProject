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
        //private System.Timers.Timer t = new System.Timers.Timer();
        private int tempIndex;
        //int m = 9, s = 1;
        public HomePlay()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Buttons Coloring. 
            //for (int i = 0; i < this.Controls.Count; i++)
            //{
            //    var btn = this.Controls[i];
            //    if (btn is Button && !btn.Name.Contains("btnGo"))
            //        btn.BackColor = SelectThemeColor();
            //}
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


            //string btnNumber = ((Button)sender).Text; // Gets The Text Of The Clicked Button.  
            //this.Hide();
            //frmPlay frmPlay = new frmPlay();
            //frmPlay.Tag = btnNumber;
            //frmPlay.ShowDialog();
            //this.Show();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            List<int> ints = new List<int>();
            for (int i = 0; i < this.Controls.Count; i++)
            {
                var btn = this.Controls[i];
                if (btn is Button && !btn.Name.Contains("btnGo") && ((Button)btn).FlatStyle == FlatStyle.Flat)
                    ints.Add(int.Parse(btn.Text));
            }
            if (ints.Count() > 0)
            {
                this.Hide();
                frmPlay frmPlay = new frmPlay();
                frmPlay.Tag = ints;
                frmPlay.ShowDialog();
                this.Show();
            }
        }
    }
}
