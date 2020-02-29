// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserRegistration" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserRegistrationValidation
    {
        /// <summary>
        /// Check First name validation 
        /// </summary>
        /// <param name="Fname"></param>
        /// <returns></returns>
        public bool CheckFname(string Fname)
        {
           return Regex.IsMatch(Fname, "^[A-Z]{1}[a-z,A-Z]*$");
        }

        /// <summary>
        /// Check Last name validation
        /// </summary>
        /// <param name="Lname"></param>
        /// <returns></returns>
        public bool CheckLname(string Lname)
        {
            return Regex.IsMatch(Lname, "^[A-Z]{1}[a-z,A-Z]*$");
        }

        /// <summary>
        /// Check Mobile number validation
        /// </summary>
        /// <param name="MobileNo"></param>
        /// <returns></returns>
        public bool CheckMobileNo(string MobileNo)
        {
            return Regex.IsMatch(MobileNo, "^[+,0-9,-?]{3,4}[0-9]{10}$");
        }

        /// <summary>
        /// Check Email Validation
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
        public bool CheckEmail(string Email)
        {
            return Regex.IsMatch(Email, "^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+[.])+[a-z]{2,5}$");
        }

        /// <summary>
        /// Check Password validation
        /// </summary>
        /// <param name="Pwd"></param>
        /// <returns></returns>
        public bool CheckPwd(string Pwd)
        {
            return Regex.IsMatch(Pwd, "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^(.{8,15})$");
        }


    }
}
