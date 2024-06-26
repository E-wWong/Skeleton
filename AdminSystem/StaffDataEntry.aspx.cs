﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 staffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staffs to be processed 
        staffID = Convert.ToInt32(Session["staffID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (staffID != 0)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }

    }
    void DisplayStaff()
    {
     //create an instance of the staffdata 
     clsStaffCollection StaffData = new clsStaffCollection();
     //find the record to update 
     StaffData.ThisStaff.Find(staffID);
     //display the data for the record
     txtStaffID.Text = StaffData.ThisStaff.StaffID.ToString();
     txtName.Text = StaffData.ThisStaff.name.ToString();
     txtEmail.Text = StaffData.ThisStaff.email.ToString();
     txtRole.Text = StaffData.ThisStaff.role.ToString();
     txtPassword.Text = StaffData.ThisStaff.password.ToString();
     Calendar.SelectedDate = StaffData.ThisStaff.DateofBirth;
     chkPermanentEmployee.Checked = StaffData.ThisStaff.PermanentEmployee;


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
        String password = txtPassword.Text;
        //capture the Permanent Employee
        String PermanentEmployee = chkPermanentEmployee.Text;
        //capture the dateOfBirth
        String dateOfBirth = Calendar.SelectedDate.ToString();
        //variable to store any error messages
        String Error = "";
        //validate the data
        Error = AStaff.Valid(name, email, role, password, dateOfBirth);
        if (Error == "")

        {
            //capture the StaffID
            AStaff.StaffID = staffID; //Gives error with letters.
            //capture the Name
            AStaff.name = name;
            //capture the Email
            AStaff.email = email;
            //capture the Role
            AStaff.role = role;
            //capture the Password
            AStaff.password = password;
            //capture the Check Permanent Employee
            AStaff.PermanentEmployee = chkPermanentEmployee.Checked;
            //capture the Date of Birth
            AStaff.DateofBirth = Convert.ToDateTime(this.Calendar.SelectedDate);
            //create a new instance of the class collection
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record i. e. StaffID = -1 then add the data
            if (staffID == 0)
            {
                //set the ThisStaff property
                StaffList.ThisStaff = AStaff;
                //add the new record
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(staffID);
                //set the ThisStaff property
                StaffList.ThisStaff = AStaff;
                //update the record
                StaffList.Update();

            }
            //redirect back to the list page
            Response.Redirect("StaffList.aspx");
            
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
            Calendar.VisibleDate = AStaff.DateofBirth;
            chkPermanentEmployee.Checked = AStaff.PermanentEmployee;
            lblError.Text = "";

        }
        else
        {
            
            txtName.Text = "";
            txtEmail.Text = "";
            txtRole.Text = "";
            txtPassword.Text = "";
            Calendar.SelectedDate = AStaff.DateofBirth;
            chkPermanentEmployee.Checked = false;
            lblError.Text = "Record could not be found";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

        Response.Redirect("StaffList.aspx");
    }

    protected void btnreturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}