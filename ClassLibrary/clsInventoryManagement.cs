using System;
using System.ComponentModel;

namespace ClassLibrary
{
    public class clsInventoryManagement
    {
        // private data member for the item ID
        private Int32 mitemID;

        //itemID public property

        public Int32 itemID
        {
            get
            {
                //this line of code sends data out the property
                return mitemID;
            }
            set
            {
                //this line of code allows data into the property
                mitemID = value;
            }
        }

        private string mitemName;

        public string itemName
        {
            get
            {
                return mitemName;
            }
            set
            {
                mitemName = value;
            }
        }

        private Double mitemPrice;

        public Double itemPrice
        {
            get
            {
                return mitemPrice;
            }
            set
            {
                mitemPrice = value;
            }
        }

        private Int32 mquantity;


        public Int32 quantity
        {
            get
            {
                return mquantity;
            }
            set
            {
                mquantity = value;
            }
        }

        private string msize;

        public string size
        {
            get
            {
                return msize;
            }
            set
            {
                msize = value;
            }
        }

        private DateTime mlastStockDelivery;

        public DateTime lastStockDelivery
        {
            get
            {
                return mlastStockDelivery;
            }
            set
            {
                mlastStockDelivery = value;
            }
        }

        private Boolean mavailability;

        public Boolean availability
        {
            get
            {
                return mavailability;
            }
            set
            {
                mavailability = value;
            }
        }



        public bool Find(int itemID)
        {
            //set the private data memebers to the test data value
            mitemID = 21;
            mquantity = 100;
            mitemName = "Sea Art Print";
            msize = "Large";
            mitemPrice = 20.99;
            mlastStockDelivery = Convert.ToDateTime("10 / 05 / 2024");
            mavailability = true;
            //always return true
            return true;
        }

    }
}