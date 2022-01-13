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
    }
}
