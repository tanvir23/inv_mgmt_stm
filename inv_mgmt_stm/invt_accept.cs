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
    public partial class invt_accept : Form
    {
        public invt_accept()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Report submitted successfully!!");
            this.Owner.Show();
            this.Close();
        }
    }
}
