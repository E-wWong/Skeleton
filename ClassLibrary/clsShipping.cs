using System;
using System.Data;

namespace ClassLibrary
{
    public class clsShipping
    {
        public int shippingID { get; set; }

        public string address { get; set; }

        public string deliveryType { get; set; }

        public string parcelSize { get; set; }

        public DateTime deliveryDate { get; set; }

        public int orderID { get; set; }

        public bool isDispatched { get; set; }
    }
}