using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //get data from the session object
        ACustomer = (clsCustomer)Session["ACustomer"];
        //display the customerID
        Response.Write(ACustomer.customerID);
        Response.Write(ACustomer.name);
        Response.Write(ACustomer.email);
        Response.Write(ACustomer.mobileNum);
        Response.Write(ACustomer.password);
        Response.Write(ACustomer.accountCreationDate);
        Response.Write(ACustomer.returningCustomer);
    }
}