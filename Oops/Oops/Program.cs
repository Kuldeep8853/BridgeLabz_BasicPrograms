using Oops.Inventory;
using System;
namespace Oops{
    class Program{
        static void Main(){
            Console.WriteLine("Enter the choice......");
            Console.WriteLine("Inventory: Detailss of items");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "Inventory":
                    {
                        InventoryDriver.ReadItem();
                        break;
                    }
            }      
        }
    }
}
