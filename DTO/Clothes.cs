using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Clothes
    {
        public int clothesID { get; set; }
        public string clothesName { get; set; }
        public int price { get; set; }
        public string origin { set; get; }

        public string color { set; get; }
        public string clothesDescription { set; get; }

        public Clothes(int clothesID, string clothesName, int price, string origin, string color, string clothesDescription)
        {
            this.clothesID = clothesID;
            this.clothesName = clothesName;
            this.price = price;
            this.origin = origin;
            this.color = color;
            this.clothesDescription = clothesDescription;
        }
        public Clothes() { }
    }
}
