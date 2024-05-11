using System;
using System.Diagnostics.SymbolStore;

namespace ClassLibrary
{
    public class clsStaff
    {
        //Private data member for the StaffID property
        private Int32 mStaffID;
        private String mName;
        private String mEmail;
        private String mRole;
        private String mPassword;
        private Boolean mPermanentEmployee;
        private DateTime mDateofBirth;

        //StaffID public property
        public Int32 StaffID
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffID;
            }
            set
            {
                //this line of code allows data into the property
                mStaffID = value;
            }
        }

        //Name public property
        public string name
        {
            get
            {
                //this line of code sends data out of the property
                return mName;
            }
            set
            {
                //this line of code allows data into the property
                mName = value;
            }
        }
        //Email public property
        public string email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }
        //Role public property
        public string role
        {
            get
            {
                //this line of code sends data out of the property
                return mRole;
            }
            set
            {
                //this line of code allows data into the property
                mRole = value;
            }
        }
        //Password public property
        public string password
        {
            get
            {
                //this line of code sends data out of the property
                return mPassword;
            }
            set
            {
                //this line of code allows data into the property
                mPassword = value;
            }
        }
        //DateTime public property
        public DateTime DateofBirth
        {
            get
            {
                //this line of code sends data out of the property
                return mDateofBirth;
            }
            set
            {
                //this line of code allows data into the property
                mDateofBirth = value;
            }
        }
        //PermanentEmployee public property
        public bool PermanentEmployee
        {
            get
            {
                //this line of code sends data out of the property
                return mPermanentEmployee;
            }
            set
            {
                //this line of code allows data into the property
                mPermanentEmployee = value;
            }
        }

        public bool Find(int staffID)
        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@staffID", staffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaffManagement_FilterByStaffID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {

                //copy the data from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["staffID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]); ;
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]); 
                mRole = Convert.ToString(DB.DataTable.Rows[0]["Role"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDateofBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mPermanentEmployee = Convert.ToBoolean(DB.DataTable.Rows[0]["permanentEmployee"]);
                //always return true

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