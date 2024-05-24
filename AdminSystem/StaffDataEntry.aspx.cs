using System;
using System.Collections.Generic;
using System.Drawing;
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
        String StaffID = txtStaffID.Text;
        //capture the Name
        String name = txtName.Text;
        //capture the Email
        String email = txtEmail.Text;
        //capture the Role
        String role = txtRole.Text;
        //capture the Password
        String passwod = txtPassword.Text;
        //capture the Permanent Employee
        String PermanentEmployee = chkPermanentEmployee.Text;
        //capture the dateOfBirth
        String dateOfBirth = Calendar.SelectedDate.ToString();
        //variable to store any error messages
        String Error = "";
        //validate the data
        Error = AStaff.Valid(name,email,role,passwod,dateOfBirth);
        if (Error == "")

        {
            //capture the StaffID
            AStaff.StaffID = Convert.ToInt32(txtStaffID.Text); //Gives error with letters.
                                                               //capture the Name
            AStaff.name = txtName.Text;
            //capture the Email
            AStaff.email = txtEmail.Text;
            //capture the Role
            AStaff.role = txtRole.Text;
            //capture the Password
            AStaff.password = txtPassword.Text;
            //capture the Check Permanent Employee
            AStaff.PermanentEmployee = chkPermanentEmployee.Checked;
            //capture the Date of Birth
            AStaff.DateofBirth = Convert.ToDateTime(this.Calendar.SelectedDate);
            //store the StaffID in the session object
            Session["AStaff"] = AStaff;
            //navigate to the view page
            Response.Redirect("StaffViewer.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }    
        

        
     
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
       

    }
    
    protected void txtStaffID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click1(object sender, EventArgs e)
    {
        //create an instance of the Staff class
        clsStaff AStaff = new clsStaff();
        //create a new variable to store the primary key 
        Int32 staffID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        staffID = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = AStaff.Find(staffID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtName.Text = AStaff.name;
            txtEmail.Text = AStaff.email;
            txtRole.Text = AStaff.role;
            txtPassword.Text = AStaff.password;
            Calendar.SelectedDate = AStaff.DateofBirth;
            chkPermanentEmployee.Checked = AStaff.PermanentEmployee;


        }
    }
}