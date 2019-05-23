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
    public partial class formMenu : Form
    {
        private bool isLoggedIn;

        public bool IsLoggedIn { get => isLoggedIn; set => isLoggedIn = value; }

        public formMenu()
        {
            InitializeComponent();
            IsLoggedIn = true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.IsLoggedIn = false;
            this.Close();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if(this.IsLoggedIn && e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void BtnStockIn_Click(object sender, EventArgs e)
        {
            invt_stockIn _StockIn = new invt_stockIn();
            _StockIn.Owner = this;
            _StockIn.Show();
            this.Hide();
        }

        private void BtnStockOut_Click(object sender, EventArgs e)
        {
            invt_stockOut _StockOut = new invt_stockOut();
            _StockOut.Owner = this;
            _StockOut.Show();
            this.Hide();
        }

        private void BtnStockReturn_Click(object sender, EventArgs e)
        {
            invt_return _StockReturn = new invt_return();
            _StockReturn.Owner = this;
            _StockReturn.Show();
            this.Hide();
        }

        private void BtnStockAccept_Click(object sender, EventArgs e)
        {
            invt_accept _StockAccept = new invt_accept();
            _StockAccept.Owner = this;
            _StockAccept.Show();
            this.Hide();
        }

        private void BtnStockReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet!!");
        }
    }
}
