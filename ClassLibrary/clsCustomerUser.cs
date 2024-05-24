using System;

namespace ClassLibrary
{
    public class clsCustomerUser
    {
        //private data members for user properties
        private Int32 mUserID;
        private String mUserName;
        private String mPassword;
        private String mDepartment;

        public clsCustomerUser()
        {
        }

        public int UserID
        {
            get
            {
                return mUserID;
            }
            set
            {
                mUserID = value;
            }
        }

        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }

        public string UserName
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }

        public string Department
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }

        public bool FindUser(string UserName, string Password)
        {
            //create an instance of the date connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the username and password to search for
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            //execute the stored procedure
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            //if one record is found (there should either be one or none)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true if everything worked ok
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}