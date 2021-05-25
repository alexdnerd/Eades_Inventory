using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eades_Inventory
{
    class Lawn_Mower : IShippable
    {
		private decimal _cost = 24.00M;
		private string _product = "Lawn Mowers";

		public decimal ShipCost
		{

			get { return _cost; }

		}
		public Lawn_Mower(decimal cost, string product)
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
