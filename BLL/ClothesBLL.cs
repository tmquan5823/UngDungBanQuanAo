<<<<<<< HEAD
﻿using System;
=======
﻿using DAL;
using DTO;
using System;
>>>>>>> cc22f0a31e07d3e11714ac6eabf80824cdf7ce41
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using DTO;
using DAL;
=======
>>>>>>> cc22f0a31e07d3e11714ac6eabf80824cdf7ce41

namespace BLL
{
    public class ClothesBLL
    {
<<<<<<< HEAD
        ClothesDAL cDAL = new ClothesDAL();
        public List<Clothes> getList()
        {
            return cDAL.getList();
=======
        public static ClothesBLL instance = new ClothesBLL();
        public Clothes getClothesByID(int ID)
        {
            return ClothesDAL.instance.getById(ID);
>>>>>>> cc22f0a31e07d3e11714ac6eabf80824cdf7ce41
        }
    }
}
