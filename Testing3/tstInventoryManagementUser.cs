﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstInventoryManagementUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsInventoryManagementUser AnUser = new clsInventoryManagementUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsInventoryManagementUser AnUser = new clsInventoryManagementUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property 
            AnUser.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsInventoryManagementUser AnUser = new clsInventoryManagementUser();
            //create some test data to assign to the property
            string TestData = "Kelly";
            //assign the data to assign to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsInventoryManagementUser AnUser = new clsInventoryManagementUser();
            //create some test data to assign to the property
            string TestData = "kePassword123";
            //assign the data to assign to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsInventoryManagementUser AnUser = new clsInventoryManagementUser();
            //create some test data to assign to the property
            string TestData = "Inventory Book";
            //assign the data to assign to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create 
            clsInventoryManagementUser AnUser = new clsInventoryManagementUser();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "Kelly";
            string Password = "kePassword123";
            //invoke method
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the class we want to create 
            clsInventoryManagementUser AnUser = new clsInventoryManagementUser();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean varibale to record if the data is OK (Assume is it)
            Boolean OK = true;
            //create some test data to use with the method
            string UserName = "Kelly";
            string Password = "kePassword123";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //check the user id property
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
