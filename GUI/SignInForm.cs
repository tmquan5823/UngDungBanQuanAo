using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SignInForm : Form
    {
        AccountBLL aBLL = new AccountBLL();
        public SignInForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            this.Dispose();
            frm.ShowDialog();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.UserAccount = txt_username.Text;
            if(txt_password.Text == txt_confirmPass.Text) {
                acc.UserPassword = txt_password.Text;
                string status = aBLL.CheckAccount(acc);
                if (status == "Đăng kí thành công!")
                {
                    aBLL.AddAccount(acc);
                    MessageBox.Show(status);
                    this.Hide();
                    FormLogin frm = new FormLogin();
                    frm.Show();
                    return;
                }
                MessageBox.Show(status);
            }
            else
            {
                MessageBox.Show("Mật khẩu nhập vào không khớp!");
            }
        }
    }
}
