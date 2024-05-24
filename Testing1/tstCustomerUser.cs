using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq.Expressions;

namespace Testing1
{
    [TestClass]
    public class tstCustomerUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AUser = new clsCustomerUser();
            //test to see that it exists
            Assert.IsNotNull(AUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AUser = new clsCustomerUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AUser.UserID = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "username";
            //assign the data to the property
            AUser.UserName = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "password";
            //assign the data to the property
            AUser.Password = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "department";
            //assign the data to the property
            AUser.Department = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AUser = new clsCustomerUser();
            //create a boolean to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string Username = "Harvey";
            string Password = "haPassword123";
            //invoke the method
            Found = AUser.FindUser(Username, Password);
            //test to see that the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the class we want to create
            clsCustomerUser AUser = new clsCustomerUser();
            //create a boolean to store the results of the search
            Boolean Found = false;
            //create a boolean to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            string Username = "Harvey";
            string Password = "haPassword123";
            //invoke the method
            Found = AUser.FindUser(Username, Password);
            //check the UserID property
            if (AUser.UserName != Username && AUser.Password != Password) 
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
