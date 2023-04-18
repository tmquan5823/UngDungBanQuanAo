
using System;
using DAL;
using DTO;
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
        public static SizeBLL instance = new SizeBLL();
        public SizeClothes getByID(int id)
        {
            return SizeDAL.Instance.getById(id);
        }
        public SizeClothes getSizeByNameAndClothesID(string Size, int ClothesID) 
        {
            return SizeDAL.Instance.getNumberBySizeAndClothesID(Size, ClothesID);
        }
        public void UpdateNumberOfSize(string Size, int CloID, int quantity)
        {
            SizeDAL.Instance.updateNumberOfSize(Size, CloID, quantity);
        }
    }
}