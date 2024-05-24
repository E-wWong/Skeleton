using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    //variable to store the primary key value of the record to be deleted 
    Int32 shippingID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the shipment to be deleted from the session object
        shippingID = Convert.ToInt32(Session["shippingID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the shipping book collection class 
        clsShippingCollection shipmentBook = new clsShippingCollection();
        //find the record to delete
        shipmentBook.ThisShipment.Find(shippingID);
        //delete the record
        shipmentBook.Delete();
        //redirect back to the main page
        Response.Redirect("ShippingList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("ShippingList.aspx");

    }
}