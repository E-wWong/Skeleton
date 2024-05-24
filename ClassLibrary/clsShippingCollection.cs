using System;
using System.Collections.Generic;
using System.Net;

namespace ClassLibrary
   
{
    public class clsShippingCollection
    {

        //private data member for the list
        List<clsShipping> mShippingList = new List<clsShipping>();
        //private member of daa for thisShipment
        clsShipping mThisShipment = new clsShipping();

        //constructor for the class
        public clsShippingCollection() 
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblShipping_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
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
        public clsShipping ThisShipment 
        {
            get
            {
                //return the private data
                return mThisShipment;
            }
            set
            {
                //set the private data
                mThisShipment = value;
            }
        }

        public int Add()
        {
            //adds a record to the database on the values of mThisShipment
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@address", mThisShipment.address);
            DB.AddParameter("@deliveryType", mThisShipment.deliveryType);
            DB.AddParameter("@parcelSize", mThisShipment.parcelSize);
            DB.AddParameter("@deliveryDate", mThisShipment.deliveryDate);
            DB.AddParameter("@orderID", mThisShipment.orderID);
            DB.AddParameter("@isDispatched", mThisShipment.isDispatched);

            //execute the query returning the primary key value 
            return DB.Execute("sproc_tblShipping_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisShipment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@shippingID", mThisShipment.shippingID);
            //execute the stored procedure 
            DB.Execute("sproc_tblShipping_Delete");
        }

        public void ReportByAddress(string address)
        {
            //filter the records based on a full or partial address
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the address parameter to the database
            DB.AddParameter("@address", address);
            //execute the stored procedure
            DB.Execute("sproc_tblShipping_FilterByAddress");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void Update()
        {
            //update an existing record based on the values of Thisshipment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@shippingID", mThisShipment.shippingID);
            DB.AddParameter("@address", mThisShipment.address);
            DB.AddParameter("@deliveryType", mThisShipment.deliveryType);
            DB.AddParameter("@parcelSize", mThisShipment.parcelSize);
            DB.AddParameter("@deliveryDate", mThisShipment.deliveryDate);
            DB.AddParameter("@orderID", mThisShipment.orderID);
            DB.AddParameter("@isDispatched", mThisShipment.isDispatched);

            //execute the stored procedure
            DB.Execute("sproc_tblShipping_Update");
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 index = 0;
            //variable to store the record count
            int recordCount;
            //get the count of records
            recordCount = DB.Count;
            //clear the private array list
            mShippingList = new List<clsShipping>();
            //while there are records to process 
            while (index < recordCount)
            {
                //create a blank shipping object
                clsShipping AShipment = new clsShipping();
                //read the fields from the current record
                AShipment.shippingID = Convert.ToInt32(DB.DataTable.Rows[index]["shippingID"]);
                AShipment.address = Convert.ToString(DB.DataTable.Rows[index]["address"]);
                AShipment.deliveryType = Convert.ToString(DB.DataTable.Rows[index]["deliveryType"]);
                AShipment.parcelSize = Convert.ToString(DB.DataTable.Rows[index]["parcelSize"]);
                AShipment.deliveryDate = Convert.ToDateTime(DB.DataTable.Rows[index]["deliveryDate"]);
                AShipment.orderID = Convert.ToInt32(DB.DataTable.Rows[index]["orderID"]);
                AShipment.isDispatched = Convert.ToBoolean(DB.DataTable.Rows[index]["isDispatched"]);
                //add the record to the private data member
                mShippingList.Add(AShipment);
                //point to the next record
                index++;
            }
        }
    }
}