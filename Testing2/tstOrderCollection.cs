using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanaceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrder);
        }
        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Addan item to the list
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.orderId = 25;
            TestItem.totalItems = 1;
            TestItem.totalPrice = 29.99;
            TestItem.address = "15 Park Road- -Newport- -NP17 7AW";
            TestItem.orderDate = DateTime.Now;
            TestItem.isAGift = true;
            TestItem.itemCodes = "322-861-995";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrder.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.OrderList, TestList);
        }
       
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.orderId = 25;
            TestOrder.totalItems = 1;
            TestOrder.totalPrice = 29.99;
            TestOrder.address = "15 Park Road- -Newport- -NP17 7AW";
            TestOrder.orderDate = DateTime.Now;
            TestOrder.isAGift = true;
            TestOrder.itemCodes = "322-861-995";
            //assign the data to the property
            AllOrder.ThisOrder = TestOrder;
            //test to see that the twovalues are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an Item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.orderId = 25;
            TestItem.totalItems = 1;
            TestItem.totalPrice = 29.99;
            TestItem.address = "15 Park Road- -Newport- -NP17 7AW";
            TestItem.orderDate = DateTime.Now;
            TestItem.isAGift = true;
            TestItem.itemCodes = "322-861-995";
            //add the itemto the test list 
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrder.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.Count, TestList.Count);
        }
   
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.orderId = 25;
            TestItem.totalItems = 1;
            TestItem.totalPrice = 29.99;
            TestItem.address = "15 Park Road- -Newport- -NP17 7AW";
            TestItem.orderDate = DateTime.Now;
            TestItem.isAGift = true;
            TestItem.itemCodes = "322-861-995";
            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.orderId = PrimaryKey;
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);

        }
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.orderId = 25;
            TestItem.totalItems = 1;
            TestItem.totalPrice = 29.99;
            TestItem.address = "15 Park Road- -Newport- -NP17 7AW";
            TestItem.orderDate = DateTime.Now;
            TestItem.isAGift = true;
            TestItem.itemCodes = "322-861-995";
            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.orderId= PrimaryKey;
            //modify the test record
            TestItem.orderId = 99;
            TestItem.totalItems = 6;
            TestItem.totalPrice = 100;
            TestItem.address = "72 Captain Street- -ATL- -M17 2DD";
            TestItem.orderDate = DateTime.Now;
            TestItem.isAGift = true;
            TestItem.itemCodes = "722-223-556";
            //set the record based on the new test data
            AllOrder.ThisOrder= TestItem;
            //update the record
            AllOrder.Update();
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see if ThisOrder matches the test data
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of test daa
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.orderId = 25;
            TestItem.totalItems = 1;
            TestItem.totalPrice = 29.99;
            TestItem.address = "15 Park Road- -Newport- -NP17 7AW";
            TestItem.orderDate = DateTime.Now;
            TestItem.isAGift = true;
            TestItem.itemCodes = "322-861-995";
            //set ThisOrder to the test data
            AllOrder.ThisOrder= TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.orderId = PrimaryKey;
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrder.Delete();
            //now find the record
            Boolean Found = AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse( Found );
        }
        [TestMethod]
        public void ReportByItemCodesMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsOrderCollection AllOrder= new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            //apply a blank string (should return all record)
            FilteredOrder.ReportByItemCodes("");
            //test to see tthat the two values are the same
            Assert.AreEqual(AllOrder.Count, FilteredOrder.Count);
        }
        [TestMethod]
        public void ReportByItemCodesNoneFound()
        {
            //create an instance of the class we want to create
            clsOrderCollection FilteredOrder= new clsOrderCollection();
            //apply a itemcodes that dosent exist
            FilteredOrder.ReportByItemCodes("xxx-xxx");
            //test to see that there are no record
            Assert.AreEqual(0, FilteredOrder.Count );
        }
        [TestMethod]
        public void ReportByItemCodesDataFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a item code that dosent exist
            FilteredOrder.ReportByItemCodes("yyy-yyy");
            //check that the correct number of records are found
            if (FilteredOrder.Count == 2)
            {
                //check to see hat the first record is 25
                if (FilteredOrder.OrderList[0].orderId != 25)
                {
                    OK = false;
                }
                //check to see that the first record is 26
                if (FilteredOrder.OrderList[1].orderId != 26)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no record
            Assert.IsTrue(OK);
        }


    }
}
