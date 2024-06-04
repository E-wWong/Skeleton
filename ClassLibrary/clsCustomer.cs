using System;
using System.Dynamic;
using System.Text.RegularExpressions;

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
                mMobileNum = Convert.ToString(DB.DataTable.Rows[0]["mobileNum"]);
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

        //************************************************************************************************************

        public string Valid(string name, string email, string mobileNum, string password, string accountCreationDate, string returningCustomer)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;

            //************************************************************************************************************

            //if name is greater than 50 characters
            if (name.Length > 50)
            {
                //record the error
                Error = Error + "name may not be greater than 50 characters : ";
            }

            //if name is at least 1 character
            if (name.Length < 1)
            {
                //record the error
                Error = Error + "name must be at least 1 character long : ";
            }

            //************************************************************************************************************

            //if email is greater than 50 characters
            if (email.Length > 50)
            {
                //record the error
                Error = Error + "email may not be greater than 50 characters : ";
            }

            //if email is at least 1 character
            if (email.Length < 1)
            {
                //record the error
                Error = Error + "email must be at least 1 character long : ";
            }

            //************************************************************************************************************

            //if mobileNum is greater than 20 characters
            if (mobileNum.Length > 20)
            {
                //record the error
                Error = Error + "mobile number may not be greater than 20 characters : ";
            }

            //************************************************************************************************************

            //if password is greater than 100 characters
            if (password.Length > 100)
            {
                //record the error
                Error = Error + "password may not be greater than 100 characters : ";
            }

            //if password is at least 1 character
            if (password.Length < 10)
            {
                //record the error
                Error = Error + "password must be at least 10 characters long : ";
            }

            //************************************************************************************************************

            //create a string variable to store date values
            DateTime StartDate;
            DateTime TempDate;
            StartDate = Convert.ToDateTime("01/01/2024");
            TempDate = Convert.ToDateTime(accountCreationDate);
            if (TempDate > DateTime.Now.Date)
            {
                Error = Error + "account creation date cannot be in the future : ";
            }
            if(TempDate < StartDate)
            {
                Error = Error + "account creation date cannot be before 01/01/2024 : ";
            }

            return Error;

        }

        //************************************************************************************************************

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

        //************************************************************************************************************

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

        //************************************************************************************************************

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

        //************************************************************************************************************

        //private data member for the mobileNum property
        private string mMobileNum;

        //mobileNum public property
        public string mobileNum
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

        //************************************************************************************************************

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

        //************************************************************************************************************

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

        //************************************************************************************************************

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