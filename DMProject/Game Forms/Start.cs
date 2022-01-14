using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace DMProject.Game_Forms
{
    public partial class Start : Form
    {
        WindowsMediaPlayer MP = new WindowsMediaPlayer();
        public Start()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MP.controls.stop();
            new Login().ShowDialog();
            this.Show();
            MP.controls.play();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PlayerLogin().ShowDialog();
            this.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            MP.URL = "Sounds/startGame.mp3";
            MP.controls.play();
        }
    }
}
