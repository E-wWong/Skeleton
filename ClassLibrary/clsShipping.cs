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

        public string Valid(string shippingID, string address, string deliveryType, string parcelSize, string deliveryDate, string orderID)
        {
            //create a string variable to store the error
            String Error = "";

            //******  SHIPPING ID ***********************************************************************************************************************************************************************************************

            if (shippingID.Length == 0)
            {
                //record the error
                Error = Error + "Shipping ID cannot be left blank : ";
            }

            else if (Int64.Parse(shippingID) <= 0)
            {
                //record the error
                Error = Error + "The shipping ID cannot be less than one : ";
            }

            else if (Int64.Parse(shippingID)> 2000000000)
            {
                //record the error
                Error = Error + "The shipping ID cannot exceed 2000000000 : ";
            } 

            //****** ADDRESS ****************************************************************************************************************************************************************************************************
            
            if (address.Length == 4)
            {
                //record the error
                Error = Error + "Address cannot be left blank : ";

            }

            else if (address.Length < 20)
            {
                //record the error
                Error = Error + "Address has not reached the minimum character limit : ";

            }

            else if (address.Length > 160)
            {
                //record the error
                Error = Error + "The address must me equal or less than 160 characters : ";
            }

            //****** DELIVERY TYPE **********************************************************************************************************************************************************************************************

            if (deliveryType == "")
            {
                //record the error
                Error = Error + "An option for delivery type must be selected : ";

            }

            //****** PARCEL SIZE ************************************************************************************************************************************************************************************************

            if (parcelSize == "")
            {
                //record the error
                Error = Error + "An option for parcel size must be selected ; ";

            }

            //****** DELIVERY DATE **********************************************************************************************************************************************************************************************

            //create a string variable to store date values
            DateTime DateTemp;
            DateTime MaxDate;
            MaxDate = DateTime.Now.Date;
            MaxDate = MaxDate.AddDays(7);
            DateTemp = Convert.ToDateTime(deliveryDate);

            

            if (DateTemp <= Convert.ToDateTime("31/12/2023"))
            {
                Error = Error + "Date cannot be before the company was created : ";
            }

            if (DateTemp > MaxDate)
            {
                //record the error
                Error = Error + "The delivery date should not exceed 7 days : ";
            }

            //****** ORDER ID ***************************************************************************************************************************************************************************************************

            if (orderID.Length == 0)
            {
                //record the error
                Error = Error + "Order ID cannot be left blank : ";
            }

            else if (Int64.Parse(orderID) <= 0)
            {
                //record the error
                Error = Error + "The order ID cannot be less than one : ";
            }

            else if (Int64.Parse(orderID) > 2000000000)
            {
                //record the error
                Error = Error + "The shipping ID cannot exceed 2000000000 : ";
            }

            //****** RETURN ERROR ***********************************************************************************************************************************************************************************************

            //return any error messages
            return Error;
        }
    }
}