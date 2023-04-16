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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_username.Text == "admin")
            {
                AdminForm frm = new AdminForm();
                this.Hide();
                frm.ShowDialog();
            }
            if(txt_username.Text == "user")
            {
                UserForm frm = new UserForm();
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            SignInForm frm = new SignInForm();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
