using System;
using System.Collections.Generic;
using System.Reflection;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        public clsCustomerCollection()
        {
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_selectAll");
            //populate the Array List wiht the data table
            PopulateArray(DB);
        }

        //***************************************************************************************************************

        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member for thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //leave blank
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stores procedure
            DB.AddParameter("@CustomerID", mThisCustomer.customerID);
            DB.AddParameter("@Name", mThisCustomer.name);
            DB.AddParameter("@Email", mThisCustomer.email);
            DB.AddParameter("@MobileNum", mThisCustomer.mobileNum);
            DB.AddParameter("@Password", mThisCustomer.password);
            DB.AddParameter("@AccountCreationDate", mThisCustomer.accountCreationDate);
            DB.AddParameter("@ReturningCustomer", mThisCustomer.returningCustomer);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.customerID);
            DB.AddParameter("@Name", mThisCustomer.name);
            DB.AddParameter("@Email", mThisCustomer.email);
            DB.AddParameter("@MobileNum", mThisCustomer.mobileNum);
            DB.AddParameter("@Password", mThisCustomer.password);
            DB.AddParameter("@AccountCreationDate", mThisCustomer.accountCreationDate);
            DB.AddParameter("@ReturningCustomer", mThisCustomer.returningCustomer);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //delete the record pointed to by ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.customerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByEmail(string Email)
        {
            //filters records based on a full or partial email
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the email parameter to the database
            DB.AddParameter("@Email", Email);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByEmail");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer object
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.customerID = Convert.ToInt32(DB.DataTable.Rows[Index]["customerID"]);
                ACustomer.name = Convert.ToString(DB.DataTable.Rows[Index]["name"]);
                ACustomer.email = Convert.ToString(DB.DataTable.Rows[Index]["email"]);
                ACustomer.mobileNum = Convert.ToString(DB.DataTable.Rows[Index]["mobileNum"]);
                ACustomer.password = Convert.ToString(DB.DataTable.Rows[Index]["password"]);
                ACustomer.accountCreationDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["accountCreationDate"]);
                ACustomer.returningCustomer = Convert.ToBoolean(DB.DataTable.Rows[Index]["returningCustomer"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }
    }
}