using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ClothesBLL
    {
        ClothesDAL cDAL = new ClothesDAL();
        public List<Clothes> getList()
        {
            return cDAL.getList();
        }
    }
}
