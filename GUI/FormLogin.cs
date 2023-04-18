using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class FormLogin : Form
    {
        AccountBLL aBLL = new AccountBLL();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            SignInForm frm = new SignInForm();
            this.Hide();
            frm.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.UserAccount = txt_username.Text;
            account.UserPassword = txt_password.Text;
            if (aBLL.CheckAccountPassword(account))
            {
                if (account.UserRole == "Admin")
                {
                    AdminForm frm = new AdminForm(account);
                    this.Hide();
                    frm.ShowDialog();
                }
                if (account.UserRole == "Customer")
                {
                    UserForm frm = new UserForm(account);
                    this.Hide();
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!");
            }
        }
    }
}
