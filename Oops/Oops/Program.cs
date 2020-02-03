using Oops.AddressBook;
using Oops.Inventory;
using System;
namespace Oops{
    class Program{
        /// <summary>
        /// Main methods of the Oops programs.....
        /// </summary>
      public static void Main(){
            Console.WriteLine("Enter the choice......");
            Console.WriteLine("Inventory: Detailss of items....");
            Console.WriteLine("AddressBook: Detailss of Persons...");
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
            }      
        }
    }
}
