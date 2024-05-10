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

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {

    }



    

    protected void txtTownCity_TextChanged(object sender, EventArgs e)
    {

    }

    protected void cDeliveryDate_SelectionChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsShipping
        clsShipping AShipment = new clsShipping();
        //capture some data
        AShipment.shippingID = Convert.ToInt32(txtShippingID.Text); 
        AShipment.address = txtAddressLine1.Text + "-" + txtAddressLine2.Text + "-" + txtTownCity.Text + "-" + txtCounty.Text + "-" + txtPostcode.Text;
        AShipment.deliveryType = rblDeliveryType.Text;
        AShipment.parcelSize = rblParcelSize.Text;
        AShipment.deliveryDate = Convert.ToDateTime(cDeliveryDate.TodaysDate);
        AShipment.orderID = Convert.ToInt32(txtOrderID.Text);
        AShipment.isDispatched = cbIsDispatched.Checked;
        //Store the data in the session object
        Session["AShipment"] = AShipment;
        //navigate to the view page
        Response.Redirect("ShippingViewer.aspx");
    }

    protected void txtAddressLine1_TextChanged(object sender, EventArgs e)
    {

    }
}