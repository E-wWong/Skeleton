using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary ket value fo the record to be deleted
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the customerID to be deleted from the session object
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the customer class
        clsCustomerCollection Customer = new clsCustomerCollection();
        //find the record to delete
        Customer.ThisCustomer.Find(CustomerID);
        //delete the record
        Customer.Delete();
        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }

    protected void bntNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }
}