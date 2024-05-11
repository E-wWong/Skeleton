using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    
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

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the house no
        AnOrder.orderId = Convert.ToInt32(txtorderId.Text);
        AnOrder.totalItems = Convert.ToInt32(txtTotalItems.Text);
        AnOrder.totalPrice = Convert.ToDouble(txtTotalPrice.Text);
        AnOrder.address = txtAddressLine1.Text + "-" + txtAddressLine2.Text + "-" + txtTownCity.Text + "-" + txtCounty.Text + "-" + txtPostcode.Text;
        AnOrder.orderDate = Convert.ToDateTime(DateTime.Now );
        AnOrder.isAGift = chkYes.Checked;
        AnOrder.itemCodes = txtItemCodes.Text;
        //store the address in the session object
        Session ["AnOrder"] = AnOrder;
        //navigate to the view page
        Response.Redirect("OrderViewer.aspx");
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
            Calendar1.SelectedDate = AnOrder.orderDate;
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

                address = address.Substring(hIndex + 2);
                aIndex ++;

            }
            totalAddress[aIndex] = address.Substring(0);

            if (totalAddress[3] != "")
            {
                txtAddressLine1.Text = totalAddress[0];
                txtAddressLine2.Text = ("");
                txtTownCity.Text = totalAddress[1];
                txtCounty.Text = totalAddress[2];
                txtPostcode.Text = totalAddress[3];
            }
            else
            {
                txtAddressLine1.Text = totalAddress[0];
                txtAddressLine2.Text = totalAddress[1];
                txtTownCity.Text = totalAddress[2];
                txtCounty.Text = totalAddress[3];
                txtPostcode.Text = totalAddress[4];

            }



        }

    }
}