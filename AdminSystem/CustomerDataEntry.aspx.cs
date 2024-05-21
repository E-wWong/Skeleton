using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the customer details
        string CustomerId = txtCustomerID.Text;
        string Name = txtName.Text;
        string Email = txtEmail.Text;
        string MobileNum = txtMobileNum.Text;
        string Password = txtPassword.Text;
        string AccountCreationDate = clndrAccountCreationDate.SelectedDate.ToString();
        string ReturningCustomer = chkReturningCustomer.Checked.ToString();
        string Error = "";
        //validate the data
        Error = ACustomer.Valid(CustomerId, Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
        if (Error == "")
        {
            //capture the customer details
            ACustomer.customerID = Convert.ToInt32(CustomerId);
            ACustomer.name = Name;
            ACustomer.email = Email;
            ACustomer.mobileNum = MobileNum;
            ACustomer.password = Password;
            ACustomer.accountCreationDate = Convert.ToDateTime(AccountCreationDate);
            ACustomer.returningCustomer = Convert.ToBoolean(ReturningCustomer);
            //store the customerID in session object
            Session["ACustomer"] = ACustomer;
            //navigate to the view page
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //create a variable to store the primary key
        Int32 customerID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get primary key entered by user
        customerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = ACustomer.Find(customerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerID.Text = ACustomer.customerID.ToString();
            txtName.Text = ACustomer.name;
            txtEmail.Text = ACustomer.email;
            txtMobileNum.Text = ACustomer.mobileNum.ToString();
            txtPassword.Text = ACustomer.password;
            clndrAccountCreationDate.SelectedDate = ACustomer.accountCreationDate;
            chkReturningCustomer.Checked = ACustomer.returningCustomer;
        }
    }
}