using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SizeBLL
    {
        public static SizeBLL instance = new SizeBLL();
        public Size getByID(int id)
        {
            return SizeDAL.Instance.getById(id);    
        }
    }
}
