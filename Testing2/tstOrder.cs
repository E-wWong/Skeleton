using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
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
        [TestMethod]
        public void itemCodes()
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
    }
    
}