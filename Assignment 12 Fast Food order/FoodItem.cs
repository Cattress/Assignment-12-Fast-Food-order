using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12_Fast_Food_order
{
    class FoodItem
    {
        private string FoodCode;
        private int FoodQuantity;

        public FoodItem(string FoodCode, int FoodQuantity)
        {
            this.FoodCode = FoodCode;
            this.FoodQuantity = FoodQuantity;
        }

        public string GetFoodcode()
        {
            return FoodCode;
        }

        public int GetFoodQuantity()
        {
            return FoodQuantity;
        }
    }
}
