using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Testing4
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection(); 
            //test to see that is exist
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the List
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.PermanentEmployee = true;
            TestItem.StaffID = 4;
            TestItem.DateofBirth = DateTime.Now;
            TestItem.name = "Selim";
            TestItem.email = "selim@my365.dmu.ac.uk";
            TestItem.role = "Staff Management";
            TestItem.password = "selim_123";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class that we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the new object
            TestStaff.PermanentEmployee = true;
            TestStaff.StaffID = 4;
            TestStaff.DateofBirth = DateTime.Now;
            TestStaff.name = "Selim";
            TestStaff.email = "selim@my365.dmu.ac.uk";
            TestStaff.role = "Staff Management";
            TestStaff.password = "selim_123";
            //assign the data to property 
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the list
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.PermanentEmployee = true;
            TestItem.StaffID = 4;
            TestItem.DateofBirth = DateTime.Now;
            TestItem.name = "Selim";
            TestItem.email = "selim@my365.dmu.ac.uk";
            TestItem.role = "Staff Management";
            TestItem.password = "selim_123";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection Staffs = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PermanentEmployee = true;
            TestItem.StaffID = 4;
            TestItem.DateofBirth = DateTime.Now;
            TestItem.name = "Selim";
            TestItem.email = "selim@my365.dmu.ac.uk";
            TestItem.role = "Staff Management";
            TestItem.password = "selim_123";
            //set ThisStaff to the test data
            Staffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = Staffs.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //test to see that the two values are the same
            Assert.AreEqual(Staffs.ThisStaff, TestItem);



        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection Staffs = new clsStaffCollection();
            //create an item of the test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PermanentEmployee = true;
            TestItem.DateofBirth = DateTime.Now;
            TestItem.name = "Selim";
            TestItem.email = "selim@my365.dmu.ac.uk";
            TestItem.role = "Staff Management";
            TestItem.password = "selim_123";
            //set thisstaff to the test data
            Staffs.ThisStaff = TestItem;
            //add therecord 
            PrimaryKey = Staffs.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //modify the test record
            TestItem.PermanentEmployee = false;
            TestItem.DateofBirth = DateTime.Now;
            TestItem.name = "Miles";
            TestItem.email = "miles@my365.dmu.ac.uk";
            TestItem.role = "Staff";
            TestItem.password = "miles_123";
            //set the record based on the new test data
            Staffs.ThisStaff = TestItem;
            //update the record 
            Staffs.Update();
            //find the record
            Staffs.ThisStaff.Find(PrimaryKey);
            //test to see if  thisstaff matches the test data
            Assert.AreEqual(Staffs.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection Staffs =  new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PermanentEmployee = true;
            TestItem.DateofBirth = DateTime.Now;
            TestItem.name = "Selim";
            TestItem.email = "selim@my365.dmu.ac.uk";
            TestItem.role = "Staff Management";
            TestItem.password = "selim_123";
            //set ThisStaff to the test data
            Staffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = Staffs.Add();
            //set he primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            Staffs.ThisStaff.Find(PrimaryKey);
            //delete the record
            Staffs.Delete();
            //now find the record
            Boolean Found = Staffs.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse( Found );


        }
        [TestMethod]
        public void ReportByRoleMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection Staffs = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a blank string (should return all records);
            FilteredStaffs.ReportByRole("");
            //test to see that the two values are the same
            Assert.AreEqual(Staffs.Count, FilteredStaffs.Count);
        }
        [TestMethod]
        public void ReportByRoleNoneFound()
        {
            //create an instance of the class we want to create
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a role that doesn't exist
            FilteredStaffs.ReportByRole("Cooking Manager");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaffs.Count );

        }
        [TestMethod]
        public void ReportByRoleTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //variable to store 
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredStaffs.ReportByRole("Council Officer");
            //check that the correct number of records are found
            if(FilteredStaffs.Count == 2)
            {
                //check to see that the first record is 60
                if (FilteredStaffs.StaffList[0].StaffID != 60)
                {
                    OK = false;
                }
                //check to see that the first record is 61
                if (FilteredStaffs.StaffList[1].StaffID != 61)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records 
            Assert.IsTrue( OK );
        }

    }

}







