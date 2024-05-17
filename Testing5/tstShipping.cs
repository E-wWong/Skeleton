using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing5
{
    [TestClass]
    public class tstShipping
    {

        //good test data
        //create some test data to pass the method
        string shippingID = "7";
        string address = "77 New Street-Ilford-London-IG87 0FS";
        string deliveryType = "Second Class";
        string parcelSize = "Medium";
        string deliveryDate = "20/05/2024";
        string orderID = "8";
      
        //****** CHECK INSTANCE OF CLASS ****************************************************************************************************************************************************************************************

        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //Test to see that it exists
            Assert.IsNotNull(AShipment);
        }

        //****** TESTING IF THE PROPERTY IS OK **********************************************************************************************************************************************************************************

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

        //****** TESTING FIND METHOD IS OK **************************************************************************************************************************************************************************************

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

        //****** TESTING EACH PROPERTY CAN BE FOUND *****************************************************************************************************************************************************************************

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
            if (AShipment.address != "77 New Street-Ilford-London-IG87 0FS")
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
            if (AShipment.deliveryType != "Second Class")
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
            if (AShipment.parcelSize != "Medium")
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
            if (AShipment.deliveryDate != Convert.ToDateTime("20/05/2024"))
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
            if (AShipment.orderID != 8)
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
            if (AShipment.isDispatched != false)
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
            clsShipping AShipment = new clsShipping();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //****** TESTING PARAMETERS OF SHIPPING ID ******************************************************************************************************************************************************************************

        [TestMethod]
        public void ShippingIdExtremeMin()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string shippingID = "-10"; //this should trigger an error
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingIdMinMinusOne()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string shippingID = "0"; //this should trigger an error
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingIdMin()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string shippingID = "1"; //this should be ok
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingIdMinPlusOne()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string shippingID = "2"; //this should be ok
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingIdMaxMinusOne()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string shippingID = "1999999999"; //this should be ok
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingIdMax()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string shippingID = "2000000000"; //this should be ok
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingIdMaxPlusOne()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string shippingID = "2000000001"; //this should be ok
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ShippingIdMid()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string shippingID = "3545"; //this should be ok
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingIdExtremeMax()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string shippingID = "10000000000"; //this should trigger an error
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        //****** TESTING PARAMETERS OF ADDRESS **********************************************************************************************************************************************************************************

        [TestMethod]
        public void AddressMinMinusOne()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string address = ""; //this should trigger an error
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string address = "aaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string address = "aaaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                   //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string address = "";
            address = address.PadRight(159, 'a');//invoke the method
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string address = "";
            address = address.PadRight(160, 'a');//invoke the method
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMid()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string address = "";
            address = address.PadRight(90, 'a');//invoke the method
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string address = "";
            address = address.PadRight(161, 'a');//invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string address = "";
            address = address.PadRight(500, 'a'); //this should be ok
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //****** TESTING PARAMETERS OF DELIVERY TYPE ****************************************************************************************************************************************************************************
        [TestMethod]
        public void deliveryTypeNullOption()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string deliveryType = "";
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //****** TESTING PARAMETERS OF PARCEL SIZE ******************************************************************************************************************************************************************************

        [TestMethod]
        public void parcelSizeNullOption()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string parcelSize = "";
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //****** TESTING PARAMETERS OF DELIVERY DATE ****************************************************************************************************************************************************************************

        [TestMethod]
        public void DeliveryDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date date
            DateTime TestDate;
            //Set the date to the appropriate date
            TestDate = Convert.ToDateTime("31/12/2022");
            //convert the variable into a string variable 
            string deliveryDate = TestDate.ToString();
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryDateMinMinusOne()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date date
            DateTime TestDate;
            //Set the date to the appropriate date
            TestDate = Convert.ToDateTime("31/12/2023");
            //convert the variable into a string variable 
            string deliveryDate = TestDate.ToString();
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryDateMin()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date date
            DateTime TestDate;
            //Set the date to the appropriate date
            TestDate = Convert.ToDateTime("01/01/2024");
            //convert the variable into a string variable 
            string deliveryDate = TestDate.ToString();
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date date
            DateTime TestDate;
            //Set the date to the appropriate date
            TestDate = Convert.ToDateTime("02/01/2024");
            //convert the variable into a string variable 
            string deliveryDate = TestDate.ToString();
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryDateMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date date
            DateTime TestDate;
            //Set the date to the appropriate date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(6);
            //convert the variable into a string variable 
            string deliveryDate = TestDate.ToString();
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryDateMax()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date date
            DateTime TestDate;
            //Set the date to the appropriate date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(7);
            //convert the variable into a string variable 
            string deliveryDate = TestDate.ToString();
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryDateMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date date
            DateTime TestDate;
            //Set the date to the appropriate date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(8);
            //convert the variable into a string variable 
            string deliveryDate = TestDate.ToString();
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryDateMid()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date date
            DateTime TestDate;
            //Set the date to the appropriate date
            TestDate = Convert.ToDateTime("01/01/2024");
            TestDate = TestDate.AddDays(90);
            //convert the variable into a string variable 
            string deliveryDate = TestDate.ToString();
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsShipping AShipment = new clsShipping();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date date
            DateTime TestDate;
            //Set the date to the appropriate date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(14);
            //convert the variable into a string variable 
            string deliveryDate = TestDate.ToString();
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //****** TESTING THE PARAMETERS OF ORDER ID *****************************************************************************************************************************************************************************

        [TestMethod]
        public void OrderIdExtremeMin()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string orderID = "-10"; //this should trigger an error
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMinMinusOne()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string orderID = "0"; //this should trigger an error
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMin()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string orderID = "1"; //this should be ok
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMinPlusOne()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string orderID = "2"; //this should be ok
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMaxMinusOne()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string orderID = "1999999999";
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMax()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string orderID = "2000000000";
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMaxPlusOne()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string orderID = "2000000001";
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderIdMid()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string orderID = "3545";
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdExtremeMax()
        {
            //create an instance of a class we want to create
            clsShipping AShipment = new clsShipping();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string orderID = "10000000000";
            //invoke the method
            Error = AShipment.Valid(shippingID, address, deliveryType, parcelSize, deliveryDate, orderID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        //****** TEMPLATE *******************************************************************************************************************************************************************************************************
        /*
        [TestMethod]
        public void ExtremeMin()
        {

        }

        [TestMethod]
        public void MinMinusOne()
        {

        }

        [TestMethod]
        public void Min()
        {

        }

        [TestMethod]
        public void MinPlusOne()
        {

        }

        [TestMethod]
        public void MaxMinusOne()
        {

        }

        [TestMethod]
        public void Max()
        {

        }

        [TestMethod]
        public void MaxPlusOne()
        {

        }


        [TestMethod]
        public void Mid()
        {

        }

        [TestMethod]
        public void ExtremeMax()
        {

        }
        */
    }
}
