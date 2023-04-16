using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public int AccountID { set; get; }
        public string UserAccount { set; get; }
        public string UserPassword { set; get; }
        public string UserRole { set; get; }
        public Account(int accountID, string userAccount, string userPassword)
        {
            AccountID = accountID;
            UserAccount = userAccount;
            UserPassword = userPassword;
        }
        public Account() { }
    }
}
