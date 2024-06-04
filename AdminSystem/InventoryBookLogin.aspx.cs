using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InventoryBookLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click1(object sender, EventArgs e)
    {
        //create an instance of the address user class
        clsInventoryManagementUser AnUser = new clsInventoryManagementUser();
        //create the variables to store the username and password
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        //create a variable to store the result of the find user opertation
        Boolean Found = false;
        //get the username entered by the user
        UserName = Convert.ToString(txtUserName.Text);
        //get the password enetered by the user
        Password = Convert.ToString(txtPassword.Text);
        //find the record 
        Found = AnUser.FindUser(UserName, Password);
        //if the username and/or password is empty
        if (txtUserName.Text == "")
        {
            //record the error
            lblError.Text = "enter a username ";
        }
        else if (txtPassword.Text == "")
        {
            //record the error
            lblError.Text = "enter a username ";
        }
        //if found 
        else if (Found == true)
        {
            //redirect to the list
            Response.Redirect("InventoryList.aspx");
        }
        else if (Found == false)
        {
            //record the error
            lblError.Text = "Login details are incorrect. Please try again ";
        }
    }
}