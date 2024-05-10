using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void instanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        //************************************************************************************************************

        [TestMethod]
        public void customerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assing to the property
            int testData = 123;
            //assign the data to the property
            ACustomer.customerID = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(ACustomer.customerID, testData);
        }

        [TestMethod]
        public void namePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assing to the property
            string testData = "Barry Smith";
            //assign the data to the property
            ACustomer.name = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(ACustomer.name, testData);
        }

        [TestMethod]
        public void emailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assing to the property
            string testData = "email123@email.com";
            //assign the data to the property
            ACustomer.email = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(ACustomer.email, testData);
        }

        [TestMethod]
        public void mobileNumPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assing to the property
            long testData = 07123456789;
            //assign the data to the property
            ACustomer.mobileNum = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(ACustomer.mobileNum, testData);
        }

        [TestMethod]
        public void mobileNumNullPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assing to the property
            long testData = 0;
            //assign the data to the property
            ACustomer.mobileNum = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(ACustomer.mobileNum, testData);
        }

        [TestMethod]
        public void passwordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assing to the property
            string testData = "password1234";
            //assign the data to the property
            ACustomer.password = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(ACustomer.password, testData);
        }

        [TestMethod]
        public void accountCreationDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assing to the property
            DateTime testData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.accountCreationDate = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(ACustomer.accountCreationDate, testData);
        }

        [TestMethod]
        public void returningCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assing to the property
            Boolean testData = true;
            //assign the data to the property
            ACustomer.returningCustomer = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(ACustomer.returningCustomer, testData);
        }

        //************************************************************************************************************

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 customerID = 12;
            //invoke the method
            Found = ACustomer.Find(customerID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        //************************************************************************************************************

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean value to record if the data is ok (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 12;
            //invoke the method
            Found = ACustomer.Find(customerID);
            //check the address ID
            if (ACustomer.customerID != 12)
                OK = false;
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean value to record if the data is ok (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 12;
            //invoke the method
            Found = ACustomer.Find(customerID);
            //check the address ID
            if (ACustomer.name != "testName")
                OK = false;
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean value to record if the data is ok (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 12;
            //invoke the method
            Found = ACustomer.Find(customerID);
            //check the address ID
            if (ACustomer.email != "testEmail")
                OK = false;
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMobileNumFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean value to record if the data is ok (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 12;
            //invoke the method
            Found = ACustomer.Find(customerID);
            //check the address ID
            if (ACustomer.mobileNum != 0123456789)
                OK = false;
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean value to record if the data is ok (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 12;
            //invoke the method
            Found = ACustomer.Find(customerID);
            //check the address ID
            if (ACustomer.password != "testPassword")
                OK = false;
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAccountCreationDateFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean value to record if the data is ok (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 12;
            //invoke the method
            Found = ACustomer.Find(customerID);
            //check the address ID
            if (ACustomer.accountCreationDate != Convert.ToDateTime("25/12/2024"))
                OK = false;
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReturningCustomerFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean value to record if the data is ok (assume that it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 12;
            //invoke the method
            Found = ACustomer.Find(customerID);
            //check the address ID
            if (ACustomer.returningCustomer != true)
                OK = false;
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
