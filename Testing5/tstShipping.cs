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
        
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //create a boolean variable to store the results of the validation
            Boolean found = false;
            //create some test data to use with the method
            Int32 ShippingID = 4;
            //invoke the method
            found = AShipment.Find(ShippingID);
            //test to see if the result is true
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestShippingIDFound()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShippingID = 4;
            //invoke the method
            found = AShipment.Find(ShippingID);
            if (AShipment.shippingID != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShippingID = 4;
            //invoke the method
            found = AShipment.Find(ShippingID);
            if (AShipment.address != "416 Highfield Road-Leicester-LE54 0JI")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryTypeFound()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShippingID = 4;
            //invoke the method
            found = AShipment.Find(ShippingID);
            if (AShipment.deliveryType != "First")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestParcelSizeFound()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShippingID = 4;
            //invoke the method
            found = AShipment.Find(ShippingID);
            if (AShipment.parcelSize != "Small")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestdeliveryDateFound()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShippingID = 4;
            //invoke the method
            found = AShipment.Find(ShippingID);
            if (AShipment.deliveryDate != Convert.ToDateTime("15/05/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShippingID = 4;
            //invoke the method
            found = AShipment.Find(ShippingID);
            if (AShipment.orderID != 7)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsDispatchedFound()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShippingID = 4;
            //invoke the method
            found = AShipment.Find(ShippingID);
            if (AShipment.isDispatched != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
