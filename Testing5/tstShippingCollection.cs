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
    }
}
