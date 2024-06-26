﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the customer user class
        clsCustomerUser AUser = new clsCustomerUser();
        //create the variables to store the username and password
        string Username = txtUserName.Text;
        string Password = txtPassword.Text;
        //create a varaible to store the result of the find user operation
        Boolean Found = false;
        //get the username and password entered by the user
        Username = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = AUser.FindUser(Username, Password);
        //ass a session to capture the username
        Session["AUser"] = AUser;
        //if either field is empty
        if (txtUserName.Text == "")
        {
            //record the error
            lblError.Text = "Enter a username";
        }
        else if (txtPassword.Text == "")
        {
            //record the error
            lblError.Text = "Enter a password";
        }
        //if found
        else if (Found == true)
        {
            //redirect to the list page
            Response.Redirect("CustomerList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Log in details are incorrect";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}