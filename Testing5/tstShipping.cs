using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstShipping
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //Test to see that it exists
            Assert.IsNotNull(AShipment);
        }

        [TestMethod]
        public void ShippingIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //create some test data to assign to the property
            int TestData = 3;
            //assign the data to the property
            AShipment.shippingID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AShipment.shippingID, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //create some test data to assign to the property
            string TestData = "416 Highfield Road-Leicester-LE54 0JI";
            //assign the data to the property
            AShipment.address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AShipment.address, TestData);
        }

        [TestMethod]
        public void DeliveryTypePropertyOK()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //create some test data to assign to the property
            string TestData = "Second";
            //assign the data to the property
            AShipment.deliveryType = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AShipment.deliveryType, TestData);
        }

        [TestMethod]
        public void ParcelSizePropertyOK()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //create some test data to assign to the property
            string TestData = "Large";
            //assign the data to the property
            AShipment.parcelSize = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AShipment.parcelSize, TestData);
        }

        [TestMethod]
        public void DeliveryDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AShipment.deliveryDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AShipment.deliveryDate, TestData);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //create some test data to assign to the property
            int TestData = 4;
            //assign the data to the property
            AShipment.orderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AShipment.orderID, TestData);
        }

        [TestMethod]
        public void IsDispatchedPropertyOK()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //create some test data to assign to the property
            bool TestData = false;
            //assign the data to the property
            AShipment.isDispatched = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AShipment.isDispatched, TestData);
        }
    }
}
