using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstShippingUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of rge class we want to create
            clsShippingUser aUser = new clsShippingUser();
            //test to see that it exists
            Assert.IsNotNull(aUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsShippingUser aUser = new clsShippingUser();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            aUser.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsShippingUser aUser = new clsShippingUser();
            //create some test data to assign to the property
            string TestData = "Dawn";
            //assign the data to the property
            aUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsShippingUser aUser = new clsShippingUser();
            //create some test data to assign to the property
            string TestData = "password123";
            //assign the data to the property
            aUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsShippingUser aUser = new clsShippingUser();
            //create some test data to assign to the property
            string TestData = "Address Book";
            //assign the data to the property
            aUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsShippingUser aUser = new clsShippingUser();
            //create a Boolean variable to store the results of the validation
            Boolean found = false;
            //create some test data to use with the method
            string userName = "Emily";
            string password = "emPassword123";
            //invoke the method
            found = aUser.FindUser(userName, password);
            //test to see if the result is true
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the class we want to create
            clsShippingUser aUser = new clsShippingUser();
            //create a Boolean variable to store the result of the search
            Boolean found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string userName = "Emily";
            string password = "emPassword123";
            //invoke the method
            found = aUser.FindUser(userName, password);
            //check the user id property
            if (aUser.UserName != userName && aUser.Password != password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
