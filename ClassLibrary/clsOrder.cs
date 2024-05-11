using System;
using System.Net.Mail;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the address id property
        private Int32 morderId;



        //addressId public property
        public Int32 orderId
        {
            get
            {
                //this line of code sends data out of the property
                return morderId;
            }
            set
            {
                //this line of code allows data into the property
                morderId = value;
            }

        }
        private Int32 mtotalItems;



        //addressId public property
        public Int32 totalItems
        {
            get
            {
                //this line of code sends data out of the property
                return mtotalItems;
            }
            set
            {
                //this line of code allows data into the property
                mtotalItems = value;
            }

        }
        private Double mtotalPrice;
        public Double totalPrice
        {


            get
            {
                //this line of code sends data out of the property
                return mtotalPrice;
            }
            set
            {
                //this line of code allows data into the property
                mtotalPrice = value;
            }

        }
        private String maddress;
        public String address
        {
            get
            {
                //this line of code sends data out of the property
                return maddress;
            }
            set
            {
                //this line of code allows data into the property
                maddress = value;
            }

        }
        private DateTime morderDate;
        public DateTime orderDate
        {
            get
            {
                //this line of code sends data out of the property
                return morderDate;
            }
            set
            {
                //this line of code allows data into the property
                morderDate = value;
            }

        }
        private Boolean misAGift;
        public Boolean isAGift
        {
            get
            {
                //this line of code send data out the property
                return misAGift;
            }
            set
            {
                //this line of code allows data into the property
                misAGift = value;
            }
        }
        private String mitemCodes;
        public String itemCodes
        {
            get
            {
                //this line of code send data out the property
                return mitemCodes;
            }
            set
            {
                //this line of code allows data into the property
                mitemCodes = value;
            }
        }



        public bool Find(int orderId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@OrderId", orderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderProcessing_FilterByorderId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                morderId = Convert.ToInt32(DB.DataTable.Rows[0]["orderId"]);
                mtotalItems = Convert.ToInt32(DB.DataTable.Rows[0]["totalItems"]);
                mtotalPrice = Convert.ToDouble(DB.DataTable.Rows[0]["totalPrice"]);
                maddress = Convert.ToString(DB.DataTable.Rows[0]["address"]);
                morderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["orderDate"]);
                misAGift = Convert.ToBoolean(DB.DataTable.Rows[0]["isAGift"]);
                mitemCodes = Convert.ToString(DB.DataTable.Rows[0]["itemCodes"]);

                //return that everything worked OK
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
   

    
