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
<<<<<<< HEAD
using DTO;
=======
>>>>>>> a73b1f0a267558ea67d4d8ff0e00d28fb59ff003
using BLL;

namespace GUI
{
    public partial class UCThongTinCaNhan : UserControl
    {
<<<<<<< HEAD
        Account acc = new Account();
        AccountBLL aBLL = new AccountBLL();
        UserInfoBLL userBLL = new UserInfoBLL();
        public UCThongTinCaNhan(Account a)
        {
            InitializeComponent();
            acc = a;
=======
        Account account = new Account();
        public UCThongTinCaNhan(Account acc)
        {
            InitializeComponent();
            account = acc;
            HienThi();
            ChinhSuaTK();
           
        }
        UserInfoBLL userBLL = new UserInfoBLL();
        AccountBLL accountBLL = new AccountBLL();
        public void LuuThongTin()
        {
            UserInfo user = new UserInfo();
            user.UserName = txt_hoten.Text;
            if (rad_nam.Checked == true)
            {
                user.Sex = "Nam";

            }
            if (rad_nu.Checked == true)
            {
                user.Sex = "Nữ";
            }

            user.DateOfBirth = Convert.ToDateTime(dtp_birthday.Text);
            user.Email = txt_email.Text;
            user.Tel = txt_sdt.Text;
            user.AccountID = account.AccountID;
            userBLL.insertUserInfo(user);
            //MessageBox.Show(userBLL.getAccountByAAndP(login.TK, login.MK).ToString());


        }

        public void HienThi()
        {
            UserInfo user = userBLL.getUserByID(account.AccountID);

            txt_hoten.Text = user.UserName;
            txt_sdt.Text = user.Tel;
            txt_email.Text = user.Email;
            dtp_birthday.Value = user.DateOfBirth;
            if (user.Sex == "Nam")
            {
                rad_nam.Enabled.ToString();
            }
            if (user.Sex == "Nữ")
            {
                rad_nu.Enabled.ToString();
            }
            MacDinh();

        }

        public void HienThiTK()
        {
            Account acc = accountBLL.LayDuLieuTK(account.AccountID);
            txt_tendangnhap.Text = acc.UserAccount;
            txt_mkhientai.Text = acc.UserPassword;
        }
        public void MacDinhTK()
        {
            txt_tendangnhap.Enabled = true;
            txt_mkhientai.Enabled = true;
            txt_mkmoi.Enabled = true;
            txt_xacnhanmk.Enabled = true;
        }

        public void CapNhatThongTin()
        {
            UserInfo user = new UserInfo();
            user.UserName = txt_hoten.Text;
            if (rad_nam.Checked == true)
            {
                user.Sex = "Nam";

            }
            if (rad_nu.Checked == true)
            {
                user.Sex = "Nữ";
            }

            user.DateOfBirth = Convert.ToDateTime(dtp_birthday.Text);
            user.Email = txt_email.Text;
            user.Tel = txt_sdt.Text;
            user.AccountID = account.AccountID;
            
            userBLL.updateUserInfo(user, account.AccountID);

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            CapNhatThongTin();
            MessageBox.Show("Lưu thành công");
           
        }

        public void MacDinh()
        {
            txt_hoten.ReadOnly = true;
            txt_email.ReadOnly = true;
            txt_sdt.ReadOnly = true;
        }
        public void ChinhSua()
        {
            txt_hoten.ReadOnly = false;
            txt_email.ReadOnly = false;
            txt_sdt.ReadOnly = false;
        }

        public void ChinhSuaTK()
        {
            txt_tendangnhap.Enabled = false;
            txt_mkhientai.Enabled = false;
            txt_mkmoi.Enabled = false;
            txt_xacnhanmk.Enabled = false;
        }

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            ChinhSua();
          
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            HienThiTK();
            MacDinhTK();
            
        }


        private void btn_luuMK_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.UserAccount = txt_tendangnhap.Text;
            
            
            if(txt_mkmoi.Text == txt_xacnhanmk.Text)
            {
                acc.UserPassword = txt_mkmoi.Text;

            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại ");
            }

            accountBLL.updateAccount(acc, account.AccountID);

            MessageBox.Show("Cập nhật thành công");

        }

        private void label5_Click(object sender, EventArgs e)
        {

>>>>>>> a73b1f0a267558ea67d4d8ff0e00d28fb59ff003
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
