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
using BLL;

namespace GUI
{
    public partial class UCThongTinCaNhan : UserControl
    {
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

        }

        
    }
}
