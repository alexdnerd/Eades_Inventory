using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eades_Inventory
{
    class Crackers : IShippable
    {
		private decimal _cost = 0.57M;
		private string _product = "Crackers";

		public decimal ShipCost
		{
			
			get { return _cost; }

		}
		public Crackers(decimal cost, string product)
        {
			cost = _cost;
			product = _product;

		}
		
			
		
		public string Product
		{

			get { return _product; }

		}
		
	}
}
