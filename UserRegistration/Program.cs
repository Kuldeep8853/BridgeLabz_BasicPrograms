// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserRegistration" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first name and First character must be Upper case: ");
            string Fname = Console.ReadLine();
            UserRegistrationValidation user = new UserRegistrationValidation();
            Console.WriteLine(user.CheckPwd(Fname));
        }
    }
}
