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
    public class SizeBLL
    {
<<<<<<< HEAD
        SizeDAL sDAL = new SizeDAL();
        public int numberOfClothes(int id)
        {
            return sDAL.numberOfClothes(id);    
=======
        public static SizeBLL instance = new SizeBLL();
        public Size getByID(int id)
        {
            return SizeDAL.Instance.getById(id);    
>>>>>>> cc22f0a31e07d3e11714ac6eabf80824cdf7ce41
        }
    }
}
