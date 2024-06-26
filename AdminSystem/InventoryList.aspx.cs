﻿using System;
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
            DisplayInventories();
        }
        //create a new instance of clsInventoryUser
        clsInventoryManagementUser AnUser = new clsInventoryManagementUser();
        //get data from the session object
        AnUser = (clsInventoryManagementUser)Session["AnUser"];
        //display the username
        Response.Write("Logged in as " + AnUser.UserName);
    }

    void DisplayInventories()
    {
        //create an instance of the address collecetion
        clsInventoryManagementCollection Inventories = new clsInventoryManagementCollection();
        //set the data source to list of address in the collection
        lstInventoryList.DataSource = Inventories.InventoryList;
        //set the name of the primary key
        lstInventoryList.DataValueField = "itemID";
        //set the data field to display
        lstInventoryList.DataTextField = "itemName";
        //bind the data to the list
        lstInventoryList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["InventoryId"] = 0;
        //redirect to the data entry page
        Response.Redirect("InventoryDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited 
        Int32 InventoryId;
        //if a record has been selected from the list
        if (lstInventoryList.SelectedIndex != -1)
        {
            //get the primary key value of the record to be edited
            InventoryId = Convert.ToInt32(lstInventoryList.SelectedValue);
            //store the data in the session object
            Session["InventoryId"] = InventoryId;
            //redirect to the edit page
            Response.Redirect("InventoryDataEntry.aspx");
        }
        else //if no record has been selected 
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited 
        Int32 InventoryId;
        //if a record has been selected from the list
        if (lstInventoryList.SelectedIndex != -1)
        {
            //get the primary key value of the record to be edited
            InventoryId = Convert.ToInt32(lstInventoryList.SelectedValue);
            //store the data in the session object
            Session["InventoryId"] = InventoryId;
            //redirect to the edit page
            Response.Redirect("InventoryConfirmDelete.aspx");
        }
        else //if no record has been selected 
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnAF_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsInventoryManagementCollection AnInventory = new clsInventoryManagementCollection();
        //retrieve the value of item name from the presentation layer
        AnInventory.ReportByitemName(txtEnterItemName.Text);
        //set the data source to the list of addresses in the collection
        lstInventoryList.DataSource = AnInventory.InventoryList;
        //set the name of the primary key
        lstInventoryList.DataValueField = "itemID";
        //set the name of the field to display
        lstInventoryList.DataTextField = "itemName";
        //bind the data to the list
        lstInventoryList.DataBind();

    }

    protected void btnCL_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsInventoryManagementCollection AnInventory = new clsInventoryManagementCollection();
        //retrieve the value of item name from the presentation layer
        AnInventory.ReportByitemName("");
        //clear any existing filter to tidy up the interface
        txtEnterItemName.Text = "";
        //set the data source to the list of addresses in the collection
        lstInventoryList.DataSource = AnInventory.InventoryList;
        //set the name of the primary key
        lstInventoryList.DataValueField = "itemID";
        //set the name of the field to display
        lstInventoryList.DataTextField = "itemName";
        //bind the data to the list
        lstInventoryList.DataBind();

    }

    protected void btnReturnToPage_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}