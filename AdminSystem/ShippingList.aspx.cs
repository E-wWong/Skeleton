using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayShipments();
        }
    }

    void DisplayShipments()
    {
        //create an instance of the shipping collection
        clsShippingCollection shipments = new clsShippingCollection();
        //set the data source to list of shipments in the collection
        lstShippingList.DataSource = shipments.ShipmentList;
        //set the name of the primary key
        lstShippingList.DataValueField = "shippingID";
        //set the data field to diplay
        lstShippingList.DataTextField = "address";
        //bind the data to the list
        lstShippingList.DataBind();
    }
}