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
                        switch (choice1) {
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
                        ////Console.WriteLine("DelateDetails. Delate the Person Details......");
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
                        }
                               

                        break;
                    }
            }      
        }
    }
}
