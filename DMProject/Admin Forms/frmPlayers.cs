using DMProject.Game_Forms;
using DMProject.Models;
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
            guna2DataGridView1.Invalidate();
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
                guna2DataGridView1.Invalidate();
            }
            else
            {
                MessageBox.Show("You Have To Select One Row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
