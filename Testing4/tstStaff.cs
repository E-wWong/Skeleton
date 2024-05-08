using ClassLibrary;
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
            AStaff.staffID = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AStaff.staffID, testData);
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
            AStaff.permanentEmployee = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AStaff.permanentEmployee, testData);
        }

        [TestMethod]
        public void dateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assing to the property
            DateTime testData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.dateOfBirth = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AStaff.dateOfBirth, testData);
        }
    }
}
