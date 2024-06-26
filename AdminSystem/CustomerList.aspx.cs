﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            displayCustomers();
        }

        //create a new instance of clsCustomerUser
        clsCustomerUser AUser = new clsCustomerUser();
        //get data form the session object
        AUser = (clsCustomerUser)Session["AUser"];
        //display the username
        Response.Write("Logged in as: " + AUser.UserName);
    }

    void displayCustomers()
    {
        //create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to list of customers in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "customerID";
        //set the data field to display
        lstCustomerList.DataTextField = "email";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["customerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to be edited
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }
        //if no record has been selected
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the customer object
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        //retrieve the value of the email from the presentation layer
        ACustomer.ReportByEmail(txtFilter.Text);
        //set the data source to the list of customers in the collection
        lstCustomerList.DataSource = ACustomer.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "customerID";
        //set the name of the field to display
        lstCustomerList.DataTextField = "email";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the customer object
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        //set an empty string
        ACustomer.ReportByEmail("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of customers in the collection
        lstCustomerList.DataSource = ACustomer.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "customerID";
        //set the name of the field to display
        lstCustomerList.DataTextField = "email";
        //bind the data to the list
        lstCustomerList.DataBind();

    }



    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //redirect back to the list page
        Response.Redirect("TeamMainMenu.aspx");
    }
}