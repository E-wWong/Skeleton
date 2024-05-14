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
        ACustomer.customerID = Convert.ToInt32(txtCustomerID.Text);
        ACustomer.name = txtName.Text;
        ACustomer.email = txtEmail.Text;
        ACustomer.mobileNum = Convert.ToInt64(txtMobileNum.Text);
        ACustomer.password = txtPassword.Text;
        ACustomer.accountCreationDate = Convert.ToDateTime(clndrAccountCreationDate.SelectedDate);
        ACustomer.returningCustomer = chkReturningCustomer.Checked;
        //store the customerID in session object
        Session["ACustomer"] = ACustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
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