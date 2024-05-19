using System;
using System.Collections.Generic;
using System.Net;

namespace ClassLibrary
   
{
    public class clsShippingCollection
    {

        //private data member for the list
        List<clsShipping> mShippingList = new List<clsShipping>();

        //constructor for the class
        public clsShippingCollection() 
        {
            //variable for the index
            Int32 index = 0;
            //variable to store the record count
            Int32 recordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedue
            DB.Execute("sproc_tblShipping_SelectAll");
            //get the count of records
            recordCount = DB.Count;
            //while there are records to process
            while (index < recordCount)
            {
                //create a blank address
                clsShipping aShipment = new clsShipping();
                //read in all the fields for the current record
                aShipment.shippingID = Convert.ToInt32(DB.DataTable.Rows[index]["shippingID"]);
                aShipment.address = Convert.ToString(DB.DataTable.Rows[index]["address"]);
                aShipment.deliveryType = Convert.ToString(DB.DataTable.Rows[index]["deliveryType"]);
                aShipment.parcelSize = Convert.ToString(DB.DataTable.Rows[index]["parcelSize"]);
                aShipment.deliveryDate = Convert.ToDateTime(DB.DataTable.Rows[index]["deliveryDate"]);
                aShipment.orderID = Convert.ToInt32(DB.DataTable.Rows[index]["orderID"]);
                aShipment.isDispatched = Convert.ToBoolean(DB.DataTable.Rows[index]["isDispatched"]);
                //add the record to the private data member
                mShippingList.Add(aShipment);
                //point at the next record
                index++;
            }
        }

        //public property for the address list
        public List<clsShipping> ShipmentList 
        { 
            get
            {
                //return the private data
                return mShippingList;
            }
            set
            {
                //set the private data
                mShippingList = value;
            }
            
        }
        public int Count 
        {
            get
            {
                //return the count of the list
                return mShippingList.Count;
            }
            set
            {
                ////we shall worry about this later
            }
        }
        public clsShipping ThisShipment { get; set; }
    }
}