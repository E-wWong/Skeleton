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
        //create a new instance of clsInventoryManagement
        clsInventoryManagement AnInventory = new clsInventoryManagement();
        //get data from the session object
        AnInventory = (clsInventoryManagement)Session["AnInventory"];
        //display the item ID for this entry
        Response.Write(AnInventory.itemID);
        Response.Write(AnInventory.itemName);
        Response.Write(AnInventory.itemPrice);
        Response.Write(AnInventory.quantity);
        Response.Write(AnInventory.size);
        Response.Write(AnInventory.lastStockDelivery);
        Response.Write(AnInventory.availability);

    }
}