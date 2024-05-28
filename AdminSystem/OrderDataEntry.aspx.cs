using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 orderId;
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox4_TextChanged1(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void txtTotalPrice_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtOrderId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox4_TextChanged2(object sender, EventArgs e)
    {

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        orderId = Convert.ToInt32(Session["orderId"]);
        if (IsPostBack ==false)
        {
            //if this is not a new record
            if (orderId !=-1)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the house no
        string orderId = txtorderId.Text;
        string totalItems = txtTotalItems.Text;
        string totalPrice = txtTotalPrice.Text;
        string address = txtAddressLine1.Text + "-" + txtAddressLine2.Text + "-" + txtTownCity.Text + "-" + txtCounty.Text + "-" + txtPostcode.Text;
        string orderDate = corderDate.SelectedDate.ToString();
        string isAGift = chkYes.Text;
        string itemCodes = txtItemCodes.Text;
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(totalItems, totalPrice, address, orderDate, itemCodes);
        if (Error == "") 
        {
            //capture the order no
            AnOrder.totalItems = Convert.ToInt32(txtTotalItems.Text);
            AnOrder.totalPrice = Convert.ToDouble(txtTotalPrice.Text);
            AnOrder.address = txtAddressLine1.Text + "-" + txtAddressLine2.Text + "-" + txtTownCity.Text + "-" + txtCounty.Text + "-" + txtPostcode.Text;
            AnOrder.orderDate = Convert.ToDateTime(corderDate.SelectedDate);
            AnOrder.itemCodes = txtItemCodes.Text;
            AnOrder.isAGift = chkYes.Checked;
            clsOrderCollection OrderList = new clsOrderCollection();
            //set the ThisOrder property
            OrderList.ThisOrder = AnOrder;
            OrderList.Add();
            //redirect back to the list page
            Response.Redirect("OrderViewer.aspx");
           
        }
        else
        {
            //display the errror message 
            lblError.Text = Error;
        }
      
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsOrder AnOrder = new clsOrder();
        //create a variable to store the primary key
        Int32 orderId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        orderId = Convert.ToInt32(txtorderId.Text);
        //find the record
        Found = AnOrder.Find(orderId);
        //if found
        if (Found  == true)
        {
            //display the values of the properties in the form
            txtTotalItems.Text = AnOrder.totalItems.ToString();
            txtTotalPrice.Text = AnOrder.totalPrice.ToString();
            txtTotalItems.Text = AnOrder.totalItems.ToString();
            corderDate.SelectedDate = AnOrder.orderDate;
            chkYes.Checked = AnOrder.isAGift;
            txtItemCodes.Text = AnOrder.itemCodes;

            String address = AnOrder.address;

            String[] totalAddress = new string[5];
            int aIndex = 0;
            
            while (address.Contains("-"))
            {
                int hIndex = 0;
                hIndex = address.IndexOf("-");
                totalAddress[aIndex] = address.Substring(0, hIndex);

                address = address.Substring(hIndex + 1);
                aIndex ++;

            }
            totalAddress[aIndex] = address.Substring(0);

            
                txtAddressLine1.Text = totalAddress[0];
                txtAddressLine2.Text = totalAddress[1];
                txtTownCity.Text = totalAddress[2];
                txtCounty.Text = totalAddress[3];
                txtPostcode.Text = totalAddress[4];
     
        }

    }

    protected void orderDate_SelectionChanged(object sender, EventArgs e)
    {

    }
    void DisplayOrder()
    {
        //create an instance of the address book
        clsOrderCollection Order = new clsOrderCollection();
        //find the record to update
        Order.ThisOrder.Find(orderId);
        //display the data for the record
        txtorderId.Text = Order.ThisOrder.orderId.ToString();
        txtTotalItems.Text = Order.ThisOrder.totalItems.ToString();
        txtTotalPrice.Text = Order.ThisOrder.totalPrice.ToString();
        txtTotalItems.Text = Order.ThisOrder.totalItems.ToString();
        corderDate.SelectedDate = Order.ThisOrder.orderDate;
        chkYes.Checked = Order.ThisOrder.isAGift;
        txtItemCodes.Text = Order.ThisOrder.itemCodes;

    }
}