using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eades_Inventory
{
    class Baseball_Glove : IShippable
    {
		private decimal _cost = 3.23M;
		private string _product = "Baseball Gloves";

		public decimal ShipCost
		{

			get { return _cost; }

		}
		public Baseball_Glove(decimal cost, string product)
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
