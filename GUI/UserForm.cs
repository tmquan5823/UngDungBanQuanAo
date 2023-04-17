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
    public partial class UserForm : Form
    {
        Account account = new Account();
        public UserForm(Account acc)
        {
            InitializeComponent();
            account = acc;  
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            if(panel_user.Visible == false) { panel_user.Visible = true;}
            else { panel_user.Visible = false;}
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

        private void btn_TTCaNhan_Click(object sender, EventArgs e)
        {
            UCThongTinCaNhan uc = new UCThongTinCaNhan();
            addUserControl(uc);
            lbl_info.Text = "Thông tin cá nhân";
        }

        private void btn_QuanLySanPham_Click(object sender, EventArgs e)
        {
            UCTrangChu uc = new UCTrangChu();
            addUserControl(uc);
            lbl_info.Text = "Trang chủ";
        }

        private void btn_QuanLyDonHang_Click(object sender, EventArgs e)
        {
            UCDonHang uc = new UCDonHang();
            addUserControl(uc);
            lbl_info.Text = "Đơn hàng";
        }
    }
}
