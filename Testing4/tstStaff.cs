using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.IO.Pipes;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //create some test data to pass the method
        string Name = "Harvey";
        string Email = "harvey@my365.dmu.ac.uk";
        string Role = "Customer Management";
        string Password = "harvey_123";
        string dateOfBirth = DateTime.Now.AddYears(-20).ToShortDateString();
       
        
        
        
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
            Int32 StaffID = 4;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestStaffIDFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 4;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the StaffID 
            if (AStaff.StaffID != 4)
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
            Int32 StaffID = 4;
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
            Int32 StaffID = 4;
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
            Int32 StaffID = 4;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the StaffID 
            if (AStaff.role != "Customer Management")
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
            Int32 StaffID = 4;
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
            Int32 StaffID = 4;
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
            Int32 StaffID = 4;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the StaffID 
            if (AStaff.DateofBirth != Convert.ToDateTime("10/04/2004"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varuable to store any error message
            String Error = "";
            //invoke the method 
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
 
        }
        [TestMethod]

        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Name = ""; // this should trigger an error
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void NameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Name = "H"; // this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Name = "Ha"; // this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Name = "";
            Name = Name.PadRight(49, 'H');// this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
            [TestMethod]

        public void NameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Name = "";
            Name = Name.PadRight(50, 'a');// this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void NameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Name = "";
            Name = Name.PadRight(25, 'H'); // this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Name = "";
            Name = Name.PadRight(51, 'a'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void NameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Name = "";
            Name = Name.PadRight(1000, 'a'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Email = ""; // this should trigger an error
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Email = "H"; // this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Email = "Ha"; // this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Email = "";
            Email = Email.PadRight(49, 'H');// this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Email = "";
            Email = Email.PadRight(50, 'a');// this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Email = "";
            Email = Email.PadRight(25, 'H'); // this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Email = "";
            Email = Email.PadRight(51, 'a'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Email = "";
            Email = Email.PadRight(1000, 'a'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void RoleMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Role = ""; // this should trigger an error
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void RoleMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Role = "H"; // this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void RoleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Role = "Ha"; // this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void RoleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Role = "";
            Role = Role.PadRight(49, 'H');// this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void RoleMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Role = "";
            Role = Role.PadRight(50, 'a');// this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void RoleMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Role = "";
            Role = Role.PadRight(25, 'H'); // this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void RoleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Role = "";
            Role = Role.PadRight(51, 'a'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void RoleExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Role = "";
            Role = Role.PadRight(1000, 'a'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Password = ""; // this should trigger an error
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void PasswordMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Password = "H"; // this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Password = "Ha"; // this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Password = "";
            Password = Password.PadRight(49, 'H');// this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void PasswordMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Password = "";
            Password = Password.PadRight(50, 'a');// this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void PasswordMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Password = "";
            Password = Password.PadRight(25, 'H'); // this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Password = "";
            Password = Password.PadRight(51, 'a'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void PasswordExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c= variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Password = "";
            Password = Password.PadRight(1000, 'a'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void dateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 200 years
            TestDate = TestDate.AddYears(-200);
            //convert the date variable to a string variable 
            string dateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void dateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 and less one years
            TestDate = TestDate.AddYears(-101);
            //convert the date variable to a string variable 
            string dateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void dateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable 
            string dateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void dateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 and plus one years
            TestDate = TestDate.AddYears(-99);
            //convert the date variable to a string variable 
            string dateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void dateOfBirthMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 18 years less one
            TestDate = TestDate.AddYears(-19);
            //convert the date variable to a string variable 
            string dateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void dateOfBirthMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 18 years ago today
            TestDate = TestDate.AddYears(-18);
            //convert the date variable to a string variable 
            string dateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void dateOfBirthMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is anywhere between 100 and 18 years before
            TestDate = TestDate.AddYears(-80);
            //convert the date variable to a string variable 
            string dateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void dateOfBirthMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 18 years plus one
            TestDate = TestDate.AddYears(-17);
            //convert the date variable to a string variable 
            string dateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void dateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is today
            //TestDate = TestDate.AddYears(-0);
            //convert the date variable to a string variable 
            string dateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Name, Email, Role, Password, dateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
