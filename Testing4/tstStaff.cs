﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see if it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void staffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assing to the property
            int testData = 123;
            //assign the data to the property
            AStaff.StaffID = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AStaff.StaffID, testData);
        }

        [TestMethod]
        public void namePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assing to the property
            string testData = "Bobby";
            //assign the data to the property
            AStaff.name = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AStaff.name, testData);
        }

        [TestMethod]
        public void emailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assing to the property
            string testData = "email@email.com";
            //assign the data to the property
            AStaff.email = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AStaff.email, testData);
        }

        [TestMethod]
        public void rolePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assing to the property
            string testData = "general manager";
            //assign the data to the property
            AStaff.role = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AStaff.role, testData);
        }

        [TestMethod]
        public void passwordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assing to the property
            string testData = "password123";
            //assign the data to the property
            AStaff.password = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AStaff.password, testData);
        }

        [TestMethod]
        public void permanentEmployeePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assing to the property
            bool testData = true;
            //assign the data to the property
            AStaff.PermanentEmployee = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AStaff.PermanentEmployee, testData);
        }

        [TestMethod]
        public void dateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assing to the property
            DateTime testData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DateofBirth = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AStaff.DateofBirth, testData);
        }

        [TestMethod]

        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 2717647;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //test to see if the result is true
            Assert.IsTrue( Found );
        }

        [TestMethod]    

        public void TestStaffIDFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found=false;
            //create a Boolean variable to record if the data is OK(assume it is)
            Boolean OK=true;
            //create some test data to use with the method
            Int32 StaffID = 2717647;
            //invoke the method
            Found=AStaff.Find(StaffID);
            //check the StaffID 
            if (AStaff.StaffID != 2717647)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]

        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2717647;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the StaffID 
            if (AStaff.name != "Harvey")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]

        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2717647;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the StaffID 
            if (AStaff.email != "harvey@my365.dmu.ac.uk")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]

        public void TestRoleFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2717647;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the StaffID 
            if (AStaff.role != "Customer Manager")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]

        public void TestPasswordFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2717647;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the StaffID 
            if (AStaff.password != "harvey_123")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]

        public void TestPermanentEmployeeFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2717647;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the StaffID 
            if (AStaff.PermanentEmployee != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]

        public void TestDateofBirthFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2717647;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the StaffID 
            if (AStaff.DateofBirth != Convert.ToDateTime("16/06/2004"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
    }
}
