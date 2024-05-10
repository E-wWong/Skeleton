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

        //****** GET/SET METHODS ***********************************************************************************************************************

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

        //****** FIND METHOD ***************************************************************************************************************************

        public bool Find(int shippingID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Shipping ID to search for
            DB.AddParameter("@ShippingID", shippingID);
            //execute the stored procedure
            DB.Execute("sproc_tblShipping_FilterByShippingID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mShippingID = Convert.ToInt32(DB.DataTable.Rows[0]["shippingID"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["address"]);
                mDeliveryType = Convert.ToString(DB.DataTable.Rows[0]["deliveryType"]);
                mParcelSize = Convert.ToString(DB.DataTable.Rows[0]["parcelSize"]);
                mDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["deliveryDate"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["orderID"]);
                mIsDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["isDispatched"]);
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }
    }
}