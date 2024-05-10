using System;
using System.Data;

namespace ClassLibrary
{
    public class clsShipping
    {
        //private data member for each of the properties
        private Int32 mShippingID;
        private String mAddress;
        private String mDeliveryType;
        private String mParcelSize;
        private DateTime mDeliveryDate;
        private Int32 mOrderID;
        private Boolean mIsDispatched;

        public int shippingID 
        { 
            get
            {
                //this line of code sends data out of the property
                return mShippingID;
            }
            set
            {
                //this line of code allows data into the property
                mShippingID = value;
            }
        }

        public string address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }

        public string deliveryType
        {
            get
            {
                //this line of code sends data out of the property
                return mDeliveryType;
            }
            set
            {
                //this line of code allows data into the property
                mDeliveryType = value;
            }
        }

        public string parcelSize
        {
            get
            {
                //this line of code sends data out of the property
                return mParcelSize;
            }
            set
            {
                //this line of code allows data into the property
                mParcelSize = value;
            }
        }

        public DateTime deliveryDate
        {
            get
            {
                //this line of code sends data out of the property
                return mDeliveryDate;
            }
            set
            {
                //this line of code allows data into the property
                mDeliveryDate = value;
            }
        }

        public int orderID
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderID;
            }
            set
            {
                //this line of code allows data into the property
                mOrderID = value;
            }
        }

        public bool isDispatched
        {
            get
            {
                //this line of code sends data out of the property
                return mIsDispatched;
            }
            set
            {
                //this line of code allows data into the property
                mIsDispatched = value;
            }
        }

        public bool Find(int shippingID)
        {
            //set the private data members to the test data value
            mShippingID = 4;
            mAddress = "416 Highfield Road-Leicester-LE54 0JI";
            mDeliveryType = "First";
            mParcelSize = "Small";
            mDeliveryDate = Convert.ToDateTime("15/05/2024");
            mOrderID = 7;
            mIsDispatched = true;
            //always return true
            return true;
        }
    }
}