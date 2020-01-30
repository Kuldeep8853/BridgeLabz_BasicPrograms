// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=Inventory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
namespace Oops.Inventory{
    /// <summary>
    ///Oprations in inventory items
    /// </summary>
    class InventoryDriver
    {
        /// <summary>
        /// Display the inventory items
        /// </summary>
        public static void ReadItem(){
            ////Read the json file.........
            try
            {
               
                    Inventory array = Utility.ReadJsonFile();
                JArray experiencesArrary = (JArray)jObject[array];
                Console.WriteLine("item:");
                    for(int i=0;i<array.Length;i++)
                    { 
                        Console.WriteLine("name =" + array.Name);
                        Console.WriteLine("weight =" + array.Weight);
                        Console.WriteLine("Price =" + array.Price);
                    }

                }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Addition opration in json file
        /// </summary>
        public static void AddItem()
        {
            Inventory item = new Inventory();

            Console.Write("Enter Item name : ");
            item.Name = Console.ReadLine();
            Console.Write("Enter Item price : ");
            item.Price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Item wieght : ");
            item.Weight = Convert.ToInt32(Console.ReadLine());
            try
            {
                ///read the json file....       
                string json = File.ReadAllText(@"D:\Oops\Oops\Inventory\InventoryItems.json");
                List<Inventory> playerList = JsonConvert.DeserializeObject<List<Inventory>>(json);
                playerList.Add(item);

                ////serializa the json file.....
                string jsonItem = JsonConvert.SerializeObject(playerList);
                File.WriteAllText(@"D:\Oops\Oops\Inventory\InventoryItems.json", jsonItem);

            }
            catch (Exception ex)
            {
                ////display the exception message......
                Console.WriteLine("Add Error : " + ex.Message.ToString());
            }
            
        }
        
    }
}