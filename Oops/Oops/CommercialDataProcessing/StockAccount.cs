using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Oops.CommercialDataProcessing
{
    class StockAccount
    {
        public static void ReadCompanyStock()
        {
            string json = File.ReadAllText(@"D:\Oops\Oops\CommercialDataProcessing\CompanyStock.json");
            JArray stockArrary = JArray.Parse(json);
            Console.WriteLine("--------------------");
            foreach (var stock in stockArrary)
            {
                Console.WriteLine("ShareName :    " + stock["ShareName"]);
                Console.WriteLine("NoOfShare :     " + stock["NoOfShare"]);
                Console.WriteLine("SharePrice :  " + stock["SharePrice"]);
                Console.WriteLine("--------------------");
            }


        }
        public static  void ValueOf()
        {
            string UserFiles = File.ReadAllText(@"D:\Oops\Oops\CommercialDataProcessing\UserStock.json");
            dynamic jObject = JObject.Parse(UserFiles);
            Console.WriteLine(jObject.Amount);
        }
        public static void BuyShare(int amount,string sharename)
        {
            string Companyfiles = File.ReadAllText(@"D:\Oops\Oops\CommercialDataProcessing\CompanyStock.json");
            JArray StockArray = JArray.Parse(Companyfiles);
            foreach (var stock in StockArray)
            {
                if (Equals(stock["ShareName"], sharename))
                {
                    int No_Of_Share = amount / Convert.ToInt32(stock["SharePrice"]);
                    string UserFiles = File.ReadAllText(@"D:\Oops\Oops\CommercialDataProcessing\UserStock.json");
                    dynamic jObject = JObject.Parse(UserFiles);
                    jObject.Amount = Convert.ToInt32(jObject.Amount) - amount;
                    jObject.ShareNumber = Convert.ToInt32(jObject.ShareNumber) - No_Of_Share;
                    JArray shareArray = (JArray)jObject["Share"];
                    if (Equals(stock["ShareName"], sharename))
                    {
                        shareArray["NoOfShare"] = Convert.ToInt32(shareArray["NoOfShare"]) + No_Of_Share;
                        shareArray["SharePrice"] = Convert.ToInt32(shareArray["SharePrice"]) + amount;
                    }
                    else
                    {
                        JObject share = new JObject
                                        {
                                            { "ShareName", sharename },
                                            { "NoOfShare", No_Of_Share },
                                            { "SharePrice", Convert.ToInt32(stock["SharePrice"]) }

                                        };
                        shareArray.Add(share);
                        var jsonToOutput1 = JsonConvert.SerializeObject(jObject, Formatting.Indented);  //// Serialize the object after the add the stock in perticular array...
                        File.WriteAllText(@"D:\Oops\Oops\CommercialDataProcessing\UserStock.json", jsonToOutput1);
                    }
                    Console.WriteLine("Buy the " + No_Of_Share + " Number of share"+", Date and time "+ DateTime.Now.ToString("dd/mm/yyyy " + " HH:mm:ss"));
                }
                else
                {
                    Console.WriteLine("this share not prasent in Company stock files, Please Enter the valid share name ");
                }
            }
           
        }

    }
}
