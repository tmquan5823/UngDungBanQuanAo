using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class SizeBLL
    {
        SizeDAL sDAL = new SizeDAL();
        public int numberOfClothes(int id)
        {
            return sDAL.numberOfClothes(id);    
        }
    }
}
