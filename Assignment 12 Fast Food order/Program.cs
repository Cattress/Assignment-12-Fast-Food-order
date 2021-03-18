using System;
using System.IO;

namespace Assignment_12_Fast_Food_order
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] items;
            items = new Item[100];


            StreamReader FileReader = new StreamReader("food.csv");
            
            string line = FileReader.ReadLine();

            int count = 0;
            while ((line = FileReader.ReadLine()) != null)
            {
                string[] cells = line.Split(",");
                string code = cells[0];
                string name = cells[1];
                string price = cells[2];

                double FullPrice = Convert.ToDouble(price);
                items[count] = new Item(code, name, FullPrice);

                count++;

                Console.WriteLine("{0} {1} {2} {3}",count, code, name, price);
            }

            Payment emlunch = new Payment();

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("0 :: Stop Program");
            Console.WriteLine("1 :: Add an item to the bill");
            Console.WriteLine("2 :: Cakculate your bill");
            Console.WriteLine("3 :: Pay the bill");
            int userSelect = Console.Read();

            if (userSelect == 1)
            {
                Console.WriteLine("What do you want to add?");
                string userInputType = Console.ReadLine();

                if ( userInputType != null && userInputType == "drink" )
                {
                    Console.WriteLine("enter");
                    int userDrink = Console.ReadLine();
                    

                }

       
            }
            else if (userSelect == 2)
            {
                Payment
            }

            
            




        }
    }
}
