using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstInventoryManagement
    {
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
            int testData = 123;
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
            String testData = "Sea Art Print";
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
            Double testData = 20.99;
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
            int testData = 50;
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
            String testData = "Large";
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
            Int32 itemID = 21;
            //invoke the method 
            Found = AnInventory.Find(itemID);
            // check the item ID
            if (AnInventory.itemID != 21)
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
            Int32 itemID = 21;
            //invoke the method 
            Found = AnInventory.Find(itemID);
            // check the item ID
            if (AnInventory.itemName != "Sea Art Print")
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
            Int32 itemID = 21;
            //invoke the method 
            Found = AnInventory.Find(itemID);
            // check the item ID
            if (AnInventory.itemPrice != 20.99)
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
            Int32 itemID = 21;
            //invoke the method 
            Found = AnInventory.Find(itemID);
            // check the item ID
            if (AnInventory.quantity != 100)
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
            Int32 itemID = 21;
            //invoke the method 
            Found = AnInventory.Find(itemID);
            // check the item ID
            if (AnInventory.size != "Large" )
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
            Int32 itemID = 21;
            //invoke the method 
            Found = AnInventory.Find(itemID);
            // check the item ID
            if (AnInventory.lastStockDelivery != Convert.ToDateTime("10 / 05 / 2024"));
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
            Int32 itemID = 21;
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


    }


    
}
