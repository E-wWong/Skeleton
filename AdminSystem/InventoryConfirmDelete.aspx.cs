using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 itemID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        itemID = Convert.ToInt32(Session["itemID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //cretae a new instance of the inventory book collection class
        clsInventoryManagementCollection InventoryBook = new clsInventoryManagementCollection();
        //find the record to delete
        InventoryBook.ThisInventory.Find(itemID);
        //delete the record
        InventoryBook.Delete();
        //redirect back to the main page
        Response.Redirect("InventoryList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("InventoryList.aspx");
    }
}