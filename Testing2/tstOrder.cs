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
    }
}
