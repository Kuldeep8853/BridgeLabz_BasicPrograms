//// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//// <copyright file=Inventory.cs" company="Bridgelabz">
////   Copyright © 2019 Company="BridgeLabz"
//// </copyright>
//// <creator name="Kuldeep Kasaudhan"/>
//// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Oops.Inventory{
    /// <summary>
    ///Oprations in inventory items
    /// </summary>
    class InventoryDriver
    {
        private const string Path = @"D:\Oops\Oops\Inventory\InventoryItems.json";
        /// <summary>
        /// Display the inventory items
        /// </summary>
        public static void ReadItem(){
            ////Read the json file.........
            string json = File.ReadAllText(Path);
            try
            {
                ////parse the json file in json object
                var jObject = JObject.Parse(json);

                if (jObject != null)
                {
                    Console.WriteLine("Enter the choice and Display the item details..: ");
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Rice: Displey rice details... ");
                    Console.WriteLine("Pulse: Displey Pulse details... ");
                    Console.WriteLine("Wheat: Displey Wheat details... ");
                    string choice = Console.ReadLine();
                    switch (choice) {
                        ////Rice details......
                      case "Rice":
                         {
                           JArray RiceArrary = (JArray)jObject["Rice"];
                             if (RiceArrary != null)
                             {
                                Console.WriteLine("--------------------");
                                foreach (var item in RiceArrary)
                                {
                                        Console.WriteLine("Name :  " + item["Name"]);
                                        Console.WriteLine("Price :  " + item["Price"].ToString());
                                        Console.WriteLine("weight :  " + item["Weight"].ToString());
                                        Console.WriteLine("--------------------");
                                }

                             }
                            break;
                         }
                            //// pulses details........
                      case "Pulse":
                            {
                                JArray PulseArrary = (JArray)jObject["Pulses"];
                                if (PulseArrary != null)
                                {
                                    Console.WriteLine("--------------------");
                                    foreach (var item in PulseArrary)
                                    {
                                        Console.WriteLine("Name :  " + item["Name"]);
                                        Console.WriteLine("Price :  " + item["Price"].ToString());
                                        Console.WriteLine("weight :  " + item["Weight"].ToString());
                                        Console.WriteLine("--------------------");
                                    }

                                }
                                break;
                            }
                            //// Wheats details......
                        case "Wheat":
                            {
                                JArray WheatArrary = (JArray)jObject["Wheats"];
                                if (WheatArrary != null)
                                {
                                    Console.WriteLine("--------------------");
                                    foreach (var item in WheatArrary)
                                    {
                                        Console.WriteLine("Name :  " + item["Name"]);
                                        Console.WriteLine("Price :  " + item["Price"].ToString());
                                        Console.WriteLine("weight :  " + item["Weight"].ToString());
                                        Console.WriteLine("--------------------");
                                    }

                                }
                                break;
                            }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
       /// <summary>
       /// Add item method
       /// </summary>
        public static void AddItem()
        {
            Console.WriteLine("enter the choice and add the item...");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Rice. Add the rice item");
            Console.WriteLine("Pulse. Add the rice item");
            Console.WriteLine("Wheat. Add the rice item");
            string json = File.ReadAllText(Path);
            var jObject = JObject.Parse(json);
            string choice = Console.ReadLine();
            switch (choice) {
                /////Add rice item........
                case "Rice":
                    {
                        Console.Write("Enter the rice name : ");
                        string name = Console.ReadLine();
                        Console.Write("Enter rice price : ");
                        string price = Console.ReadLine();
                        Console.Write("Enter rice weight : ");
                        string weight = Console.ReadLine();
                        try
                        {
                            
                            JArray RiceArrary = (JArray)jObject["Rice"];
                            JObject list1 = new JObject
                            {
                                { "Name", name },
                                { "Price", price },
                                { "Weight", weight }
                            };
                            RiceArrary.Add(list1);
                            break;
                        }
                        catch (Exception ex)
                        {
                            ////display the exception message......
                            Console.WriteLine("Add Error : " + ex.Message.ToString());
                        }
                        break;
                    }
                    //// add Pulse item......
                case "Pulse":
                    {
                        Console.Write("Enter the pulse name : ");
                        string name = Console.ReadLine();
                        Console.Write("Enter pulse price : ");
                        string price = Console.ReadLine();
                        Console.Write("Enter pulse weight : ");
                        string weight = Console.ReadLine();
                        try
                        {
                           
                            JArray PulseArrary = (JArray)jObject["Pulses"];
                            JObject list1 = new JObject
                            {
                                { "Name", name },
                                { "Price", price },
                                { "Weight", weight }
                            };
                            PulseArrary.Add(list1);
                           
                            break;
                        }
                        catch (Exception ex)
                        {
                            ////display the exception message......
                            Console.WriteLine("Add Error : " + ex.Message.ToString());
                        }
                        break;
                    }
                    ////Add wheat item........
                case "Wheat":
                    {
                        Console.Write("Enter the Wheat name : ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Wheat price : ");
                        string price = Console.ReadLine();
                        Console.Write("Enter Wheat weight : ");
                        string weight = Console.ReadLine();
                        try
                        {
                          
                            JArray WheatArrary = (JArray)jObject["Wheats"];
                            JObject list1 = new JObject
                            { 
                                 "Name", name ,
                                 "Price", price ,
                                 "Weight", weight
                            };
                            WheatArrary.Add(list1);
                           
                            break;
                        }
                        catch (Exception ex)
                        {
                            ////display the exception message......
                            Console.WriteLine("Add Error : " + ex.Message.ToString());
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter the right choice");
                        break;
                    }
                    
            }
            var jsonToOutput3 = JsonConvert.SerializeObject(jObject, Formatting.Indented);
            File.WriteAllText(Path, jsonToOutput3);
        }
        /// <summary>
        /// update the particular items.....
        /// </summary>
        public static void UpdateItem()
        {
            Console.WriteLine("enter the choice and Update the item...");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Rice. Update the rice item");
            Console.WriteLine("Pulse. Update the rice item");
            Console.WriteLine("Wheat. Update the rice item");
            string choice = Console.ReadLine();
            switch (choice)
            {
                /////Add rice item........
                case "Rice":
                    {
                        string json = File.ReadAllText(Path);
                        try
                        {
                            var jObject = JObject.Parse(json);
                            JArray RiceArrary = (JArray)jObject["Rice"];
                            Console.Write("Enter rice price : ");
                            int price = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter rice weight : ");
                            int weight = Convert.ToInt32(Console.ReadLine());
                            if (price > 0 && weight > 0)
                            {
                                Console.Write("Enter the rice name : ");
                                var name = Convert.ToString(Console.ReadLine());

                                foreach (var item in RiceArrary)
                                {
                                    item["name"] = !string.IsNullOrEmpty(name) ? name : "";
                                }

                                jObject["Rice"] = RiceArrary;
                                string output = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                                File.WriteAllText(Path, output);
                            }
                            else
                            {
                                Console.Write("Invalid Item price and weight, Try Again!");
                                UpdateItem();
                            }
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine("Update Error : " + ex.Message.ToString());
                        }
                        break;
                    }
                    ////////Pulses item add........
                case "Pulse":
                    {
                        string json = File.ReadAllText(Path);
                        try
                        {
                            var jObject = JObject.Parse(json);
                            JArray PulseArrary = (JArray)jObject["Pulse"];
                            Console.Write("Enter Pulse price : ");
                            int price = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Pulse weight : ");
                            int weight = Convert.ToInt32(Console.ReadLine());
                            if (price > 0 && weight > 0)
                            {
                                Console.Write("Enter the Pulse name : ");
                                var name = Convert.ToString(Console.ReadLine());

                                foreach (var item in PulseArrary)
                                {
                                    item["name"] = !string.IsNullOrEmpty(name) ? name : "";
                                }

                                jObject["Pulse"] = PulseArrary;
                                string output = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                                File.WriteAllText(Path, output);
                            }
                            else
                            {
                                Console.Write("Invalid Item price and weight, Try Again!");
                                UpdateItem();
                            }
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine("Update Error : " + ex.Message.ToString());
                        }
                        break;
                    }
                    //////Wheats item additions..............
                case "Wheat":
                    {
                        string json = File.ReadAllText(Path);
                        try
                        {
                            var jObject = JObject.Parse(json);
                            JArray WheatArrary = (JArray)jObject["Wheat"];
                            Console.Write("Enter Wheat price : ");
                            int price = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Wheat weight : ");
                            int weight = Convert.ToInt32(Console.ReadLine());
                            if (price > 0 && weight > 0)
                            {
                                Console.Write("Enter the Wheat name : ");
                                var name = Convert.ToString(Console.ReadLine());

                                foreach (var item in WheatArrary)
                                {
                                    item["name"] = !string.IsNullOrEmpty(name) ? name : "";
                                }

                                jObject["Wheat"] = WheatArrary;
                                string output = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                                File.WriteAllText(Path, output);
                            }
                            else
                            {
                                Console.Write("Invalid Item price and weight, Try Again!");
                                UpdateItem();
                            }
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine("Update Error : " + ex.Message.ToString());
                        }
                        break;
                    }
            }
        }
        /// <summary>
        /// Delate the Inventory items....
        /// </summary>
        public static void DelateItem()
        {
            Console.WriteLine("enter the choice and Delate the item...");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Rice. Delate the rice item");
            Console.WriteLine("Pulse. Delate the rice item");
            Console.WriteLine("Wheat. Delate the rice item");
            string choice = Console.ReadLine();
            switch (choice)
            {////Rice items Delations......
                case "Rice":
                    {
                        string json = File.ReadAllText(Path);
                        try
                        {
                            var jObject = JObject.Parse(json);
                            JArray RiceArrary = (JArray)jObject["Rice"];
                            Console.Write("Enter the rice name and delate the rice : ");
                            string name = Console.ReadLine();
                            //string Name = string.Empty;
                            var RiceToDeleted = RiceArrary.FirstOrDefault(obj => obj["Name"].Value<string>() == name);
                            RiceArrary.Remove(RiceToDeleted);
                            string output = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                            File.WriteAllText(Path, output);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        break;
                    }
                    ////Pulses items delations..........
                case "Pulse":
                    {
                        string json = File.ReadAllText(Path);
                        try
                        {
                            var jObject = JObject.Parse(json);
                            JArray PulseArrary = (JArray)jObject["Pulse"];
                            Console.Write("Enter the Pulse name and delate the rice : ");
                            string name = Console.ReadLine();
                            //string Name = string.Empty;
                            var PulseToDeleted = PulseArrary.FirstOrDefault(obj => obj["Name"].Value<string>() == name);
                            PulseArrary.Remove(PulseToDeleted);
                            string output = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                            File.WriteAllText(Path, output);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        break;
                    }
                    ////Wheats items delations...........
                case "Wheat":
                    {
                        string json = File.ReadAllText(Path);
                        try
                        {
                            var jObject = JObject.Parse(json);
                            JArray WheatArrary = (JArray)jObject["Wheat"];
                            Console.Write("Enter the Wheat name and delate the rice : ");
                            string name = Console.ReadLine();
                            //string Name = string.Empty;
                            var WheatToDeleted = WheatArrary.FirstOrDefault(obj => obj["Name"].Value<string>() == name);
                            WheatArrary.Remove(WheatToDeleted);
                            string output = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                            File.WriteAllText(Path, output);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        break;
                    }
            }
           
        }
        
    }
}