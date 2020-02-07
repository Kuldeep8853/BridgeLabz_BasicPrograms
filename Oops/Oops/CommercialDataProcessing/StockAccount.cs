using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Oops.CommercialDataProcessing
{
    class StockAccount
    {
       static StockStackList<string> detail = new StockStackList<string>();
        /// <summary>
        /// Display the company share details.......
        /// </summary>
        public static void ReadCompanyStock()
        {
            string json = File.ReadAllText(@"D:\Oops\Oops\CommercialDataProcessing\CompanyStock.json");
            JArray stockArrary = JArray.Parse(json);
            Console.WriteLine("Company share details......");
            Console.WriteLine("---------------------------");
            foreach (var stock in stockArrary)
            {
                Console.WriteLine("ShareName :   " + stock["ShareName"]);
                Console.WriteLine("NoOfShare :   " + stock["NoOfShare"]);
                Console.WriteLine("SharePrice :  " + stock["SharePrice"]);
                Console.WriteLine("--------------------");
            }
        }
        public static void ReadUserstock()
        {
            string json = File.ReadAllText(@"D:\Oops\Oops\CommercialDataProcessing\UserStock.json");
            var jObject = JObject.Parse(json);
            Console.WriteLine("User share details......");
            Console.WriteLine("------------------------");
            Console.WriteLine("User amount: "+ jObject["Amount"]);
            Console.WriteLine("User share: " + jObject["ShareNumber"]);
            JArray stockArrary = (JArray)jObject["Share"];
            Console.WriteLine("--------------------");
            foreach (var stock in stockArrary)
            {
                Console.WriteLine("ShareName :   " + stock["ShareName"]);
                Console.WriteLine("NoOfShare :   " + stock["NoOfShare"]);
                Console.WriteLine("SharePrice :  " + stock["SharePrice"]);
                Console.WriteLine("Date and Time :  " + stock["Date and Time"]);

                Console.WriteLine("--------------------");
            }
        }

        /// <summary>
        /// Get the User amount.....
        /// </summary>
        public static  void ValueOf()
        {
            string UserFiles = File.ReadAllText(@"D:\Oops\Oops\CommercialDataProcessing\UserStock.json");
            dynamic jObject = JObject.Parse(UserFiles);
            Console.WriteLine(jObject.Amount);
        }

        /// <summary>
        /// Enter the company name and amount, Buy the share......... 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="sharename"></param>
        public static void BuyShare(int amount,string sharename)
        {
            string Companyfiles = File.ReadAllText(@"D:\Oops\Oops\CommercialDataProcessing\CompanyStock.json");
            JArray StockArray = JArray.Parse(Companyfiles);
            foreach (var stock in StockArray)
            {
                if (((string)stock["ShareName"]).Equals(sharename))
                {
                    int No_Of_Share = amount / Convert.ToInt32(stock["SharePrice"]);
                    string UserFiles = File.ReadAllText(@"D:\Oops\Oops\CommercialDataProcessing\UserStock.json");
                    var jObject = JObject.Parse(UserFiles);
                    stock["NoOfShare"] = (int)stock["NoOfShare"] - No_Of_Share;
                    jObject["Amount"] = (int)jObject["Amount"] - amount;
                    jObject["ShareNumber"] = (int)jObject["ShareNumber"] + No_Of_Share;
                    JArray shareArray = (JArray)jObject["Share"];
                    int length = ((JArray)jObject["Share"]).Count;
                    for(int i=0;i<length;i++){
                        if (((string)shareArray[i]["ShareName"]).Equals(sharename))
                        {
                            shareArray[i]["NoOfShare"] =(int)shareArray[i]["NoOfShare"] + No_Of_Share;
                            shareArray[i]["Date and Time"] = DateTime.Now.ToString("dd-MM-yyyy " + " HH:mm:ss");
                            break;
                        }
                        else
                        {
                            if (i == (length - 1))
                            {
                                JObject share = new JObject
                                            {
                                                { "ShareName", sharename },
                                                { "NoOfShare", No_Of_Share },
                                                { "SharePrice", Convert.ToInt32(stock["SharePrice"]) },
                                                {"Date and Time", DateTime.Now.ToString("dd-MM-yyyy " + " HH:mm:ss") }

                                            };
                                shareArray.Add(share);
                            }
                        }
                    }
                        var jsonToOutput1 = JsonConvert.SerializeObject(jObject, Formatting.Indented);  //// Serialize the object after the add the stock in perticular array...
                        File.WriteAllText(@"D:\Oops\Oops\CommercialDataProcessing\UserStock.json", jsonToOutput1);
                        var jsonToOutput = JsonConvert.SerializeObject(StockArray, Formatting.Indented);
                        File.WriteAllText(@"D:\Oops\Oops\CommercialDataProcessing\CompanyStock.json", jsonToOutput);
                    Console.WriteLine("Buy the " + No_Of_Share + " share of "+ sharename+" company" +", Date and time "+ DateTime.Now.ToString("dd-MM-yyyy " + " HH:mm:ss"));
                    detail.Push("Buy the " + No_Of_Share + " share of " + sharename + " company" + ", Date and time " + DateTime.Now.ToString("dd-MM-yyyy " + " HH:mm:ss"));
                }
            }
        }

        /// <summary>
        /// shell the stock..........
        /// </summary>
        /// <param name="shareNumber"></param>
        /// <param name="sharename"></param>
        public static void StockSell(int shareNumber, string sharename)
        {
            try
            {
                string UserFiles = File.ReadAllText(@"D:\Oops\Oops\CommercialDataProcessing\UserStock.json");
                var jObject = JObject.Parse(UserFiles);
                jObject["ShareNumber"] = (int)jObject["ShareNumber"] - shareNumber;
                JArray shareArray = (JArray)jObject["Share"];
                int length = ((JArray)jObject["Share"]).Count;
                for (int i = 0; i < length; i++)
                {
                    if (((string)shareArray[i]["ShareName"]).Equals(sharename))
                    {
                        shareArray[i]["NoOfShare"] = (int)shareArray[i]["NoOfShare"] - shareNumber;
                        shareArray[i]["Date and Time"] = DateTime.Now.ToString("dd-MM-yyyy " + " HH:mm:ss");
                        jObject["Amount"] = (int)jObject["Amount"] + (shareNumber * (int)shareArray[i]["SharePrice"]);
                        break;
                    }
                }
                var jsonToOutput = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(@"D:\Oops\Oops\CommercialDataProcessing\UserStock.json", jsonToOutput);
                Console.WriteLine("Shell the " + shareNumber + " share of " + sharename + " company" + ", Date and time " + DateTime.Now.ToString("dd-MM-yyyy " + " HH:mm:ss"));
                string detail1=Convert.ToString("Shell the " + shareNumber + " share of " + sharename + " company" + ", Date and time " + DateTime.Now.ToString("dd-MM-yyyy " + " HH:mm:ss"));
                detail.Push(detail1);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void PrintReport()
        {

            detail.PrintStack();
        }
    }
}
