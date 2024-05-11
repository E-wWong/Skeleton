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
}