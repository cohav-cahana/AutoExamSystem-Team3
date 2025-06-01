using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRO1;

namespace PRO1.Tests
{
    [TestClass]
    public class ValidationTests
    {
        [TestMethod]
        public void ValidUsername_ShouldReturnTrue()
        {
            string username = "abcde1";
            bool result = ValidationHelper.IsValidUsername(username);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvalidUsername_TooShort_ShouldReturnFalse()
        {
            string username = "a1";
            bool result = ValidationHelper.IsValidUsername(username);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidPassword_ShouldReturnTrue()
        {
            string password = "Pass123!";
            bool result = ValidationHelper.IsValidPassword(password);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvalidPassword_MissingSpecialChar_ShouldReturnFalse()
        {
            string password = "Pass1234";
            bool result = ValidationHelper.IsValidPassword(password);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidEmail_ShouldReturnTrue()
        {
            string email = "user@example.com";
            bool result = ValidationHelper.IsValidEmail(email);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvalidID_WrongLength_ShouldReturnFalse()
        {
            string id = "12345678";
            bool result = ValidationHelper.IsValidID(id);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Login_ValidCredentials_ShouldReturnTrue()
        {
            bool result = LoginManager.Authenticate("cohav11", "c123c123!");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Login_InvalidPassword_ShouldReturnFalse()
        {
            bool result = LoginManager.Authenticate("user1", "WrongPass");
            Assert.IsFalse(result);
        }


    }
}

