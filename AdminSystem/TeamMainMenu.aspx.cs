using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        //redirect to the right page
        Response.Redirect("CustomerLogin.aspx");
    }

    protected void btnInventory_Click(object sender, EventArgs e)
    {
        //redirect to the right page
        Response.Redirect("InventoryBookLogin.aspx");
    }

    protected void btnOrder_Click(object sender, EventArgs e)
    {
        //redirect to the right page
        Response.Redirect("OrderLogin.aspx");
    }

    protected void btnShipping_Click(object sender, EventArgs e)
    {
        //redirect to the right page
        Response.Redirect("ShippingLogin.aspx");
    }


    protected void Button3_Click(object sender, EventArgs e)
    {
        //redirect to the right page
        Response.Redirect("StaffListLogin.aspx");

    }
}