using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12_Fast_Food_order
{
    class Payment
    {

        private DrinkItem[] drinkItems;
        private FoodItem[] foodItems;
        private int fCount = 0;
        private int dCount = 0;

        public Payment( int fCount, int dCount)
        {
            drinkItems = new DrinkItem[100];
            foodItems = new FoodItem[100];
            this.fCount = fCount;
            this.dCount = dCount;
        }

        public double FindPrice(Item[] pl , string code)
        {
            int i = 0;


            for(i=0; i < pl.Length; i++)
            {
                if (code != null && pl[i].GetItemCode() == code)
                {
                    return pl[i].GetItemPrice();
                }
            }
            return 0;
        }

        public double CalculateBill(Item[] pl)
        {
            int i = 0;
            double billTotal = 0;

            for(i=0; i < foodItems.Length; i++)
            {
                if (foodItems[i] != null)
                {
                    string code = foodItems[i].GetFoodcode();
                    double price = FindPrice(pl, code);
                    int quantity = foodItems[i].GetFoodQuantity();

                    double foodTotal = price * quantity;
                    billTotal = billTotal + foodTotal;
                }
            }

            for (i = 0; i < drinkItems.Length; i++)
            {
                if (drinkItems[i] != null)
                {
                    string code = drinkItems[i].GetDrinkcode();
                    double price = FindPrice(pl, code);
                    int quantity = drinkItems[i].GetDrinkQuantity();

                    double drinkTotal = price * quantity;
                    billTotal = billTotal + drinkTotal;
                }
            }
            return billTotal;
        }


    }
}
