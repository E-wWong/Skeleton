using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    //variable to store the primary key with page level scope
    Int32 itemID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the inventory to be proceded
        itemID = Convert.ToInt32(Session["InventoryId"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (itemID != 0)
            {
                //display the current data for the record
                DisplayInventory();
            }
        }
    }

    void DisplayInventory()
    {
        //create an instance of the address book 
        clsInventoryManagementCollection InvenotoryBook = new clsInventoryManagementCollection();
        //find the record to update
        InvenotoryBook.ThisInventory.Find(itemID);
        //display the data for the record
        txtitemID.Text = InvenotoryBook.ThisInventory.itemID.ToString();
        txtitemName.Text = InvenotoryBook.ThisInventory.itemName.ToString();
        txtitemPrice.Text = InvenotoryBook.ThisInventory.itemPrice.ToString();
        txtquantity.Text = InvenotoryBook.ThisInventory.quantity.ToString();
        txtsize.Text = InvenotoryBook.ThisInventory.size.ToString();
        clndrStockDelivery.SelectedDate = InvenotoryBook.ThisInventory.lastStockDelivery;
        ChkActive.Checked = InvenotoryBook.ThisInventory.availability;
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        //create a new instace of clsInventoryManagement
        clsInventoryManagement AnInventory = new clsInventoryManagement();
        //capture the itemName
        string itemName = txtitemName.Text;
        //capture the itemPrice
        string itemPrice = txtitemPrice.Text;
        //capture the quantity
        string quantity = txtquantity.Text;
        //capture size
        string size = txtsize.Text;
        //capture lastStockDelivery
        string lastStockDelivery = clndrStockDelivery.SelectWeekText;
        //variable to store any error messages
        string Error = "";
        //validate data 
        Error = AnInventory.Valid(itemName, itemPrice, quantity, size, lastStockDelivery);
        if(Error == "")

    {
        AnInventory.itemID = itemID; //don't miss this bit !!!!!
        //capture itemName
        AnInventory.itemName = txtitemName.Text;
        //capture itemPrice
        AnInventory.itemPrice = Convert.ToDouble(txtitemPrice.Text);
        // capture quantity
        AnInventory.quantity = Convert.ToInt32(txtitemID.Text);
        // capture size
        AnInventory.size = txtsize.Text;
        //capture lastStockDelivery
        AnInventory.lastStockDelivery = Convert.ToDateTime(clndrStockDelivery.SelectedDate);
        //create new instance of the inventory collecetion
        AnInventory.availability = ChkActive.Checked;

            //create a new instance of the address collection
            clsInventoryManagementCollection InventoryList = new clsInventoryManagementCollection();

        if (itemID == 0)
            {
                //set the thisinventory property
                InventoryList.ThisInventory = AnInventory;
                //add the new record
                InventoryList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                InventoryList.ThisInventory.Find(itemID);
                //set the thisinventory property
                InventoryList.ThisInventory = AnInventory;
                //update the record
                InventoryList.Update();
            }
            //redirect back ti the list page
            Response.Redirect("Inventorylist.aspx");
    }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the list page
        Response.Redirect("InventoryList.aspx");
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
            if (AnInventory.size == "small")
            {
                txtsize.SelectedIndex = -1;
                txtsize.Items[0].Selected = true;
            }
            else if (AnInventory.size == "medium")
            {
                txtsize.SelectedIndex = -1;
                txtsize.Items[1].Selected = true;
            }
            else if (AnInventory.size == "large")
            {
                txtsize.SelectedIndex = -1;
                txtsize.Items[2].Selected = true;
            }
            clndrStockDelivery.SelectedDate = AnInventory.lastStockDelivery;
            clndrStockDelivery.VisibleDate = AnInventory.lastStockDelivery;
            ChkActive.Checked = AnInventory.availability;

        }
        else {
            txtitemName.Text = "";
            txtitemPrice.Text = "";
            txtquantity.Text = "";
            txtsize.SelectedIndex = -1;
            clndrStockDelivery.SelectedDate = AnInventory.lastStockDelivery;
            ChkActive.Checked = false;
            lblError.Text = "Record cannot be found";
        }


    }

    protected void btnReurnToPage_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("TeamMainMenu.aspx");
    }
}