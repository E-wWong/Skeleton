using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsStaffUser AnUser = new clsStaffUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIDPropertOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property 
            Int32 TestData = 4;
            //assign the data to the property
            AnUser.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserID, TestData);

        }
        [TestMethod]
        public void UserNamePropertOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property 
            string TestData = "Selim";
            //assign the data to the property
            AnUser.Username = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Username, TestData);

        }
        [TestMethod]
        public void PasswordPropertOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property 
            string TestData = "sePassword123";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);

        }
        [TestMethod]
        public void DepartmentPropertOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property 
            string TestData = "Staff Management";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);

        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class that we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string Username = "Selim";
            string Password = "sePassword123";
            //invoke the method 
            Found = AnUser.FindUser(Username, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the class we want to create 
            clsStaffUser AnUser = new clsStaffUser();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string Username = "Selim";
            string Password = "sePassword123";
            //invoke the method
            Found = AnUser.FindUser(Username, Password);
            //check the user id property
            if (AnUser.Username != Username && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
    }
}