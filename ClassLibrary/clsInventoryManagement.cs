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

    }
}