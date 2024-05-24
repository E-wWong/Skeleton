using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CustomerID != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }

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
        Error = ACustomer.Valid(Name, Email, MobileNum, Password, AccountCreationDate, ReturningCustomer);
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
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            //if this is a new record then add the data
            if (CustomerID == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerID);
                //set the ThisCustomerProperty
                CustomerList.ThisCustomer = ACustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the list page
            Response.Redirect("CustomerList.aspx");
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
            txtMobileNum.Text = ACustomer.mobileNum;
            txtPassword.Text = ACustomer.password;
            clndrAccountCreationDate.SelectedDate = ACustomer.accountCreationDate;
            chkReturningCustomer.Checked = ACustomer.returningCustomer;
        }
    }

    void DisplayCustomer()
    {
        //create an instance of the customer
        clsCustomerCollection Customer = new clsCustomerCollection();
        //find the record to update
        Customer.ThisCustomer.Find(CustomerID);
        //dispay the data for the record
        txtCustomerID.Text = Customer.ThisCustomer.customerID.ToString();
        txtName.Text = Customer.ThisCustomer.name;
        txtEmail.Text = Customer.ThisCustomer.email;
        txtMobileNum.Text = Customer.ThisCustomer.mobileNum;
        txtPassword.Text = Customer.ThisCustomer.password;
        clndrAccountCreationDate.SelectedDate = Customer.ThisCustomer.accountCreationDate;
        chkReturningCustomer.Checked = Customer.ThisCustomer.returningCustomer;
    }
}