﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Size
    {
        public int SizeID { set; get; }
        public string NameSize { set; get; }
        public int quantity { set; get; }
        public int clothesID { set; get; }

        public Size(int SizeID, string NameSize, int quantity, int clothesID)
        {
            this.SizeID = SizeID;
            this.NameSize = NameSize;
            this.quantity = quantity;
            this.clothesID = clothesID;
        }
        public Size() { }
    }
}
