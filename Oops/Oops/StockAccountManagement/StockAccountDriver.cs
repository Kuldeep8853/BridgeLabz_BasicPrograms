using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

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
            ////Read the json file.....
            string files = File.ReadAllText(@"D:\Oops\Oops\StockAccountManagement\CompanyInJsonFile.json");
            var jObject = JObject.Parse(files);
            Console.WriteLine("Enter the choice Update the details......");
            Console.WriteLine("Amazon. Update the share name of given index");
            Console.WriteLine("Flipkart. Update the share name of given index");
            Console.WriteLine("Tcs. Update the share name of given index");
            string choice = Console.ReadLine();
            switch (choice)
            { 
                //// Update the amazon array....
                case "Amazon":
                    {
                        JArray AmazonArrary = (JArray)jObject["Amazon"];
                        // int length = ((JArray)jObject["Amazon"]).Count;====>Find Amazon array Length.
                        //Console.WriteLine(length);
                        Console.WriteLine("Enter the Amazon array index");
                        int index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the choice Update the details......");
                        Console.WriteLine("ShareName.  Update the share name of given index");
                        Console.WriteLine("NoOfShare.  Update the number of share of given index");
                        Console.WriteLine("SharePrice. Update the share price of given index");
                        string choice1 = Console.ReadLine();
                        switch (choice1)
                        {
                            //// Update the share name........
                            case "ShareName":
                                {
                                    Console.Write("Enter the stock name : ");
                                    string name = Convert.ToString(Console.ReadLine());
                                    AmazonArrary[index]["ShareName1"] = name;
                                    break;
                                }
                                ////Update the share number.....
                            case "NoOfShare":
                                {
                                    Console.Write("Enter the number of stock : ");
                                    int n = Convert.ToInt32(Console.ReadLine());
                                    AmazonArrary[index]["NoOfShare1"] = n;
                                    break;
                                }
                                ////Update the price of the share......
                            case "SharePrice":
                                {
                                    Console.Write("Enter the stock price : ");
                                    int price = Convert.ToInt32(Console.ReadLine());
                                    AmazonArrary[index]["SharePrice1"] = price;
                                    break;
                                }
                        }
                        jObject["Amazon"] = AmazonArrary;
                        break;
                    }
                    ////update the Flipkart array of the object.....
                case "Flipkart":
                    {
                        JArray FlipkartArrary = (JArray)jObject["Flipkart"];
                        // int length = ((JArray)jObject["Amazon"]).Count;====>Find Amazon array Length.
                        //Console.WriteLine(length);
                        Console.WriteLine("Enter the Flipkart array index");
                        int index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the choice Update the details......");
                        Console.WriteLine("ShareName.  Update the share name of given index");
                        Console.WriteLine("NoOfShare.  Update the number of share of given index");
                        Console.WriteLine("SharePrice. Update the share price of given index");
                        string choice1 = Console.ReadLine();
                        switch (choice1)
                        {
                            //// Update the share name........
                            case "ShareName":
                                {
                                    Console.Write("Enter the stock name : ");
                                    string name = Convert.ToString(Console.ReadLine());
                                    FlipkartArrary[index]["ShareName1"] = name;
                                    break;
                                }
                            ////Update the share number.....
                            case "NoOfShare":
                                {
                                    Console.Write("Enter the number of stock : ");
                                    int n = Convert.ToInt32(Console.ReadLine());
                                    FlipkartArrary[index]["NoOfShare1"] = n;
                                    break;
                                }
                            ////Update the price of the share......
                            case "SharePrice":
                                {
                                    Console.Write("Enter the stock price : ");
                                    int price = Convert.ToInt32(Console.ReadLine());
                                    FlipkartArrary[index]["SharePrice1"] = price;
                                    break;
                                }
                        }
                        jObject["Flipkart"] = FlipkartArrary;
                        break;
                    }
                    ////Update the Tcs array object......
                case "Tcs":
                    {
                        JArray TcsArrary = (JArray)jObject["Tcs"];
                        // int length = ((JArray)jObject["Amazon"]).Count;====>Find Amazon array Length.
                        //Console.WriteLine(length);
                        Console.WriteLine("Enter the Tcs array index");
                        int index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the choice Update the details......");
                        Console.WriteLine("ShareName.  Update the share name of given index");
                        Console.WriteLine("NoOfShare.  Update the number of share of given index");
                        Console.WriteLine("SharePrice. Update the share price of given index");
                        string choice1 = Console.ReadLine();
                        switch (choice1)
                        {
                            //// Update the share name........
                            case "ShareName":
                                {
                                    Console.Write("Enter the stock name : ");
                                    string name = Convert.ToString(Console.ReadLine());
                                    TcsArrary[index]["ShareName1"] = name;
                                    break;
                                }
                            ////Update the price of the share......
                            case "NoOfShare":
                                {
                                    Console.Write("Enter the number of stock : ");
                                    int n = Convert.ToInt32(Console.ReadLine());
                                    TcsArrary[index]["NoOfShare1"] = n;
                                    break;
                                }
                            ////Update the price of the share......
                            case "SharePrice":
                                {
                                    Console.Write("Enter the stock price : ");
                                    int price = Convert.ToInt32(Console.ReadLine());
                                    TcsArrary[index]["SharePrice1"] = price;
                                    break;
                                }
                        }
                        jObject["Tcs"] = TcsArrary;
                        break;
                    }
            }
                   string output = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                  File.WriteAllText(@"D:\Oops\Oops\StockAccountManagement\CompanyInJsonFile.json", output);
        }

        /// <summary>
        /// Remove the perticular company stock details.....
        /// </summary>
        public static void DelateStockDetails()
        {
            string files = File.ReadAllText(@"D:\Oops\Oops\StockAccountManagement\CompanyInJsonFile.json");
            var jObject = JObject.Parse(files);
            Console.WriteLine("enter the choice and Delate the item...");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Amazon. Delate the Amazon stock details..");
            Console.WriteLine("Flipkart. Delate the rice item");
            Console.WriteLine("Tcs. Delate the rice item");
            string choice = Console.ReadLine();
            switch (choice)
            {////Rice items Delations......
                case "Amazon":
                    {

                        try
                        {
                            JArray AmazonArrary = (JArray)jObject["Amazon"];
                            Console.Write("Enter the stock name and delate the stock details : ");
                            string name = Console.ReadLine();
                            //string Name = string.Empty;
                            var DetailToDeleted = AmazonArrary.FirstOrDefault(obj => obj["ShareName1"].Value<string>() == name);
                            AmazonArrary.Remove(DetailToDeleted);
                            string output = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                            File.WriteAllText(@"D:\Oops\Oops\StockAccountManagement\CompanyInJsonFile.json", output);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        break;
                    }
                case "Flipkart":
                    {

                        try
                        {
                            JArray FlipkartArrary = (JArray)jObject["Flipkart"];
                            Console.Write("Enter the stock name and delate the stock details : ");
                            string name = Console.ReadLine();
                            //string Name = string.Empty;
                            var DetailToDeleted = FlipkartArrary.FirstOrDefault(obj => obj["ShareName1"].Value<string>() == name);
                            FlipkartArrary.Remove(DetailToDeleted);
                            string output = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                            File.WriteAllText(@"D:\Oops\Oops\StockAccountManagement\CompanyInJsonFile.json", output);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        break;
                    }
                case "Tcs":
                    {

                        try
                        {
                            JArray TcsArrary = (JArray)jObject["Tcs"];
                            Console.Write("Enter the stock name and delate the stock details : ");
                            string name = Console.ReadLine();
                            //string Name = string.Empty;
                            var DetailToDeleted = TcsArrary.FirstOrDefault(obj => obj["ShareName1"].Value<string>() == name);
                            TcsArrary.Remove(DetailToDeleted);
                            string output = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                            File.WriteAllText(@"D:\Oops\Oops\StockAccountManagement\CompanyInJsonFile.json", output);
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
