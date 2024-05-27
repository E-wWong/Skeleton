using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //constructor for the class
        public clsStaffCollection()
        {


            /*
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
           */
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblStaffManagement_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        /*
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Staff
                clsStaff AStaff = new clsStaff();
                //read in the fields for the current record
                AStaff.PermanentEmployee = Convert.ToBoolean(DB.DataTable.Rows[Index]["PermanentEmployee"]);
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.DateofBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateofBirth"]);
                AStaff.name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AStaff.email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AStaff.role = Convert.ToString(DB.DataTable.Rows[Index]["Role"]);
                AStaff.password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        */

        }
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private member data for ThisStaff
        clsStaff mThisStaff = new clsStaff();


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
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address object
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.PermanentEmployee = Convert.ToBoolean(DB.DataTable.Rows[Index]["PermanentEmployee"]);
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.DateofBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateofBirth"]);
                AStaff.name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AStaff.email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AStaff.role = Convert.ToString(DB.DataTable.Rows[Index]["Role"]);
                AStaff.password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data 
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }



        //public property for ThisStaff

        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }

        }

        public int Add()
        {
            //adds a record to thew database based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisStaff.name);
            DB.AddParameter("@Email", mThisStaff.email);
            DB.AddParameter("@Role", mThisStaff.role);
            DB.AddParameter("@Password", mThisStaff.password);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateofBirth);
            DB.AddParameter("@PermanentEmployee", mThisStaff.PermanentEmployee);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaffManagement_Insert");

        }

        public void Update()
        {
            //update an existing record based on the values of ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@Name", mThisStaff.name);
            DB.AddParameter("@Email", mThisStaff.email);
            DB.AddParameter("@Role", mThisStaff.role);
            DB.AddParameter("@Password", mThisStaff.password);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateofBirth);
            DB.AddParameter("@PermanentEmployee", mThisStaff.PermanentEmployee);
            //execute the stored procedure
            DB.Execute("sproc_tblStaffManagement_Update");


        }

        public void Delete()
        {
            //delete the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaffManagement_Delete");
        }

        public void ReportByRole(string Role)
        {
            //filters the records based on a full or portial role
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the role parameter to the database
            DB.AddParameter("@Role",  Role);
            //execute the stored procedure
            DB.Execute("sproc_tblStaffManagement_FilterByRole");
            //populate the array list with the data table
            PopulateArray(DB);

        }
    }
} 
