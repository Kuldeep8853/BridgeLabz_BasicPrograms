using System;
using System.Text.RegularExpressions;

namespace AlgorithmsPrograms{
    class CustomizeRegEx{
        public static void RegExFuction()
        {
            string str = "Hello <<name>>, We have your full name as <<full name>> in our system." +
                         " your contact number is 91-xxxxxxxxxx." + " Please,let us know in case of any clarification.";
            string str2 = "Thank you BridgeLabz 01/01/2016.";

            string namePattern = @"^[A-Z][a-zA-Z]*$";
            string MobilePattern = @"^[0-9]{10}$";
            Console.WriteLine("Enter your first name:  ");
            string fname = Console.ReadLine();
            if (Regex.IsMatch(fname, namePattern))
            {
                Console.WriteLine("Enter your second name:  ");
                string sname = Console.ReadLine();
                if (Regex.IsMatch(sname, namePattern))
                {
                    Console.WriteLine("Enter your mobile number:  ");
                    string mNumber = Console.ReadLine();
                    if (Regex.IsMatch(mNumber, MobilePattern))
                    {
                       string date= DateTime.Today.ToString("dd-MM-yyyy");
                      str = str.Replace("<<name>>",fname);
                      str = str.Replace("<<full name>>", fname+" "+ sname);
                      str = str.Replace("xxxxxxxxxx", mNumber);
                      str2 = str2.Replace("01/01/2016", date);
                        Console.WriteLine(str);
                        Console.WriteLine(str2);
                    }
                    else
                        Console.WriteLine("Enter the valid mobile number.");

                }
                else
                    Console.WriteLine("Enter the valid second name.");
            }
            else
                Console.WriteLine("Enter the valid first name.");

        }
    }
}
