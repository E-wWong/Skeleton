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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indiate this is a new record
        Session["shippingID"] = -1;
        //redirect to the entry data page
        Response.Redirect("ShippingDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 shippingID;
        //if a record has been selected from the list
        if (lstShippingList.SelectedIndex != -1)
        {
            //get the primary key value of the record o edit
            shippingID = Convert.ToInt32(lstShippingList.SelectedValue);
            //store the data in the session object
            Session["shippingID"] = shippingID;
            //redirect to the edit page
            Response.Redirect("ShippingDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted 
        Int32 shippingID;
        //if a record has been selected from the list 
        if (lstShippingList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            shippingID = Convert.ToInt32(lstShippingList.SelectedValue);
            //store the data in the session object
            Session["shippingID"] = shippingID;
            //redirect to the delete page
            Response.Redirect("ShippingConfirmDelete.aspx");
        }
        else
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }
}