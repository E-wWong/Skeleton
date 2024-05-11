using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //create a new instance of clsStaffID
        clsStaff AStaff = new clsStaff();
        //get the data from the session object
        AStaff = (clsStaff)Session["AStaff"];
        //display the StaffID for this entry
        Response.Write(AStaff.StaffID + " ");
        //display the Name for this entry
        Response.Write(AStaff.name  + " ");
        //display the Email for this entry
        Response.Write(AStaff.email + " ");
        //display the Role for this entry
        Response.Write(AStaff.role + " ");
        //display the Password for this entry
        Response.Write(AStaff.password + " ");
        //display the PermanentEmployee for this entry
        Response.Write(AStaff.PermanentEmployee + " ");
        //display the DateofBirth for this entry
        Response.Write(AStaff.DateofBirth + " ");

    }
}