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
        public static UserInfoBLL instance = new UserInfoBLL();
        public UserInfo getUserByID(int ID)
        {
            return UserInfoDAL.getInstance.getById(ID);
        }
    }
}
