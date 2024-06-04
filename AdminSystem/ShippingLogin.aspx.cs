using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShippingLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the address user class
        clsShippingUser aUser = new clsShippingUser();
        //create the variables to store the username and password
        string userName = txtUserName.Text;
        string password = txtPassword.Text;
        //create a variable to store the result of the find operation
        Boolean found = false;
        //get the username entered by the user
        userName = Convert.ToString(txtUserName.Text);
        //get the password entered by the user
        password = Convert.ToString(txtPassword.Text);
        //find the record
        found = aUser.FindUser(userName, password);
        //Add a session to capure the user namee
        Session["aUser"] = aUser;
        //if username and/or password is empty
        if (txtUserName.Text == "")
        {
            //record the error
            lblError.Text = "Enter a Username ";
        }
        else if (txtPassword.Text == "")
        {
            //record the error
            lblError.Text = "Enter a Password ";
        }
        //if found
        else if (found == true)
        {
            //redirect to the List Page
            Response.Redirect("ShippingList.aspx");
        }
        else
        {
             if (found == false)
            {
                //record the error
                lblError.Text = "Login details incorrect. Please try again ";
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}