
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Security.Principal;

namespace BLL
{
    public class AccountBLL
    {
        AccountDAL accountDAL = new AccountDAL();
        public string CheckAccount(Account account)
        {
            if(account.UserAccount == "" || account.UserPassword == "")
            {
                return "Vui lòng nhập đầy đủ thông tin!";
            }
            else if (account.UserAccount.Length < 6 || account.UserPassword.Length < 6)
            {
                return "Vui lòng nhập tài khoản và mật khẩu nhiều hơn 6 kí tự!";
            }
            else
            {
                return accountDAL.CheckAccount(account);
            }
        }
        public void AddAccount(Account a)
        {
            accountDAL.AddAccount(a);   
        }

        public Boolean ChangeAccountPassword(Account a, string pass)
        {
            if(pass == "" || pass == a.UserPassword || pass.Length < 6) { return false; }
            else return accountDAL.ChangeAccountPassword(a, pass);
        }

        public Boolean CheckAccountPassword(Account acc)
        {
            if (acc.UserAccount == "" || acc.UserPassword == "")
            {
                return false;
            }
            else
            {
                if (accountDAL.CheckAccountPassword(acc)) { return true; }
                else return false;
            }
        }

        public void updateAccount(Account acc, int id)
        {
            accountDAL.UpdateAccountInfo(acc, id);
        }

        public Account LayDuLieuTK(int id)
        {
            return accountDAL.getAccountById(id);
        }
    }
}
