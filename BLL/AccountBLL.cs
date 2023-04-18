
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
        public Boolean CheckAccount(Account acc)
        {
            if (acc.UserAccount == "" || acc.UserPassword == "")
            {
                return false;
            }
            else
            {
                if (accountDAL.CheckAccount(acc)) { return true; }
                else return false;
            }
        }
    }
}
