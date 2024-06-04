using System;
using System.ComponentModel;
using System.Collections.Generic;

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



        public bool Find(int itemId)
        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the paramemter for the item id to search for 
            DB.AddParameter("@itemId", itemId);
            //add execute the stored procedure
            DB.Execute("sproc_tblInventoryManagement_itemID");
            //if one record is found (there should be either one or zero)
;           if (DB.Count == 1)
            {
                mitemID = Convert.ToInt32(DB.DataTable.Rows[0]["itemId"]);
                mitemName = Convert.ToString(DB.DataTable.Rows[0]["itemName"]);
                mitemPrice = Convert.ToDouble(DB.DataTable.Rows[0]["itemPrice"]);
                mquantity = Convert.ToInt32(DB.DataTable.Rows[0]["quantity"]);
                msize = Convert.ToString(DB.DataTable.Rows[0]["size"]);
                mlastStockDelivery = Convert.ToDateTime(DB.DataTable.Rows[0]["lastStockDelivery"]);
                mavailability = Convert.ToBoolean(DB.DataTable.Rows[0]["availability"]);
                //always return true
                return true;
            }
          else
            {
                //return false indidcating there is a problem
                return false;
            }

        }

        public string Valid( string itemName, string itemPrice, string quantity, string size, string lastStockDelivery)
        {
            //create a string variable to store the error
            String Error = "";



            //if the ItemName is blank
            if (itemName.Length < 1)
            {
                //record error
                Error = Error + "the Item Name may not be blank : ";
            }
            if (itemName.Length > 50)
            {
                //record the error
                Error = Error + "The Item Name must be greater than 50";
            }

            //if the ItemPrice is blank
            if (Double.Parse(itemPrice) < 1)
            {
                //record error
                Error = Error + "the Item Price may not be blank : ";
            }
            if (Double.Parse(itemPrice) > 9999.99)
            {
                //record the error
                Error = Error + "The Item Price must be less than 6 characters";
            }

            //if the quantity is blank
            if (Int32.Parse(quantity) < 1)
            {
                //record error
                Error = Error + "the quantity cannot be less than 1: ";
            }
            if (Int32.Parse(quantity) > 10000)

            {
                //record the error
                Error = Error + "The quantity cannot be more than 100,000,000";
            }

            if (size == "")
            {
                Error = Error + "An option for delivery type must be selected";

            }


            //create a temporary value to store the date values
            DateTime DateTemp;
            //if the ItemPrice is blank
            
            //copy the dateAdded value tot he DateTemp variable
            DateTemp = Convert.ToDateTime(lastStockDelivery);

            if (DateTemp < Convert.ToDateTime("01/01/2024"))
            {
                //record the error
                Error = Error + "The date cannot be in the past";
            }
            //check to see if the date is less than today's date
            if (DateTemp > DateTime.Now.Date) 
            {
                Error = Error + "The date cannot be in the future";
            }

            //return any error messages
            return Error;

        }
    }
}