using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public int orderId {  get; set; }
        public int totalItems { get; set; }
        public double totalPrice { get; set; }
        public string address { get; set; }
        public DateTime orderDate { get; set; }
        public bool isAGift { get; set; }
        public string itemCodes { get; set; }   
    }
}