using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 orderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //getthe number of address to be deleted rom the session object
        orderId = Convert.ToInt32(Session["orderId"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the address book collection class
        clsOrderCollection Order = new clsOrderCollection();
        //find the new record to delete
        Order.ThisOrder.Find(orderId);
        //delete the record
        Order.Delete();
        //redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }
}