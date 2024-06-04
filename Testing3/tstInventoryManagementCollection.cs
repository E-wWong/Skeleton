using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Testing3
{
    [TestClass]
    public class tstInventoryManagementCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsInventoryManagementCollection AllInventories = new clsInventoryManagementCollection();
            //test to see that it exists
            Assert.IsNotNull(AllInventories);
        }

        [TestMethod]
        public void InventoryListOK()
        {
            //create an instance of the class we want to create 
            clsInventoryManagementCollection AllInventories = new clsInventoryManagementCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsInventoryManagement> TestList = new List<clsInventoryManagement>();
            //add an itrem of test data 
            //create the item of test data
            clsInventoryManagement TestItem =  new clsInventoryManagement();
            //set its properties
            TestItem.itemID = 10;
            TestItem.itemName = "pokemon";
            TestItem.itemPrice = 20.0000;
            TestItem.quantity = 20;
            TestItem.size = "medium";
            TestItem.lastStockDelivery = DateTime.Now;
            TestItem.availability = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllInventories.InventoryList = TestList;
            //test to sewe that the two values are the same
            Assert.AreEqual(AllInventories.InventoryList, TestList);
        }

        [TestMethod]
        public void ThisInventoryPropertyOK()
        {
            //create an instance of ther class we want to create
            clsInventoryManagementCollection AllInventories = new clsInventoryManagementCollection();
            //create some tests data to assign to the property
            clsInventoryManagement TestAddress = new clsInventoryManagement();
            //set the properties of the test object
            TestAddress.itemID = 10;
            TestAddress.itemName = "pokemon";
            TestAddress.itemPrice = 20.0000;
            TestAddress.quantity = 20;
            TestAddress.size = "medium";
            TestAddress.lastStockDelivery = DateTime.Now;
            TestAddress.availability = true;
            //assign the data to the property
            AllInventories.ThisInventory = TestAddress;
            //test to sewe that the two values are the same
            Assert.AreEqual(AllInventories.ThisInventory, TestAddress);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create 
            clsInventoryManagementCollection AllInventories = new clsInventoryManagementCollection();
            //create some tests data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsInventoryManagement> TestList = new List<clsInventoryManagement>();
            //add an item to the list
            //create the item of the test data
            clsInventoryManagement TestItem = new clsInventoryManagement();
            //set its properties
            TestItem.itemID = 10;
            TestItem.itemName = "pokemon";
            TestItem.itemPrice = 20.0000;
            TestItem.quantity = 20;
            TestItem.size = "medium";
            TestItem.lastStockDelivery = DateTime.Now;
            TestItem.availability = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllInventories.InventoryList = TestList;
            //test to sewe that the two values are the same
            Assert.AreEqual(AllInventories.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsInventoryManagementCollection AllInventories = new clsInventoryManagementCollection();
            //create the item of test data
            clsInventoryManagement TestItem = new clsInventoryManagement();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.itemID = 10;
            TestItem.itemName = "pokemon";
            TestItem.itemPrice = 20.0000;
            TestItem.quantity = 20;
            TestItem.size = "medium";
            TestItem.lastStockDelivery = DateTime.Now;
            TestItem.availability = true;
            //set this inventory to the test data
            AllInventories.ThisInventory = TestItem;
            //ass the record
            PrimaryKey = AllInventories.Add();
            //set the primary key of the test data
            TestItem.itemID = PrimaryKey;
            //find the record
            AllInventories.ThisInventory.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllInventories.ThisInventory, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsInventoryManagementCollection AllInventories = new clsInventoryManagementCollection();
            //create the item of test data
            clsInventoryManagement TestItem = new clsInventoryManagement();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.itemName = "pokemon";
            TestItem.itemPrice = 20.0000;
            TestItem.quantity = 20;
            TestItem.size = "medium";
            TestItem.lastStockDelivery = DateTime.Now;
            TestItem.availability = true;
            //set ThisInventory to the test data
            AllInventories.ThisInventory = TestItem;
            //add the record
            PrimaryKey = AllInventories.Add();
            //set the primary key of the test data
            TestItem.itemID = PrimaryKey;
            //modify the test records 
            TestItem.itemName = "yu-gi-oh";
            TestItem.itemPrice = 15.0000;
            TestItem.quantity = 32;
            TestItem.size = "small";
            TestItem.lastStockDelivery = DateTime.Now;
            TestItem.availability = false;
            //update the record 
            AllInventories.Update();
            //find the record
            AllInventories.ThisInventory.Find(PrimaryKey);
            //test to see if the test data
            Assert.AreEqual(AllInventories.ThisInventory, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsInventoryManagementCollection AllInventories = new clsInventoryManagementCollection();
            //create the item of test data
            clsInventoryManagement TestItem = new clsInventoryManagement();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.itemName = "pokemon";
            TestItem.itemPrice = 20.0000;
            TestItem.quantity = 20;
            TestItem.size = "medium";
            TestItem.lastStockDelivery = DateTime.Now;
            TestItem.availability = true;
            //set thisInventory to the test data
            AllInventories.ThisInventory = TestItem;
            //add the record
            PrimaryKey = AllInventories.Add();
            //set the primary key of the test data
            TestItem.itemID = PrimaryKey;
            //find the record
            AllInventories.ThisInventory.Find(PrimaryKey);
            //delete the record
            AllInventories.Delete();
            //now find the record
            Boolean Found = AllInventories.ThisInventory.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByitemNameMethodOK()
        {
            //create an instance of all the classcontaining unfiltered results
            clsInventoryManagementCollection AllInventories = new clsInventoryManagementCollection();
            //create an instance of thge filtered data
            clsInventoryManagementCollection FilteredInventory = new clsInventoryManagementCollection();
            //apply a blank string (should return all the records);
            FilteredInventory.ReportByitemName("");
            //test to see that all the two values are the same 
            Assert.AreEqual(AllInventories.Count, FilteredInventory.Count);
        }

        [TestMethod]
        public void ReportByitemNameNoneFound()
        {
        //create an instance of the class we want to create
        clsInventoryManagementCollection FilteredInventory = new clsInventoryManagementCollection();
            //apply a post code code that doesn't exist
            FilteredInventory.ReportByitemName("xxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredInventory.Count);
        }

        [TestMethod]
        public void ReportByitemNameDataFound()
        {
            //create an Instance of the filtered data
            clsInventoryManagementCollection FilteredInventory = new clsInventoryManagementCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredInventory.ReportByitemName("digimon");
            //check the the correct number of records are founds
            if (FilteredInventory.Count == 2)
            {
                //check to see that the first record is 1040
                if (FilteredInventory.InventoryList[0].itemID != 1040)
                {
                    OK = false;
                }
                //check to see that the first record id 1042
                if (FilteredInventory.InventoryList[1].itemID != 1042)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

    }
}
