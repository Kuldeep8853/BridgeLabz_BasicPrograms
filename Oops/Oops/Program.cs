using Oops.AddressBook;
using Oops.Inventory;
using Oops.StockAccountManagement;
using System;

/// <summary>
/// This is main programs class and start execution all OOps program
/// in program class......
/// </summary>
namespace Oops{
    class Program{
        /// <summary>
        /// Main methods of the Oops programs.....
        /// </summary>
      public static void Main(){
            Console.WriteLine("Enter the choice......");
            Console.WriteLine("Inventory: Detailss of items....");
            Console.WriteLine("AddressBook: Detailss of Persons...");
            Console.WriteLine("StockManagement: Detailss of Company stock...");
            Console.WriteLine("BuyAndShellShare. Buy and shell the share....");
            string choice = Console.ReadLine();
            switch (choice)
            {
                ////Inventory items details and CRUD oprations.....
                case "Inventory":
                    {
                        Console.WriteLine("Enter the choice..... ");
                        Console.WriteLine("----------------------");
                        Console.WriteLine("DisplayItem. Desplay the items...");
                        Console.WriteLine("AddItem. add the item.....");
                        Console.WriteLine("DelateItem. Delate the item......");
                        string choice1 = Console.ReadLine();
                        switch (choice1)
                        {
                            case "DisplayItem":
                                {
                                    InventoryDriver.ReadItem();
                                    break;
                                }
                            case "AddItem":
                                {
                                    InventoryDriver.AddItem();
                                    break;
                                }
                            case "UpdateItem":
                                {
                                    InventoryDriver.UpdateItem();
                                    break;
                                }
                            case "DelateItem":
                                {
                                    InventoryDriver.DelateItem();
                                    break;
                                }
                        }

                        break;
                    }

                //// Address Book Switch case and all CRUD oprations....
                case "AddressBook":
                    {
                        Console.WriteLine("Enter the choice..... ");
                        Console.WriteLine("----------------------");
                        Console.WriteLine("DisplayPerson. Desplay the Person Details...");
                        Console.WriteLine("AddPerson. add the Person Details.....");
                        Console.WriteLine("DelateDetails. Delate the Person Details......");
                        Console.WriteLine("UpdateDetails. Update the Person Details......");
                        string choice1 = Console.ReadLine();
                        switch (choice1)
                        {
                            case "DisplayPerson":
                                {
                                    AddressBookDriver.ReadPerson();
                                    break;
                                }
                            case "AddPerson":
                                {
                                    AddressBookDriver.AddPerson();
                                    break;
                                }
                            case "DelateDetails":
                                {
                                    AddressBookDriver.DelateDetails();
                                    break;
                                }
                            case "UpdateDetails":
                                {
                                    AddressBookDriver.UpdateDetails();
                                    break;
                                }
                            default:
                                {
                                    break;
                                }

                        }
                        break;

                    }

                //// Stock Account management Switch case and contain all CRUD opration.....
                case "StockManagement":
                    {
                        Console.WriteLine("Enter the choice..... ");
                        Console.WriteLine("----------------------");
                        Console.WriteLine("DisplayStockDetails. Desplay the Stock Details...");
                        Console.WriteLine("AddStock. add the stock Details.....");
                        Console.WriteLine("UpdateStock. Update the stock Details......");
                        Console.WriteLine("DelateStockDetails. detale the stock Details......");
                        ////Console.WriteLine("UpdateDetails. Update the Person Details......");
                        string choice1 = Console.ReadLine();
                        switch (choice1)
                        {
                            case "DisplayStockDetails":
                                {
                                    StockAccountDriver.DisplayStockDetails();
                                    break;
                                }

                            case "AddStock":
                                {
                                    StockAccountDriver.AddStock();
                                    break;
                                }

                            case "UpdateStock":
                                {
                                    StockAccountDriver.UpdateStock();
                                    break;
                                }

                            case "DelateStockDetails":
                                {
                                    StockAccountDriver.DelateStockDetails();
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Enter the valid choice...");
                                    break;
                                }

                        }
                        break;
                    }
                case "BuyAndShellShare":
                    {
                        Console.WriteLine("Enter the choice..... ");
                        Console.WriteLine("----------------------");
                        Console.WriteLine("DisplaysharekDetails. Desplay the User and Company share Details...");
                        Console.WriteLine("BuyShare. Custmor want to buy share...");
                        Console.WriteLine("SharShelle. Custmor want to shell share...");
                        Console.WriteLine("PrintReport.Print the all buy and shell share reports..");
                        ////Console.WriteLine("UpdateDetails. Update the Person Details......");
                        string choice1 = Console.ReadLine();
                        switch (choice1)
                        {
                            case "DisplaysharekDetails":
                                {
                                    CommercialDataProcessing.StockAccount.ReadCompanyStock();
                                    CommercialDataProcessing.StockAccount.ReadUserstock();
                                    break;
                                }
                            case "BuyShare":
                                {
                                    CommercialDataProcessing.StockAccount.ValueOf();
                                    Console.WriteLine("Which share you want to buy ");
                                    CommercialDataProcessing.StockAccount.ReadCompanyStock();
                                    Console.Write("Entre the share name: ");
                                    string shareNmae = Console.ReadLine();
                                    Console.Write("Entre the your amount: ");
                                    int amount = Convert.ToInt32(Console.ReadLine());
                                    CommercialDataProcessing.StockAccount.BuyShare(amount, shareNmae);
                                    break;
                                }
                            case "SharShelle":
                                {
                                    Console.WriteLine("Which share you want to shell ");
                                    CommercialDataProcessing.StockAccount.ReadUserstock();
                                    Console.Write("Entre the share name: ");
                                    string shareNmae = Console.ReadLine();
                                    Console.Write("Entre the Number of share : ");
                                    int shareNumber = Convert.ToInt32(Console.ReadLine());
                                    CommercialDataProcessing.StockAccount.StockSell(shareNumber, shareNmae);
                                    break;
                                }
                            case "PrintReport":
                                {
                                    CommercialDataProcessing.StockAccount.PrintReport();
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter the valid choice...");
                        break;
                    }
            }
      }
    }
}
