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
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //get the data from the sessoin object
        AnOrder = (clsOrder)Session["AnOrder"];
        //display the house number for this entry
        Response.Write(AnOrder.orderId + " ");
        Console.WriteLine();
        Response.Write(AnOrder.totalItems + " ");
        Console.WriteLine();
        Response.Write(AnOrder.totalPrice + " ");
        Console.WriteLine();
        Response.Write(AnOrder.address + " ");
        Console.WriteLine();
        Response.Write(AnOrder.orderDate + " ");
        Console.WriteLine();
        Response.Write(AnOrder.isAGift + " ");
        Response.Write(AnOrder.itemCodes + " ");
        Console.WriteLine();
    }
}