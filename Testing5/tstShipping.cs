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
    }
}
