using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool Find(int customerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customerID to search for
            DB.AddParameter("@CustomerID", customerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if 1 record is found (there should be 1 or 0)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["customerID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["name"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["email"]);
                mMobileNum = Convert.ToInt64(DB.DataTable.Rows[0]["mobileNum"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["password"]);
                mAccountCreationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["accountCreationDate"]);
                mReturningCustomer = Convert.ToBoolean(DB.DataTable.Rows[0]["returningCustomer"]);
                //return everything that worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there was a problem
                return false;
            }
        }

        //private data member for the customerID property
        private Int32 mCustomerID;

        //customerID public property
        public Int32 customerID
        {
            get
            {
                //this sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this allows data into the property
                mCustomerID = value;
            }
        }

        //private data member for the name property
        private string mName;

        //name public property
        public string name
        {
            get
            {
                //this sends data out of the property
                return mName;
            }
            set
            {
                //this allows data into the property
                mName = value;
            }
        }

        //private data member for the email property
        private string mEmail;

        //email public property
        public string email
        {
            get
            {
                //this sends data out of the property
                return mEmail;
            }
            set
            {
                //this allows data into the property
                mEmail = value;
            }
        }

        //private data member for the mobileNum property
        private Int64 mMobileNum;

        //mobileNum public property
        public Int64 mobileNum
        {
            get
            {
                //this sends data out of the property
                return mMobileNum;
            }
            set
            {
                //this allows data into the property
                mMobileNum = value;
            }
        }

        //private data member for the password property
        private string mPassword;

        //password public property
        public string password
        {
            get
            {
                //this sends data out of the property
                return mPassword;
            }
            set
            {
                //this allows data into the property
                mPassword = value;
            }
        }

        //private data member for the accountCreationDate property
        private DateTime mAccountCreationDate;

        //accountCreationDate public property
        public DateTime accountCreationDate
        {
            get
            {
                //this sends data out of the property
                return mAccountCreationDate;
            }
            set
            {
                //this allows data into the property
                mAccountCreationDate = value;
            }
        }

        //private data member for the returningCustomer property
        private Boolean mReturningCustomer;

        //customerID public property
        public Boolean returningCustomer
        {
            get
            {
                //this sends data out of the property
                return mReturningCustomer;
            }
            set
            {
                //this allows data into the property
                mReturningCustomer = value;
            }
        }

    }

}