using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstInventoryManagement
    {

        string itemID = "10";
        string ItemName = "pokemon";
        string ItemPrice = "20.0000";
        string Quantity = "20";
        string Size = "Medium";
        string LastStockDelivery = DateTime.Now.ToShortDateString();
        string Availability = "1";

        [TestMethod]
        public void TestMethod1()
        {
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            Assert.IsNotNull( AnInventory );

        }

        [TestMethod]
        public void itemIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //create some test data to assing to the property
            int testData = 10;
            //assign the data to the property
            AnInventory.itemID = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnInventory.itemID, testData);
        }

        [TestMethod]
        public void itemNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //create some test data to assing to the property
            String testData = "pokemon";
            //assign the data to the property
            AnInventory.itemName = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnInventory.itemName, testData);
        }

        [TestMethod]
        public void itemPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //create some test data to assing to the property
            Double testData = 20.0000;
            //assign the data to the property
            AnInventory.itemPrice = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnInventory.itemPrice, testData);
        }

        [TestMethod]
        public void quantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //create some test data to assing to the property
            int testData = 20;
            //assign the data to the property
            AnInventory.quantity = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnInventory.quantity, testData);
        }

        [TestMethod]
        public void sizePropertyOK()
        {
            //create an instance of the class we want to create
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //create some test data to assing to the property
            String testData = "Medium";
            //assign the data to the property
            AnInventory.size = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnInventory.size, testData);
        }

        [TestMethod]
        public void lastStockDeliveryPropertyOK()
        {
            //create an instance of the class we want to create
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //create some test data to assing to the property
            DateTime testData = DateTime.Now.Date;
            //assign the data to the property
            AnInventory.lastStockDelivery = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnInventory.lastStockDelivery, testData);
        }

        [TestMethod]
        public void availabilityPropertyOK()
        {
            //create an instance of the class we want to create
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //create some test data to assing to the property
            Boolean testData = true;
            //assign the data to the property
            AnInventory.availability = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnInventory.availability, testData);
        }



        [TestMethod]

        public void TestitemIDFound()
        {
            //create an instance of the class we want to create
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //create a Boolean variable to store the result of each search
            Boolean Found = false;
            // create a Boolean variable to record is OK (assume it is)
            Boolean OK = true;
            //create some tests data to use with the method 
            Int32 itemID = 10;
            //invoke the method 
            Found = AnInventory.Find(itemID);
            // check the item ID
            if (AnInventory.itemID != 10)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestitemNameFound()
        {
            //create an instance of the class we want to create
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //create a Boolean variable to store the result of each search
            Boolean Found = false;
            // create a Boolean variable to record is OK (assume it is)
            Boolean OK = true;
            //create some tests data to use with the method 
            Int32 itemID = 10;
            //invoke the method 
            Found = AnInventory.Find(itemID);
            // check the item ID
            if (AnInventory.itemName != "pokemon")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestitemPriceFound()
        {
            //create an instance of the class we want to create
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //create a Boolean variable to store the result of each search
            Boolean Found = false;
            // create a Boolean variable to record is OK (assume it is)
            Boolean OK = true;
            //create some tests data to use with the method 
            Int32 itemID = 10;
            //invoke the method 
            Found = AnInventory.Find(itemID);
            // check the item ID
            if (AnInventory.itemPrice != 20.0000)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestquantityFound()
        {
            //create an instance of the class we want to create
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //create a Boolean variable to store the result of each search
            Boolean Found = false;
            // create a Boolean variable to record is OK (assume it is)
            Boolean OK = true;
            //create some tests data to use with the method 
            Int32 itemID = 10;
            //invoke the method 
            Found = AnInventory.Find(itemID);
            // check the item ID
            if (AnInventory.quantity != 20)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestsizeFound()
        {
            //create an instance of the class we want to create
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //create a Boolean variable to store the result of each search
            Boolean Found = false;
            // create a Boolean variable to record is OK (assume it is)
            Boolean OK = true;
            //create some tests data to use with the method 
            Int32 itemID = 10;
            //invoke the method 
            Found = AnInventory.Find(itemID);
            // check the item ID
            if (AnInventory.size != "Medium" )
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestlastStockDeliveryFound()
        {
            //create an instance of the class we want to create
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //create a Boolean variable to store the result of each search
            Boolean Found = false;
            // create a Boolean variable to record is OK (assume it is)
            Boolean OK = true;
            //create some tests data to use with the method 
            Int32 itemID = 10;
            //invoke the method 
            Found = AnInventory.Find(itemID);
            // check the item ID
            if (AnInventory.lastStockDelivery != Convert.ToDateTime("10/03/2024")) 
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestavailabilityFound()
        {
            //create an instance of the class we want to create
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //create a Boolean variable to store the result of each search
            Boolean Found = false;
            // create a Boolean variable to record is OK (assume it is)
            Boolean OK = true;
            //create some tests data to use with the method 
            Int32 itemID = 10;
            //invoke the method 
            Found = AnInventory.Find(itemID);
            // check the item ID
            if (AnInventory.availability != true)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnInventory.Valid (ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void itemNameMinLessOne()
        {
            //create an instance of the new class
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemName = ""; //this should trigger an error
                                  //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void itemNameMin()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ItemName = "a"; //this hsould be ok
                                   //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void itemNameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ItemName = "aa"; //this should be ok
                                    //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void itemNameNoMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ItemName = "aaaaa"; //this should be ok
                                       //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void itemNameNoMax()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ItemName = "aaaaaa"; //this should be ok
                                        //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void itemNameNoMid()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ItemName = "aaa"; //this should be ok
                                     //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void itemNameNoMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ItemName = ""; //this should fail
            ItemName = ItemName.PadRight(51, 'a');                             //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the reseult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void itemNameEtremeMax()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string ItemName = ""; //this should fail
            ItemName = ItemName.PadRight(500, 'a');          //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the reseult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void itemPriceMinLessOne()
        {
            //create an instance of the new class
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemPrice = "0"; //this should trigger an error
                                    //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void itemPriceMin()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ItemPrice = "1"; //this hsould be ok
                                    //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void itemPriceMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ItemPrice = "2"; //this should be ok
                                    //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void itemPriceNoMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ItemPrice = "9998.99"; //this should be ok
                                          //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void itemPriceNoMax()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ItemPrice = "9999.99"; //this should be ok
                                          //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void itemPriceNoMid()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ItemPrice = "300.00"; //this should be ok
                                         //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void itemPriceNoMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ItemPrice = "10001.00"; //this should fail
                                           //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the reseult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void itemPriceEtremeMax()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string ItemPrice = "50000.00"; //this should fail
                                           //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the reseult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void size()
        {
            //create an instance of the class we want to create
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Size = "";
            //INVOKE THE METHOD
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void quantityMinLessOne()
        {
            //create an instance of the new class
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //String c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "0"; //this should trigger an error
                                   //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void quantityMin()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "1"; //this hsould be ok
                                   //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void quantityMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "2"; //this should be ok
                                   //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void quantityMid()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "3"; //this should be ok
                                   //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void quantityNoMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "9999"; //this should be ok
                                    //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void quantityNoMax()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "10000"; //this should be ok
                                    //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void quantityMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Quantity = "10001"; //this should fail
                                           //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);

            //test to see that the reseult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void quantityEtremeMax()
        {
            //create an instance of the class we want to create 
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Quantity = "200000000"; //this should fail
                                           //invoke the method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);

            //test to see that the reseult is correct
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]

        public void lastStockDeliveryExtremeMin()
        {
            //create an instance of the new class
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //String c=variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is in less than 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string LastStockDelivery = TestDate.ToString();
            //invoke method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void lastStockDeliveryMinLessOne()
        {
            //create an instance of the new class
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //String c=variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = Convert.ToDateTime("31/12/2023");
            //convert the date variable to a string variable
            string LastStockDelivery = TestDate.ToString();
            //invoke method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void lastStockDeliveryMin()
        {
            //create an instance of the new class
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //String c=variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is in less than 100 years
            TestDate = Convert.ToDateTime("01/01/2024");
            //convert the date variable to a string variable
            string LastStockDelivery = TestDate.ToString();
            //invoke method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void lastStockDeliveryMinPlusOne()
        {
            //create an instance of the new class
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //String c=variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is in less than 100 years
            TestDate = Convert.ToDateTime("02/01/2024");
            //convert the date variable to a string variable
            string LastStockDelivery = TestDate.ToString();
            //invoke method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void lastStockDeliveryMaxLessOne()
        {
            //create an instance of the new class
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //String c=variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date and add a -1 to set the date to yesterday
            TestDate = DateTime.Now.Date.AddDays(-1);
            //convert the date variable to a string variable
            string LastStockDelivery = TestDate.ToString();
            //invoke method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void lastStockDeliveryMax()
        {
            //create an instance of the new class
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //String c=variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string LastStockDelivery = TestDate.ToString();
            //invoke method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void lastStockDeliveryPlusOne()
        {
            //create an instance of the new class
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //String c=variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date and add a + 1 to the date to set to tomorrow
            TestDate = DateTime.Now.Date.AddDays(+1);
            //convert the date variable to a string variable
            string LastStockDelivery = TestDate.ToString();
            //invoke method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void lastStockDeliveryExtremeMax()
        {
            //create an instance of the new class
            clsInventoryManagement AnInventory = new clsInventoryManagement();
            //String c=variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is in less than 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string LastStockDelivery = TestDate.ToString();
            //invoke method
            Error = AnInventory.Valid(ItemName, ItemPrice, Quantity, Size, LastStockDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }


}
