using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public int staffID { get; set; }
         public string name { get; set; }
        public string email { get; set; }
        public string role { get; set; }
         public string password { get; set; }
        public DateTime dateOfBirth { get; set; }
        public bool permanentEmployee { get; set; }    
    }
}