using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClothesBLL
    {
        public static ClothesBLL instance = new ClothesBLL();
        public Clothes getClothesByID(int ID)
        {
            return ClothesDAL.instance.getById(ID);
        }
    }
}
