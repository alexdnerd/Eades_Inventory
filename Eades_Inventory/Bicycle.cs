using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eades_Inventory
{
    class Bicycle : IShippable
    {
		private decimal _cost = 9.50M;
		private string _product = "Bicycles";

		public decimal ShipCost
		{

			get { return _cost; }

		}
		public Bicycle(decimal cost, string product)
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
