
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserInfoBLL
    {
        UserInfoDAL uDAL = new UserInfoDAL();
        public static UserInfoBLL instance = new UserInfoBLL();
        public UserInfo getUserByID(int ID)
        {
            return UserInfoDAL.getInstance.getById(ID);
        }

        public UserInfo getByAccountId(int ID)
        {
            return uDAL.getByAccountId(ID);
        }

        public Boolean addUserInfo(UserInfo userInfo)
        {
            if(userInfo.UserName == "" || userInfo.Tel == "" || userInfo.Email == "" || userInfo.Sex == "" || userInfo.Address == "")
            {
                return false;
            }
            return uDAL.addUserInfo(userInfo);
        }

        public Boolean UpdateUserInfo(UserInfo userInfo)
        {
            if (userInfo.UserName == "" || userInfo.Tel == "" || userInfo.Email == "" || userInfo.Sex == "" || userInfo.Address == "")
            {
                return false;
            }
            return uDAL.UpdateUserInfo(userInfo);
        }

        public Boolean CheckNewAccount(int accID)
        {
            return uDAL.CheckNewAccount(accID);
        }
        public void insertUserInfo(UserInfo user)
        {
            UserInfoDAL.getInstance.AddUserInfo(user);
        }
    }
}
