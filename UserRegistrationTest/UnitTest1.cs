// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserRegistration" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// --------------------------------------------------------------------------------------------------------------------
using NUnit.Framework;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void FnameTest()
        {
            UserRegistrationValidation user = new UserRegistrationValidation();
            bool actual = user.CheckFname("Kuldeep");
            bool expected = true;
            Assert.AreEqual(actual,expected);
        }

        [Test]
        public void LnameTest()
        {
            UserRegistrationValidation user = new UserRegistrationValidation();
            bool actual = user.CheckLname("Kasaudhan");
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void MobileNoTest()
        {
            UserRegistrationValidation user = new UserRegistrationValidation();
            bool actual = user.CheckMobileNo("+91-8853489667");
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void EmailTest()
        {
            UserRegistrationValidation user = new UserRegistrationValidation();
            bool actual = user.CheckEmail("kkasaudhan8853@gmail.com");
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void PwdTest()
        {
            UserRegistrationValidation user = new UserRegistrationValidation();
            bool actual = user.CheckPwd("Kuldeep1234@");
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }
    }
}