using CsvHelper;
using DMProject.Admin_Forms;
using DMProject.Models;
using DMProject.Models.Principles;
using DMProject.Models.View_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMProject.Forms
{
    public partial class frmOrders : Form
    {
        int totalRecords = 0;
        int pageNumber = 1;
        int pageSize = 5;
        int totalPages = 0;
        public frmOrders()
        {
            InitializeComponent();
        }
        private void frmOrders_Load(object sender, EventArgs e)
        {
            guna2NumericUpDown1.Value = DMProject.Properties.Settings.Default.pageSizeRoundsAdmin;
            try
            {
                totalRecords = DatabaseCongfigurations.GetRoundView().Count();
                totalPages = (int)Math.Ceiling((double)(totalRecords * 1.0 / pageSize));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            getPagination(pageNumber, pageSize);
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
                    getPagination(pageNumber, pageSize);
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
                getPagination(pageNumber, pageSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void getPagination(int pageNum, int pageSize)
        {
            pageNumber = pageNum;
            List<RoundView> rows = DatabaseCongfigurations.GetRoundView();
            totalPages = (int)Math.Ceiling((double)(rows.Count() * 1.0 / pageSize));
            if (pageNumber > totalPages)
            {
                pageNumber = totalPages;
                getPagination(pageNumber, pageSize);
            }
            rows = rows.Skip((pageNum-1)*pageSize).Take(pageSize).ToList();
            guna2DataGridView1.DataSource = rows;
            txtPageNumber.Text = pageNumber.ToString();
            txtTotalPages.Text = totalPages.ToString();
        }
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            getPagination(1, pageSize);
        }
        private void guna2DataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            if (pageNumber == 1 && totalPages > 1)
            {
                btnLast.Visible = true;
                btnNext.Visible = true;
                btnFirst.Visible = false;
                btnPrev.Visible = false;
            }
            else if (pageNumber <= 0 || totalPages <=1)
            {
                btnLast.Visible = false;
                btnNext.Visible = false;
                btnFirst.Visible = false;
                btnPrev.Visible = false;
            }
            else if(pageNumber == totalPages)
            {
                btnLast.Visible = false;
                btnNext.Visible = false;
                btnFirst.Visible = true;
                btnPrev.Visible = true;
            }
            else
            {
                btnLast.Visible = true;
                btnNext.Visible = true;
                btnFirst.Visible = true;
                btnPrev.Visible = true;
            }
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            getPagination(--pageNumber, pageSize);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            getPagination(++pageNumber, pageSize);
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            getPagination(totalPages, pageSize);
        }
        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pageSize = (int)guna2NumericUpDown1.Value;
            DMProject.Properties.Settings.Default.pageSizeRoundsAdmin = pageSize;
            getPagination(pageNumber, pageSize);
            DMProject.Properties.Settings.Default.Save();
            if (pageNumber > totalPages)
            {
                pageNumber = totalPages;
                getPagination(pageNumber, pageSize);
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No Dta In The Tables");
                return;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = folderBrowserDialog1.SelectedPath + $"\\Rounds-{DateTime.Now.ToString().Replace("/", "_").Replace(":", "_")}.csv";
                    using (var writer = new StreamWriter(path, false, Encoding.UTF8))
                    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        csv.WriteRecords((List<RoundView>)guna2DataGridView1.DataSource);
                    }
                    MessageBox.Show($"File Has Saved In {path}", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
