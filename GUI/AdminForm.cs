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
    public partial class AdminForm : Form
    {
        Account account = new Account();    
        public AdminForm(Account acc)
        {
            InitializeComponent();
            account = acc;  
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            if(panel_admin.Visible == false )
            {
                panel_admin.Visible = true;
            }
            else { panel_admin.Visible = false; }
        }
        private void addUserControl(UserControl uc)
        {
            if (panel_main.Controls.Count > 0)
            {
                panel_main.Controls.Clear();
            }
            panel_main.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btn_QuanLySanPham_Click(object sender, EventArgs e)
        {
            UCQuanLySanPham uc = new UCQuanLySanPham();
            addUserControl(uc);
            lbl_info.Text = "Quản lý sản phẩm";
        }

        private void btn_QuanLyDonHang_Click(object sender, EventArgs e)
        {
            UCQuanLyDonHang uc = new  UCQuanLyDonHang();
            addUserControl(uc);
            lbl_info.Text = "Quản lý đơn hàng";
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin();
        }
    }
}
