using System;

namespace ClassLibrary
{
    public class clsInventoryManagement
    {
        public int itemID { get; set; }
        public string itemName { get; set; }
        public Double itemPrice { get; set; }
        public int quantity { get; set; }
        public string size { get; set; }
        public DateTime lastStockDelivery { get; set; }
        public bool availability { get; set; }
    }
}