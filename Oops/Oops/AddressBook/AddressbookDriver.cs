using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Oops.AddressBook
{
    public class AddressBookDriver{
        /// <summary>
        /// Display the person details.....
        /// </summary>
        public static void ReadPerson() {
            string json = File.ReadAllText(@"D:\Oops\Oops\AddressBook\PersonList.json");
            JArray PersonArrary = JArray.Parse(json);
            Console.WriteLine("--------------------");
            foreach (var Person in PersonArrary)
            {
                Console.WriteLine("FirstName :    " + Person["FirstName"]);
                Console.WriteLine("LastName :     " + Person["LastName"]);
                Console.WriteLine("PhoneNumber :  " + Person["PhoneNumber"]);
                Console.WriteLine("Addresses :    " + Person["Addresses"]);
                Console.WriteLine("--------------------");
            }


        }
        /// <summary>
        /// Add the Person Details......
        /// </summary>
        public static void AddPerson()
        {
            Console.Write("Enter the FirstName : ");
            string Fname = Console.ReadLine();
            Console.Write("Enter the lastNmae : ");
            string Lname = Console.ReadLine();
            Console.Write("Enter the Phone Number : ");
            string PhoneNo = Console.ReadLine();
            Console.Write("Enter the Address : ");
            string Address = Console.ReadLine();
           
                string json = File.ReadAllText(@"D:\Oops\Oops\AddressBook\PersonList.json");
                var jObject = JObject.Parse(json);
                JArray Personrrary = (JArray)jObject["Person"];
                JObject list1 = new JObject
                            {
                                { "FirstName", Fname },
                                { "LastName", Lname },
                                { "PhoneNumber", PhoneNo },
                                {"Addresses",Address }
                            };
                Personrrary.Add(list1);
                var jsonToOutput1 = JsonConvert.SerializeObject(Personrrary, Formatting.Indented);
                File.WriteAllText(@"D:\Oops\Oops\AddressBook\PersonList.json", jsonToOutput1);
        }
        /// <summary>
        /// Delate the person details....
        /// </summary>
        public static void DelateDetails()
        {
            string json = File.ReadAllText(@"D:\Oops\Oops\AddressBook\PersonList.json");
            JArray PersonArrary = JArray.Parse(json);
                Console.Write("Enter the First name and delate the person details : ");
                string Fname = Console.ReadLine();
                //string Name = string.Empty;
                var DetailsToDeleted = PersonArrary.FirstOrDefault(obj => obj["FirstName"].Value<string>() == Fname);
                PersonArrary.Remove(DetailsToDeleted);
                string output = JsonConvert.SerializeObject(PersonArrary, Formatting.Indented);
                File.WriteAllText(@"D:\Oops\Oops\AddressBook\PersonList.json", output);
        }
        /// <summary>
        /// Update the person detailse.......
        /// </summary>
        public static void UpdateDetails()
        {
            string json = File.ReadAllText(@"D:\Oops\Oops\AddressBook\PersonList.json");
            JArray PersonArrary = JArray.Parse(json);
            var jObjects = PersonArrary.ToObject<List<JObject>>();   //Get list of objects inside array

            foreach (var obj in jObjects)                             //Loop through on a list
            {
                if (jObjects.IndexOf(obj) == 1)                       //Get 2nd object from array
                {
                    foreach (var prop in obj.Properties())            //List 2nd objects properties
                    {
                        if (prop.Name == "Addresses")           //Get desired property
                            obj["Addresses"] = "Banglore";               //Change its value
                    }
                }
            }

            JArray outputArray = JArray.FromObject(jObjects);         //Output array
            Console.WriteLine(outputArray);
        }
    }
}
