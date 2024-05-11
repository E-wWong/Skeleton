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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the StaffID
        AStaff.StaffID = Convert.ToInt32(txtStaffID.Text); //Gives error with letters.
        //capture the Name
        AStaff.name = txtName.Text;
        //capture the Email
        AStaff.email = txtEmail.Text;
        //capture the Role
        AStaff.role = txtName.Text;
        //capture the Password
        AStaff.password = txtName.Text;
        //capture the Check Permanent Employee
        AStaff.PermanentEmployee = chkPermanentEmployee.Checked;
        //capture the Date of Birth
        AStaff.DateofBirth = Convert.ToDateTime(Calendar1.SelectedDate);
        //store the StaffID in the session object
        Session["AStaff"] = AStaff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");

        
        

        
     
        
    }
}