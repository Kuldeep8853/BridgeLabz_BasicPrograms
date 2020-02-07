using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace Oops.CommercialDataProcessing{
    class AddandRemoveShare{

        /// <summary>
        /// Using the StockLinked list....
        /// </summary>
       static StockLinkedList<JObject> stock = new StockLinkedList<JObject>();

        /// <summary>
        /// Print the Linked List Data.....
        /// </summary>
        public static void PrintList()
        {
            string files = File.ReadAllText(@"D:\Oops\Oops\CommercialDataProcessing\CompanyStock.json");
           
            JArray shareArray = JArray.Parse(files);
            foreach(JObject share in shareArray)
            {
                stock.Add(share);
            }
            stock.PrintStock();
        }

        /// <summary>
        /// Add the share with help of linked list.....
        /// </summary>
        public static void AddStock()
        {
            string files = File.ReadAllText(@"D:\Oops\Oops\CommercialDataProcessing\CompanyStock.json");
            JArray shareArray = JArray.Parse(files);
            Console.Write("Entre the share name: ");
            string sharename = Console.ReadLine();
            Console.Write("Entre the Number of share: ");
            int No_Of_Share = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entre the share price: ");
            int price = Convert.ToInt32(Console.ReadLine());
               JObject stock1 = new JObject
                                            {
                                                { "ShareName", sharename },
                                                { "NoOfShare", No_Of_Share },
                                                { "SharePrice", price }
                                             

                                            };
            shareArray.Add(stock1);
            stock.Add(stock1);
            var jsonToOutput = JsonConvert.SerializeObject(shareArray, Formatting.Indented);
            File.WriteAllText(@"D:\Oops\Oops\CommercialDataProcessing\CompanyStock.json", jsonToOutput);
            PrintList();
        }

        /// <summary>
        /// Remove the share with help of Linked List......
        /// </summary>
        public static void RemoveStock()
        {
            Console.Write("Which share want to remove.... ");
            PrintList();
            string files = File.ReadAllText(@"D:\Oops\Oops\CommercialDataProcessing\CompanyStock.json");
            JArray shareArray = JArray.Parse(files);
            Console.Write("Enter the share name and remove the share : ");
            string name = Console.ReadLine();
            //string Name = string.Empty;
            var DetailToDeleted = shareArray.FirstOrDefault(obj => obj["ShareName"].Value<string>() == name);
                shareArray.Remove(DetailToDeleted);
            string output = JsonConvert.SerializeObject(shareArray, Formatting.Indented);
            File.WriteAllText(@"D:\Oops\Oops\CommercialDataProcessing\CompanyStock.json", output);
        }
    }
}
