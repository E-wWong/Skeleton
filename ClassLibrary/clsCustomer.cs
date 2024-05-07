using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public int customerID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public long mobileNum { get; set; }
        public string password { get; set; }
        public DateTime accountCreationDate { get; set; }
        public bool returningCustomer { get; set; }
    }
}