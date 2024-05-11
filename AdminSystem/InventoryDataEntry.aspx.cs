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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsInventoryManagement
        clsInventoryManagement AnInventory = new clsInventoryManagement();
        //capture ItemId
        AnInventory.itemID = Convert.ToInt32(txtitemID.Text);
        //capture itemName
        AnInventory.itemName = txtitemName.Text;
        //capture itemPrice
        AnInventory.itemPrice = Convert.ToDouble(txtitemPrice.Text);
        // capture quantity
        AnInventory.quantity = Convert.ToInt32(txtitemID.Text);
        // capture size
        AnInventory.size = txtitemName.Text;
        //capture lastStockDelivery
        AnInventory.lastStockDelivery = Convert.ToDateTime(clndrStockDelivery.SelectedDate);
        //availability
        AnInventory.availability = ChkActive.Checked;
        //store the item ID in the session object
        Session["AnInventory"] = AnInventory;
        //navigate to the view page
        Response.Redirect("InventoryViewer.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsInventoryManagement AnInventory = new clsInventoryManagement();
        //create a variable to store primarykey
        Int32 itemId;
        //create a variable to store the result of the find operation
        Boolean found = false;
        //get the primary key entered by the user
        itemId = Convert.ToInt32(txtitemID.Text);
        //find the record
        found = AnInventory.Find(itemId);
        //if found
        if (found == true)
        {
            //display the values of the properties in the form
            txtitemName.Text = AnInventory.itemName;
            txtitemPrice.Text = AnInventory.itemPrice.ToString();
            txtquantity.Text = AnInventory.quantity.ToString();
            txtsize.Text = AnInventory.size;
            clndrStockDelivery.SelectedDate = AnInventory.lastStockDelivery;
            ChkActive.Checked = AnInventory.availability;

        }
    }
}