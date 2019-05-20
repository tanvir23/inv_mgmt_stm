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
    }
}
