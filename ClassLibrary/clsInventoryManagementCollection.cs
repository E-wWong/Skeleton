using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;

namespace ClassLibrary
{
    public class clsInventoryManagementCollection
    {

        //contructor for the class
/*       public clsInventoryManagementCollection()
        {
            //variable fo the index 
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblInventoryManagement_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while(Index < RecordCount)
            {
                //create a blank address
                clsInventoryManagement AnInventory = new clsInventoryManagement();
                //read in the fellds for the current record
                AnInventory.itemID = Convert.ToInt32(DB.DataTable.Rows[Index]["itemID"]);
                AnInventory.itemName = Convert.ToString(DB.DataTable.Rows[Index]["itemName"]);
                AnInventory.itemPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["itemPrice"]);
                AnInventory.quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["quantity"]);
                AnInventory.size = Convert.ToString(DB.DataTable.Rows[Index]["size"]);
                AnInventory.lastStockDelivery = Convert.ToDateTime(DB.DataTable.Rows[Index]["lastStockDelivery"]);
                AnInventory.availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["availability"]);
                //add the record to the private data memeber
                mInventoryList.Add(AnInventory);
                //point the next record
                Index++;
            }
        }
*/

        public clsInventoryManagementCollection()
        {
            //object for dataconnection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblInventoryManagement_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        //private data member for the list
        List<clsInventoryManagement> mInventoryList = new List<clsInventoryManagement>();
        //private member for this inventory
        clsInventoryManagement mThisInventory = new clsInventoryManagement();

        public List<clsInventoryManagement> InventoryList
        {
            get
            {
                //return the private data
                return mInventoryList;
            }
            set
            {
                //set the private data
                mInventoryList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mInventoryList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsInventoryManagement ThisInventory
        {
            get
            {
                //return the private data
                return mThisInventory;
            }
            set
            {
                //set the private data
                mThisInventory = value;
            }
        }


        public int Add()
        {
            //adds a record to the database based on the value of mThsiInventoryManagement
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters
            DB.AddParameter("@itemName", mThisInventory.itemName);
            DB.AddParameter("@itemPrice", mThisInventory.itemPrice);
            DB.AddParameter("@quantity", mThisInventory.quantity);
            DB.AddParameter("@size", mThisInventory.size);
            DB.AddParameter("@lastStockDelivery", mThisInventory.lastStockDelivery);
            DB.AddParameter("@availability", mThisInventory.availability);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblInventoryManagement_insert");
        }

        public void Update()
        {
            //adds a record to the database based on the value of mThsiInventoryManagement
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters
            DB.AddParameter("@itemID", mThisInventory.itemID);
            DB.AddParameter("@itemName", mThisInventory.itemName);
            DB.AddParameter("@itemPrice", mThisInventory.itemPrice);
            DB.AddParameter("@quantity", mThisInventory.quantity);
            DB.AddParameter("@size", mThisInventory.size);
            DB.AddParameter("@lastStockDelivery", mThisInventory.lastStockDelivery);
            DB.AddParameter("@availability", mThisInventory.availability);
            //execute the stored procedure
            DB.Execute("sproc_tblInventoryManagement_update");
        }

        public void Delete()
        {
            //deletes the record pointed to by this database
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@itemID", mThisInventory.itemID);
            //execute the stored procedure
            DB.Execute("sproc_tblInventoryManagement_Delete");
        }

        public void ReportByitemName(string itemName)
        {
            //filters the record based on a full or partial post code
            //conect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the postcode parameter to the databas
            DB.AddParameter("@itemName", itemName);
            //execute the stored procedure
            DB.Execute("sproc_tblInventory_FilterbyitemName");
            //populate the array lis with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list base on the data table in the parameter DB
            //variable for the index 
            Int32 Index = 0;
            //variable to store the record count 
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mInventoryList = new List<clsInventoryManagement>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsInventoryManagement AnInventory = new clsInventoryManagement();
                //read in the fellds for the current record
                AnInventory.itemID = Convert.ToInt32(DB.DataTable.Rows[Index]["itemID"]);
                AnInventory.itemName = Convert.ToString(DB.DataTable.Rows[Index]["itemName"]);
                AnInventory.itemPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["itemPrice"]);
                AnInventory.quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["quantity"]);
                AnInventory.size = Convert.ToString(DB.DataTable.Rows[Index]["size"]);
                AnInventory.lastStockDelivery = Convert.ToDateTime(DB.DataTable.Rows[Index]["lastStockDelivery"]);
                AnInventory.availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["availability"]);
                //add the record to the private data memeber
                mInventoryList.Add(AnInventory);
                //point the next record
                Index++;
            }
        }
    }
}