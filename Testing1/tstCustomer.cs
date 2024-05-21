using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {

        //good test data
        //create some test data to pass the method
        string CustomerID = "4";
        string Name = "testName";
        string Email = "testEmail";
        string MobileNum = "testMobileNum";
        string Password = "testPassword";
        string AccountCreationDate = DateTime.Now.ToShortDateString();
        string ReturningCustomer = "1";

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
            string testData = "07123456789";
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
            string testData = "0";
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
            Int32 customerID = 3;
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
            Int32 customerID = 3;
            //invoke the method
            Found = ACustomer.Find(customerID);
            //check the address ID
            if (ACustomer.customerID != 3)
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
            Int32 customerID = 3;
            //invoke the method
            Found = ACustomer.Find(customerID);
            //check the address ID
            if (ACustomer.name != "bob brown")
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
            Int32 customerID = 3;
            //invoke the method
            Found = ACustomer.Find(customerID);
            //check the address ID
            if (ACustomer.email != "email@email.org")
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
            Int32 customerID = 3;
            //invoke the method
            Found = ACustomer.Find(customerID);
            //check the address ID
            if (ACustomer.mobileNum != "02345678901")
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
            Int32 customerID = 3;
            //invoke the method
            Found = ACustomer.Find(customerID);
            //check the address ID
            if (ACustomer.password != "password")
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
            Int32 customerID = 3;
            //invoke the method
            Found = ACustomer.Find(customerID);
            //check the address ID
            if (ACustomer.accountCreationDate != Convert.ToDateTime("23/05/2023"))
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
            Int32 customerID = 3;
            //invoke the method
            Found = ACustomer.Find(customerID);
            //check the address ID
            if (ACustomer.returningCustomer != false)
                OK = false;
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //************************************************************************************************************

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any erorr message
            string Error = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }

        //************************************************************************************************************

        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string CustomerID = "0";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string CustomerID = "1";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string CustomerID = "2";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string CustomerID = "1999999999";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string CustomerID = "2000000000";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string CustomerID = "2000000001";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string CustomerID = "1000000000";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string CustomerID = "500000000000";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        //************************************************************************************************************

        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Name = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Name = "a";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Name = "aa";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Name = "";
            Name = Name.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Name = "";
            Name = Name.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Name = "";
            Name = Name.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Name = "";
            Name = Name.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Name = "";
            Name = Name.PadRight(100, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //************************************************************************************************************

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "a";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aa";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "";
            Email = Email.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "";
            Email = Email.PadRight(100, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //************************************************************************************************************

        [TestMethod]
        public void MobileNumMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string MobileNum = "";
            MobileNum = MobileNum.PadRight(19, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MobileNumMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string MobileNum = "";
            MobileNum = MobileNum.PadRight(20, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MobileNumMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string MobileNum = "";
            MobileNum = MobileNum.PadRight(21, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MobileNumMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string MobileNum = "";
            MobileNum = MobileNum.PadRight(10, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MobileNumExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string MobileNum = "";
            MobileNum = MobileNum.PadRight(100, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //************************************************************************************************************

        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Password = "aaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = "aaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = "aaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = "";
            Password = Password.PadRight(99, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = "";
            Password = Password.PadRight(100, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Password = "";
            Password = Password.PadRight(101, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = "";
            Password = Password.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Password = "";
            Password = Password.PadRight(200, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //************************************************************************************************************

        [TestMethod]
        public void AccountCreationDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to 01/01/2024
            //this should fail
            TestDate = Convert.ToDateTime("01/01/2024");
            //change the date to 1 day before 01/01/2024
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string AccountCreationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //set the date to 01/01/2024
            //this should pass
            TestDate = Convert.ToDateTime("01/01/2024");
            //convert the date variable to a string variable
            string AccountCreationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //set the date to 01/01/2024
            //this should pass
            TestDate = Convert.ToDateTime("01/01/2024");
            //change the date to 1 day after 01/01/2024
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string AccountCreationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is, less 1 day
            //this should pass
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string AccountCreationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            //this should pass
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string AccountCreationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is, plus 1 day
            //this should fail
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string AccountCreationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /*
        [TestMethod]
        public void AccountCreationDateMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //create a variable to store the companys start date
            DateTime StartDate;
            //set the date to 01/01/2024
            StartDate = Convert.ToDateTime("01/01/2024");
            //change the date to whatever the date is, between today and 01/01/2024
            //this should fail
            TestDate = (StartDate + DateTime.Now.Date) / 2;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        */
        [TestMethod]
        public void AccountCreationDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is, less 100 years
            //this should fail
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string AccountCreationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AccountCreationExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is, plus 100 years
            //this should fail
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string AccountCreationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerID, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
