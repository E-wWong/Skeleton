using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void instanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllEmails = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllEmails);
        }

        [TestMethod]
        public void emailListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.customerID = 10;
            TestItem.name = "test";
            TestItem.email = "testEmail@Email.com";
            TestItem.mobileNum = "07123456789";
            TestItem.password = "password";
            TestItem.accountCreationDate = DateTime.Now;
            TestItem.returningCustomer = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void thisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.customerID = 10;
            TestCustomer.name = "test";
            TestCustomer.email = "testEmail@Email.com";
            TestCustomer.mobileNum = "07123456789";
            TestCustomer.password = "password";
            TestCustomer.accountCreationDate = DateTime.Now;
            TestCustomer.returningCustomer = true;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void listAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.customerID = 10;
            TestItem.name = "test10";
            TestItem.email = "testEmail@Email.com";
            TestItem.mobileNum = "07123456789";
            TestItem.password = "password";
            TestItem.accountCreationDate = DateTime.Now;
            TestItem.returningCustomer = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void addMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.customerID = 10;
            TestItem.name = "test10";
            TestItem.email = "testEmail@Email.com";
            TestItem.mobileNum = "07123456789";
            TestItem.password = "password";
            TestItem.accountCreationDate = DateTime.Now;
            TestItem.returningCustomer = true;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.customerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the 2 values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void updateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.customerID = 10;
            TestItem.name = "test10";
            TestItem.email = "testEmail@Email.com";
            TestItem.mobileNum = "07123456789";
            TestItem.password = "password";
            TestItem.accountCreationDate = DateTime.Now;
            TestItem.returningCustomer = true;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.customerID = PrimaryKey;
            //modify test record
            TestItem.name = "test20";
            TestItem.email = "testEmail2@Email.co.uk";
            TestItem.accountCreationDate = DateTime.Now.AddDays(1);
            TestItem.returningCustomer = false;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see if ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void deleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.customerID = 10;
            TestItem.name = "test10";
            TestItem.email = "testEmail@Email.com";
            TestItem.mobileNum = "07123456789";
            TestItem.password = "password";
            TestItem.accountCreationDate = DateTime.Now;
            TestItem.returningCustomer = true;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.customerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
    }
}
