using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12_Fast_Food_order
{
    class Item
    {
        private string ItemCode;
        private string ItemName;
        private double ItemPrice;

        public Item(string ItemCode, string ItemName, double ItemPrice)
        {
            this.ItemCode = ItemCode;
            this.ItemName = ItemName;
            this.ItemPrice = ItemPrice;

        }

        public string GetItemName()
        {
            return ItemName;
        }

        public double GetItemPrice()
        {
            return ItemPrice;
        }

        public string GetItemCode()
        {
            return ItemCode;
        }

    }
}
