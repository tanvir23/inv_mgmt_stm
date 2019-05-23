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
    public partial class invt_stockIn : Form
    {
        public invt_stockIn()
        {
            InitializeComponent();
        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int n = dgvStockIn.Rows.Add();
            dgvStockIn.Rows[n].Cells[0].Value = n;
            dgvStockIn.Rows[n].Cells[1].Value = new Random().Next(1000, 1000000);
            dgvStockIn.Rows[n].Cells[2].Value = "Add your comment here...!!";
            dgvStockIn.Rows[n].Cells[3].Value = new Random().Next(5, 100);
            int total = 0;
            for (int i = 0; i <= n; i++)
            {
                total += (int) dgvStockIn.Rows[i].Cells[3].Value;
            }
            txtTotalIn.Text = total.ToString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Stock checked successfully!!");
            this.Owner.Show();
            this.Close();
        }
    }
}
