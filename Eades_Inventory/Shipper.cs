using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eades_Inventory
{
    class Shipper
    {
        //private IShippable _shippable;

        public int bicycleCounter;
        public int lawnmowerCounter;
        public int baseballgloveCounter;
        public int crackersCounter;


        public IShippable Add(string product)
        {
            if(product=="Bicycle")
            {
                bicycleCounter++;
            }
            else if (product == "Lawn Mowers")
            {
                lawnmowerCounter++;
            }
            else if (product == "Baseball Gloves")
            {
                baseballgloveCounter++;
            }
            else if (product == "Crackers")
            {
                crackersCounter++;
            }

        }

        string[] Ship = new string[10];






    }
}
