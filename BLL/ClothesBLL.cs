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
    public class ClothesBLL
    {
        ClothesDAL cDAL = new ClothesDAL();
        public List<Clothes> getList()
        {
            return cDAL.getList();
        }
        public static ClothesBLL instance = new ClothesBLL();
        public Clothes getClothesByID(int ID)
        {
            return ClothesDAL.instance.getById(ID);
        }
        public Clothes getClothesByName(string Name)
        {
            return ClothesDAL.instance.getByName(Name);
        }
        public List<Clothes> getListByValue(String Value)
        {
            return cDAL.getListByValue(Value);
        }
        public void deleteClothesByID(int ID)
        {
            ClothesDAL.instance.RemoveClothes(ID);
        }
        public Boolean checkInputID(int ID)
        {
            return ClothesDAL.instance.checkInputID(ID);
        }
        public void UpdateClothes(Clothes clo)
        {
            ClothesDAL.instance.UpdateUserInfo(clo);
        }
    }
}