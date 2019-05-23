using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inv_mgmt_stm
{
    public partial class invt_stockOut : Form
    {
        public invt_stockOut()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Stock checked successfully!!");
            this.Owner.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int n = dgvStockOut.Rows.Add();
            dgvStockOut.Rows[n].Cells[0].Value = n;
            dgvStockOut.Rows[n].Cells[1].Value = new Random().Next(1000, 1000000);
            dgvStockOut.Rows[n].Cells[2].Value = "Add your comment here...!!";
            dgvStockOut.Rows[n].Cells[3].Value = new Random().Next(5, 100);
            int total = 0;
            for (int i = 0; i <= n; i++)
            {
                total += (int)dgvStockOut.Rows[i].Cells[3].Value;
            }
            txtTotalOut.Text = total.ToString();
        }
    }
}
