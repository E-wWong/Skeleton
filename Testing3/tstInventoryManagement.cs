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
    }
}
