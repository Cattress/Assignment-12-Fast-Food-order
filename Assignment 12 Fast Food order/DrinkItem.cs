using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12_Fast_Food_order
{
    class DrinkItem
    {
        private string DrinkCode;
        private int DrinkQuantity;

        public DrinkItem(string DrinkCode, int DrinkQuantity)
        {
            this.DrinkCode = DrinkCode;
            this.DrinkQuantity = DrinkQuantity;
        }
        public string GetDrinkcode()
        {
            return DrinkCode;
        }

        public int GetDrinkQuantity()
        {
            return DrinkQuantity;
        }
    }
}
