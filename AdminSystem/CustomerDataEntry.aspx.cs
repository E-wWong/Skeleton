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
}