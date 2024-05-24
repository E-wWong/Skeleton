using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Testing5
{
    [TestClass]
    public class tstShippingCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsShippingCollection AllShipments = new clsShippingCollection();
            //test to see that it exists
            Assert.IsNotNull(AllShipments);
        }

        [TestMethod]
        public void ShippingListOK()
        {
            //dreate an instance of the class we want to create
            clsShippingCollection AllShipments = new clsShippingCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsShipping> TestList = new List<clsShipping>();
            //add an item to the list
            //create the item of test data
            clsShipping TestItem = new clsShipping();
            //Set its properties
            TestItem.shippingID = 4;
            TestItem.address = "77 New Street-Ilford-London-IG87 0FS";
            TestItem.deliveryType = "Second Class";
            TestItem.parcelSize = "Medium";
            TestItem.deliveryDate = Convert.ToDateTime("20/05/2024");
            TestItem.orderID = 8;
            TestItem.isDispatched = false;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllShipments.ShipmentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllShipments.ShipmentList, TestList);
        }

        [TestMethod]
        public void ThisShipmentpropertyOK()
        {
            //create an instance of the class we want to create
            clsShippingCollection AllShipments = new clsShippingCollection();
            //create some test data to asign to the property
            clsShipping TestShipment = new clsShipping();
            //set the properties of the test object
            TestShipment.shippingID = 4;
            TestShipment.address = "77 New Street-Ilford-London-IG87 0FS";
            TestShipment.deliveryType = "Second Class";
            TestShipment.parcelSize = "Medium";
            TestShipment.deliveryDate = Convert.ToDateTime("20/05/2024");
            TestShipment.orderID = 8;
            TestShipment.isDispatched = false;
            //assign the data to the property
            AllShipments.ThisShipment = TestShipment;
            //test to see that the two values are the same
            Assert.AreEqual(AllShipments.ThisShipment, TestShipment);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsShippingCollection AllShipments = new clsShippingCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsShipping> TestList = new List<clsShipping>();
            //Add an Item to the list
            //create the item of test data
            clsShipping TestItem = new clsShipping();
            //set its properties
            TestItem.shippingID = 4;
            TestItem.address = "77 New Street-Ilford-London-IG87 0FS";
            TestItem.deliveryType = "Second Class";
            TestItem.parcelSize = "Medium";
            TestItem.deliveryDate = Convert.ToDateTime("20/05/2024");
            TestItem.orderID = 8;
            TestItem.isDispatched = false;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllShipments.ShipmentList = TestList;
            //test to see that the two equal values are the same
            Assert.AreEqual(AllShipments.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsShippingCollection allShipments = new clsShippingCollection();
            //create the item of test data
            clsShipping TestItem = new clsShipping();
            //variable to store the primary key
            Int32 primaryKey = 0;
            //set ts properties
            TestItem.shippingID = 6;
            TestItem.address = "134 Church Way- -Bradford-Yorkshire-BD6 6JR";
            TestItem.deliveryType = "S e c o n d c l";
            TestItem.parcelSize = "Large";
            TestItem.deliveryDate = Convert.ToDateTime("24/05/2024");
            TestItem.orderID = 14;
            TestItem.isDispatched = true;
            //set ThisShipment to the test data
            allShipments.ThisShipment = TestItem;
            //add the record
            primaryKey = allShipments.Add();
            //set the primary key of the test data
            TestItem.shippingID = primaryKey;
            //find the record
            allShipments.ThisShipment.Find(primaryKey);
            //test to se that the two values are the same
            Assert.AreEqual(allShipments.ThisShipment, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an intstance of a class we want to create
            clsShippingCollection allShipments = new clsShippingCollection();
            //create the item of test data
            clsShipping TestItem = new clsShipping();
            //variale to store the primary key
            Int32 primaryKey = 0;
            //set the properties 
            TestItem.shippingID = 6;
            TestItem.address = "134 Church Way- -Bradford-Yorkshire-BD6 6JR";
            TestItem.deliveryType = "S e c o n d c l";
            TestItem.parcelSize = "Large";
            TestItem.deliveryDate = Convert.ToDateTime("24/05/2024");
            TestItem.orderID = 14;
            TestItem.isDispatched = true;
            //set ThisShipping to the test data
            allShipments.ThisShipment = TestItem;
            //add the record
            primaryKey = allShipments.Add();
            ///set the primary key of the test data 
            TestItem.shippingID = primaryKey;
            //modify the test record
            TestItem.shippingID = 6;
            TestItem.address = "134 Different Street- -Bradford-Yorkshire-BD6 6JR";
            TestItem.deliveryType = "Tracked";
            TestItem.parcelSize = "Medium";
            TestItem.deliveryDate = Convert.ToDateTime("24/05/2024");
            TestItem.orderID = 14;
            TestItem.isDispatched = false;
            //set the record based on the new test data
            allShipments.ThisShipment = TestItem;
            //update the record
            allShipments.Update();
            //find the record
            allShipments.ThisShipment.Find(primaryKey);
            //test to see if ThisShipment matches the test data
            Assert.AreEqual(allShipments.ThisShipment, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsShippingCollection allShipments = new clsShippingCollection();
            //create the item of test data
            clsShipping TestItem = new clsShipping();
            //variable to store the primary key
            Int32 primaryKey = 0;
            //set it's properties
            TestItem.shippingID = 6;
            TestItem.address = "134 Church Way- -Bradford-Yorkshire-BD6 6JR";
            TestItem.deliveryType = "S e c o n d c l";
            TestItem.parcelSize = "Large";
            TestItem.deliveryDate = Convert.ToDateTime("24/05/2024");
            TestItem.orderID = 14;
            TestItem.isDispatched = true;
            //set ThisShipping to the test data 
            allShipments.ThisShipment = TestItem;
            //add the record
            primaryKey = allShipments.Add();
            //set the primary key of the test data
            TestItem.shippingID = primaryKey;
            //find the record
            allShipments.ThisShipment.Find(primaryKey);
            //delete the record
            allShipments.Delete();
            //now find the record
            Boolean Found = allShipments.ThisShipment.Find(primaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByAddressMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsShippingCollection AllShipments = new clsShippingCollection();
            //create an instance of the filtered data
            clsShippingCollection FilteredShipments = new clsShippingCollection();
            //apply a blank string (should return all records)
            FilteredShipments.ReportByAddress("");
            //test o see that the two values are the sam
            Assert.AreEqual(AllShipments.Count, FilteredShipments.Count);
        }

        [TestMethod]
        public void ReportByAddressNoneFound()
        {
            //create an instance of the class we want t create
            clsShippingCollection FilteredShipments = new clsShippingCollection();
            //apply a shippingID that doen't exist
            FilteredShipments.ReportByAddress("xxxxxxxxxxxx- -xxxx- -xxxxxxxxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(2, FilteredShipments.Count);
        }

        [TestMethod]
        public void ReportByAddressTestDataFound()
        {
            //create an instance of the filtered data
            clsShippingCollection FilteredShipments = new clsShippingCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply an address that doesn't exist
            FilteredShipments.ReportByAddress("xxxxxxxxxxxx- -xxxx- -xxxxxxxxxxxxx");
            //check that the correct number of records are dound
            if (FilteredShipments.Count == 2)
            {
                //check to see that the first record is 25
                if (FilteredShipments.ShipmentList[0].shippingID != 31)
                {
                    OK = false;
                }
                //check to see that the first record is 26
                if (FilteredShipments.ShipmentList[1].shippingID != 32) 
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
