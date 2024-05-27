using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ClassLibrary;
using System.Web.UI.WebControls;


public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be deleted from the session object
        StaffID = Convert.ToInt32(Session["StaffID"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the staff data collection class
        clsStaffCollection StaffData = new clsStaffCollection();
        //find the record to delete
        StaffData.ThisStaff.Find(StaffID);
        //delete the record
        StaffData.Delete();
        //redirect back to the main page
        Response.Redirect("StaffList.aspx");


    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }
}