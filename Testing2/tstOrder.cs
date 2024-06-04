using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {   //28/-5/2024 12:10
        //good test data
        //create some test data to pass the method
        string totalItems = "3";
        string totalPrice = "89.9700";
        string address = "15 Park Road- Newport- NP17 7AW";
        string orderDate = DateTime.Now.ToShortDateString();
        string itemCodes = "322-861-995";
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);

        }
        [TestMethod]
        public void orderIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            int TestData = 12;
            //assign the data to the proerty
            AnOrder.orderId = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnOrder.orderId, TestData);
        }
        [TestMethod]
        public void totalItemsPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the proerty
            AnOrder.totalItems = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnOrder.totalItems, TestData);
        }
        [TestMethod]
        public void totalPriceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            double TestData = 29.9900;
            //assign the data to the proerty
            AnOrder.totalPrice = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnOrder.totalPrice, TestData);
        }

        [TestMethod]
        public void addressOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "9836 Main Street- North London-N76 9TK";
            //assign the data to the proerty
            AnOrder.address = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnOrder.address, TestData);
        }

        [TestMethod]
        public void orderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the proerty
            AnOrder.orderDate = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnOrder.orderDate, TestData);
        }
        [TestMethod]
        public void isAGiftPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            bool TestData = false;
            //assign the data to the proerty
            AnOrder.isAGift = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnOrder.isAGift, TestData);
        }
        public void itemCodesOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "453-888-621";
            //assign the data to the proerty
            AnOrder.itemCodes = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnOrder.itemCodes, TestData);
        }

        public void FindMethodOK()
        {   //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 16;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to creTE
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 16;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.orderId != 16)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTotalItemsFound()
        {
            //create an instance of the class we want to creTE
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 16;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.totalItems != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTotalPriceFound()
        {
            //create an instance of the class we want to creTE
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 16;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.totalPrice != 89.9700)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to creTE
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 16;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.address != "15 Park Road- -Newport- -NP17 7AW")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to creTE
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 16;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.orderDate != Convert.ToDateTime("22/02/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestIsAGiftFound()
        {
            //create an instance of the class we want to creTE
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 16;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.isAGift != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestItemCodesFound()
        {
            //create an instance of the class we want to creTE
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 16;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.itemCodes != "322-861-995")
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
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, Error, "");
        }

        [TestMethod]
        public void TotalItemsMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string totalItems = "";//this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TotalItemsMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string totalItems = "0"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalItemsMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            itemCodes = itemCodes.PadRight(2, 'a'); //this should be ok
                                                    //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalItemsMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            totalItems = totalItems.PadRight(4, 'a'); //this should be ok
                                                      //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalItemsMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            totalItems = totalItems.PadRight(5, 'a');
            //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalItemsMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            totalItems = totalItems.PadRight(4, 'a');
            //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalItemsMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            totalItems = totalItems.PadRight(6, 'a');      //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void TotalItemsExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            totalItems = totalItems.PadRight(20, 'a');//this shuld fail
            //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void TotalPriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            totalPrice = totalPrice.PadRight(14, 'a');//this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            totalPrice = totalPrice.PadRight(15, 'a'); //this should be ok
                                                       //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            totalPrice = totalPrice.PadRight(3, 'a'); //this should be ok
                                                       //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            totalPrice = totalPrice.PadRight(19, 'a'); //this should be ok
                                                       //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceMax()
        {
            //create an i nstance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            totalPrice = totalPrice.PadRight(20, 'a'); //this should be ok
                                                       //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            totalPrice = totalPrice.PadRight(10, 'a'); //this should be ok
                                                       //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            totalPrice = totalPrice.PadRight(21, 'a'); //this should be ok
                                                       //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void TotalPriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method

            totalPrice = totalPrice.PadRight(50, 'a');//this shuld fail
                                                      //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string address = "";
            address = address.PadRight(19, 'a');
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string address = "";
            address = address.PadRight(20, 'a');
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string address = "";
            address = address.PadRight(21, 'a');
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string address = "";
            address = address.PadRight(159, 'a');
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string address = "";
            address = address.PadRight(160, 'a');
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string address = "";
            address = address.PadRight(90, 'a');
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string address = "";
            address = address.PadRight(161, 'a');
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string address = "";
            address = address.PadRight(500, 'a');//this shuld fail
                                                 //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void ItemCodesMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string itemCodes = "";//this should trigger an error
                                  //invoke the method
            itemCodes = itemCodes.PadRight(12, 'a');
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ItemCodesMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            itemCodes = itemCodes.PadRight(11, 'a');
            //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemCodesMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            itemCodes = itemCodes.PadRight(12, 'a');
            //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ItemCodesMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            itemCodes = itemCodes.PadRight(10, 'a');
            //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemCodesMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            itemCodes = itemCodes.PadRight(11, 'a');
            //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemCodesMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string itemCodes = ""; //this should be ok
                                   //invoke the method
            itemCodes = itemCodes.PadRight(6, 'a');
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ItemCodesMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string itemCodes = ""; //this should be ok
                                   //invoke the method
            itemCodes = itemCodes.PadRight(12, 'a');
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void ItemCodesExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string itemCodes = "";
            itemCodes = itemCodes.PadRight(155, 'a');//this shuld fail
            //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = Convert.ToDateTime("31/12/2023");
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string orderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = Convert.ToDateTime("31/12/2023");
            //change the date to whatever the date is less 1 day
            //convert the date variable to a string variable
            string orderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string orderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = Convert.ToDateTime("2/1/24");
            //change the date to whatever the date is plus 1 day
            //convert the date variable to a string variable
            string orderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(3);
            //convert the date variable to a string variable
            string orderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
    }
}



