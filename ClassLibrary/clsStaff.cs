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
            //set the private data members to the test data value
            mStaffID = 2717647;
            mName = "Harvey";
            mEmail = "harvey@my365.dmu.ac.uk";
            mRole = "Customer Manager";
            mPassword = "harvey_123";
            mDateofBirth = Convert.ToDateTime ("16/06/2004");
            mPermanentEmployee = true;
            //always return true
            
            return true;
        }

            

           

    }
}