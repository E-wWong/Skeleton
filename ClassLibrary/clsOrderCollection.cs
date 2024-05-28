using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private member data for thisOrder
        clsOrder mThisOrder = new clsOrder();

        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;

            }
            set
            {
                //set the private data
                mOrderList = value;
            }

        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //later
            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@totalItems", mThisOrder.totalItems);
            DB.AddParameter("@totalPrice", mThisOrder.totalPrice);
            DB.AddParameter("@address", mThisOrder.address);
            DB.AddParameter("@orderDate", mThisOrder.orderDate);
            DB.AddParameter("@isAGift", mThisOrder.isAGift);
            DB.AddParameter("@itemCodes", mThisOrder.itemCodes);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrderProcessing_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set its parameters for the new stored procedure 
            DB.AddParameter("orderId", mThisOrder.orderId);
            DB.AddParameter("@totalItems", mThisOrder.totalItems);
            DB.AddParameter("@totalPrice", mThisOrder.totalPrice);
            DB.AddParameter("@address", mThisOrder.address);
            DB.AddParameter("@orderDate", mThisOrder.orderDate);
            DB.AddParameter("@isAGift", mThisOrder.isAGift);
            DB.AddParameter("@itemCodes", mThisOrder.itemCodes);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderProcessing_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@orderId", mThisOrder.orderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderProcessing_Delete");
        }

        public void ReportByItemCodes(string itemCodes)
        {
            //filters the records based on a full or partial poste code
            //filters the record baased on a full or partial itemcodes
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the ItemCodes parameter to the database
            DB.AddParameter("@itemCodes", itemCodes);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderProcessing_FilterByItemCodes");
            PopulateArray(DB);
        }


        public clsOrderCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrderProcessing_SelectAll");
            //get the count od record
            PopulateArray(DB);
            //while there are record to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read in fields for the currentt record
                AnOrder.totalItems = Convert.ToInt32(DB.DataTable.Rows[Index]["TotalItems"]);
                AnOrder.totalPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["totalItems"]);
                AnOrder.address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnOrder.orderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.isAGift = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsAGift"]);
                AnOrder.itemCodes = Convert.ToString(DB.DataTable.Rows[Index]["ItemCodes"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }

        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates teh array list based on the data table i the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of record
            RecordCount = DB.Count;
            //clear the privare array list 
            mOrderList = new List<clsOrder>();
            //while there are record to process
            while (Index < RecordCount)
            {
                //create a blank address object
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.orderId = Convert.ToInt32(DB.DataTable.Rows[Index]["orderId"]);
                AnOrder.totalItems = Convert.ToInt32(DB.DataTable.Rows[Index]["TotalItems"]);
                AnOrder.totalPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["totalItems"]);
                AnOrder.address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnOrder.orderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.isAGift = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsAGift"]);
                AnOrder.itemCodes = Convert.ToString(DB.DataTable.Rows[Index]["ItemCodes"]);
                //add the record to the private data memeber
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }


    }

}
