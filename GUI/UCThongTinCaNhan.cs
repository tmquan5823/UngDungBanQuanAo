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
    public partial class UCThongTinCaNhan : UserControl
    {
        Account acc = new Account();
        AccountBLL aBLL = new AccountBLL();
        UserInfoBLL userBLL = new UserInfoBLL();
        public UCThongTinCaNhan(Account a)
        {
            InitializeComponent();
            acc = a;
        }


        public void HienThiThongTin()
        {
            if (userBLL.CheckNewAccount(acc.AccountID)){
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                {
                    btn_chinhsua.Visible = btn_doimk.Visible = true;
                    btn_luu.Visible = false;
                }
                UserInfo userInfo = userBLL.getByAccountId(acc.AccountID);
                txt_hoten.Text = userInfo.UserName;
                dtp_birthday.Value = userInfo.DateOfBirth;
                txt_sdt.Text = userInfo.Tel;
                txt_email.Text = userInfo.Email;
                txt_diachi.Text = userInfo.Address;
                if(userInfo.Sex == "Nam")
                {
                    rad_nam.Checked = true;
                }
                else rad_nu.Checked = true;
                txt_tendangnhap.Text = acc.UserAccount;
            }
        }
        private void UCThongTinCaNhan_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            UserInfo ui = new UserInfo();
            ui.UserName = txt_hoten.Text;
            ui.Tel = txt_sdt.Text;
            ui.Email = txt_email.Text;
            ui.Address = txt_diachi.Text;
            ui.DateOfBirth = dtp_birthday.Value;
            if (rad_nam.Checked)
            {
                ui.Sex = "Nam";
            }
            else if (rad_nu.Checked)
            {
                ui.Sex = "Nữ";
            }
            else ui.Sex = "";
            ui.AccountID = acc.AccountID;
            if (userBLL.CheckNewAccount(acc.AccountID))
            {
                groupBox1.Enabled = true;
                if (userBLL.addUserInfo(ui))
                {
                    MessageBox.Show("Cập nhật thông tin thành công!");
                    btn_chinhsua.Visible = true;
                    btn_luu.Visible = false;
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thất bại!");
                }
            }
            else
            {
                if (userBLL.UpdateUserInfo(ui))
                {
                    MessageBox.Show("Cập nhật thông tin thành công!");
                    btn_chinhsua.Visible = true;
                    btn_luu.Visible = false;
                    groupBox1.Enabled = false;
                }
                else MessageBox.Show("Cập nhật thông tin thất bại!");
            }
        }

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btn_chinhsua.Visible = false;
            btn_luu.Visible = true;
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            btn_luuMK.Visible = btn_huy.Visible = true;
            btn_doimk.Visible = false;
        }

        private void btn_luuMK_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.UserAccount = txt_tendangnhap.Text;
            a.UserPassword = txt_mkhientai.Text;
            if (aBLL.CheckAccountPassword(a))
            {
                if(txt_mkmoi.Text == txt_xacnhanmk.Text)
                {
                    if(aBLL.ChangeAccountPassword(a, txt_mkmoi.Text))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        btn_luuMK.Visible = btn_huy.Visible = false;
                        btn_doimk.Visible = true;
                        txt_mkhientai.Text = txt_mkmoi.Text = txt_xacnhanmk.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại! \n (Vui lòng nhật mật khẩu mới lớn hơn 6 kí tự)");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu xác nhận không trùng khớp!");
                    txt_mkmoi.Text = "";
                    txt_xacnhanmk.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại không chính xác!");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            btn_luuMK.Visible = btn_huy.Visible = false;
            btn_doimk.Visible = true;
        }
    }
}
