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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            loginAction();
        }

        private void TxtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginAction();
                e.Handled = true;
            }
        }

        private void loginAction()
        {
            string userID = txtUserID.Text;
            string passwd = txtPassword.Text;

            if (userID == "")
            {
                MessageBox.Show("Username can't be empty");
                txtUserID.Focus();
            }
            else if (passwd == "")
            {
                MessageBox.Show("Password can't be empty");
                txtPassword.Focus();
            }
            else if (userID == "adminHQ" && passwd == "123ewq")
            {
                this.Hide();
                formMenu fm = new formMenu();
                fm.Owner = this;
                fm.Show();

            }
            else
            {
                MessageBox.Show("Username or Password is incorrect");
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginAction();
                e.Handled = true;
            }
        }
    }
}
