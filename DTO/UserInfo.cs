﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserInfo
    {
        public int UserID { set; get; }
        public string Tel { set; get; }
        public string Email { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string Sex { set; get; }
        public string UserName { set; get; }
        public int AccountID { set; get; }
        public string Address { set; get; }
        public UserInfo(int UserID, string Tel, string Email, DateTime DateOfBirth, string Sex, string UserName, int accountID, string address)
        {
            this.UserID = UserID;
            this.Tel = Tel;
            this.Email = Email;
            this.DateOfBirth = DateOfBirth;
            this.Sex = Sex;
            this.UserName = UserName;
            AccountID = accountID;
            Address = address;
        }
        public UserInfo() { }
    }
}
