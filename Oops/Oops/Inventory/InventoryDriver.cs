using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace Oops.Inventory
{
    class InventoryDriver
    {
        public static void ReadItem()
        {
            var json = File.ReadAllText(@"D:\Oops\Oops\Inventory\InventoryItems.json");
            try
            {
                var jObject = JObject.Parse(json);

                if (jObject != null)
                {
                    JArray itemArrary = (JArray)jObject["item"];
                    if (itemArrary != null)
                    {
                        foreach (var item in itemArrary)
                        {
                            Console.WriteLine("Item Name :" + item["Name"].ToString());
                            Console.WriteLine("Item price :" + item["Price"].ToString());
                            Console.WriteLine("Item Weight :" + item["Weight"].ToString());
                            Console.WriteLine("---------------------------------");
                        }

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
       /* public static void AddItem()
        {
            Console.WriteLine("Enter Item name : ");
            var Name = Console.ReadLine();
            Console.WriteLine("Enter Item price : ");
            var price = Console.ReadLine();
            Console.WriteLine("Enter Item wieght : ");
            var wieght = Console.ReadLine();

            var newItem = "{ 'Name': " + Name + ",  
    'Price': " + price + "    ,'Weight':" + wieght " }";  
          }
       */ 
    }
}