using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    class ShippingService 
    {
        private double Price;

        public ShippingService()
        {
            this.Price = 10;
        }

        public double CalculatePrice(IShipable item)
        {
            return item.Weight * this.Price;
        }

    }
}
