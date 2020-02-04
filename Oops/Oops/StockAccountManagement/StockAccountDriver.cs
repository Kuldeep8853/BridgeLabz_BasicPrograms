using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Oops.StockAccountManagement
{
    /// <summary>
    /// this is Stock Account Driver class containing all CRUD Opration methods.....
    /// </summary>
    class StockAccountDriver
    {
    /// <summary>
    ///Display the stock details....   
    /// </summary>
        public static void DisplayStockDetails()
        {
           string files = File.ReadAllText(@"D:\Oops\Oops\StockAccountManagement\CompanyInJsonFile.json");
           var jObject = JObject.Parse(files);
            try
            {
                Console.WriteLine("Enter the choice and Display the strock details..: ");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Amazon: Displey Amazon stock details... ");
                Console.WriteLine("Flipkart: Displey Flipkart stock details... ");
                Console.WriteLine("Tcs: Displey Tcs stock details... ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "Amazon":
                        {
                            ////Amazon stock details............    
                            JArray AmazonArrary = (JArray)jObject["Amazon"];
                            Console.WriteLine("Amazon Share------------------");
                            Console.WriteLine("------------------------------");
                            foreach (var stock in AmazonArrary)
                            {
                                Console.WriteLine("ShareName :   " + stock["ShareName1"]);
                                Console.WriteLine("NoOfShare :   " + stock["NoOfShare1"]);
                                Console.WriteLine("SharePrice :  " + stock["SharePrice1"]);
                                Console.WriteLine("--------------------");
                            }
                            break;
                        }

                    case "Flipkart":
                        {
                            ////Flipkart stock details.....................
                            JArray FlipkartArrary = (JArray)jObject["Flipkart"];
                            Console.WriteLine("Flipkart share-----------------");
                            Console.WriteLine("-------------------------------");
                            foreach (var stock in FlipkartArrary)
                            {
                                Console.WriteLine("ShareName :   " + stock["ShareName1"]);
                                Console.WriteLine("NoOfShare :   " + stock["NoOfShare1"]);
                                Console.WriteLine("SharePrice :  " + stock["SharePrice1"]);
                                Console.WriteLine("--------------------");
                            }
                            break;
                        }
                    case "Tcs":
                        {
                            //// TCS stock details.......................
                            JArray TcsArrary = (JArray)jObject["Tcs"];
                            Console.WriteLine("Tcs share----------------------");
                            Console.WriteLine("-------------------------------");
                            foreach (var stock in TcsArrary)
                            {
                                Console.WriteLine("ShareName :   " + stock["ShareName1"]);
                                Console.WriteLine("NoOfShare :   " + stock["NoOfShare1"]);
                                Console.WriteLine("SharePrice :  " + stock["SharePrice1"]);
                                Console.WriteLine("--------------------");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter the valid input..");
                            break;
                        }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Add stock details in perticular company......
        /// </summary>
        public static void AddStock()
        {
            string files = File.ReadAllText(@"D:\Oops\Oops\StockAccountManagement\CompanyInJsonFile.json");
            var jObject = JObject.Parse(files);

            Console.WriteLine("Enter the choice and Display the strock details..: ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Amazon: Add Amazon stock details... ");
            Console.WriteLine("Flipkart: Add Flipkart stock details... ");
            Console.WriteLine("Tcs: Add Tcs stock details... ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                //// Add Amazon company stock.......... 
                case "Amazon":
                    {
                        Console.Write("Enter the Amazon company stock name : ");
                        string stockname = Console.ReadLine();
                        Console.Write("Enter Number of stock : ");
                        string stockNo = Console.ReadLine();
                        Console.Write("Enter stock price  : ");
                        string stockPrice = Console.ReadLine();

                        JArray AmazonArrary = (JArray)jObject["Amazon"];
                        JObject stock = new JObject
                                        {
                                            { "ShareName1", stockname },
                                            { "NoOfShare1", stockNo },
                                            { "SharePrice1", stockPrice }

                                        };
                        AmazonArrary.Add(stock);
                        break;
                    }

                    //// Add Flipkart company stock..............
                case "Flipkart":
                    {
                        Console.Write("Enter the Flipkart company stock name : ");
                        string stockname = Console.ReadLine();
                        Console.Write("Enter Number of stock : ");
                        string stockNo = Console.ReadLine();
                        Console.Write("Enter stock price  : ");
                        string stockPrice = Console.ReadLine();

                        JArray FlipkartArrary = (JArray)jObject["Flipkart"];
                        JObject stock = new JObject
                                        {
                                            { "ShareName1", stockname },
                                            { "NoOfShare1", stockNo },
                                            { "SharePrice1", stockPrice }

                                        };
                        FlipkartArrary.Add(stock);
                        break;
                    }

                    //// Add Tcs company stock................
                case "Tcs":
                    {
                        Console.Write("Enter the Tcs company stock name : ");
                        string stockname = Console.ReadLine();
                        Console.Write("Enter Number of stock : ");
                        string stockNo = Console.ReadLine();
                        Console.Write("Enter stock price  : ");
                        string stockPrice = Console.ReadLine();
                        JArray TcsArrary = (JArray)jObject["Tcs"];
                        //dynamic record = new
                        //{
                        //    Tcs = new object[] {
                        //   new { ShareName1= stockname },
                        //   new { NoOfShare1= stockNo },
                        //   new { SharePrice1= stockPrice }
                        //    },
                        //};
                        JObject stock = new JObject
                                        {
                                            { "ShareName1", stockname },
                                            { "NoOfShare1", stockNo },
                                            { "SharePrice1", stockPrice }

                                        };
                        TcsArrary.Add(stock);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter the valid choice..");
                        break;
                    }
            }
            var jsonToOutput1 = JsonConvert.SerializeObject(jObject, Formatting.Indented);  //// Serialize the object after the add the stock in perticular array...
            File.WriteAllText(@"D:\Oops\Oops\StockAccountManagement\CompanyInJsonFile.json", jsonToOutput1);
        }

        /// <summary>
        /// Update the stock details.........
        /// </summary>
        public static void UpdateStock()
        {
            string files = File.ReadAllText(@"D:\Oops\Oops\StockAccountManagement\CompanyInJsonFile.json");
            var jObject = JObject.Parse(files);
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
                File.WriteAllText(@"D:\Oops\Oops\StockAccountManagement\CompanyInJsonFile.json", output);

            }
        }
    }
}
