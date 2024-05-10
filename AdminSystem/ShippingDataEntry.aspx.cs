using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
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
        AShipment.deliveryDate = Convert.ToDateTime(cDeliveryDate.SelectedDate);
        AShipment.orderID = Convert.ToInt32(txtOrderID.Text);
        AShipment.isDispatched = chkIsDispatched.Checked;
        //Store the data in the session object
        Session["AShipment"] = AShipment;
        //navigate to the view page
        Response.Redirect("ShippingViewer.aspx");
    }

    protected void txtAddressLine1_TextChanged(object sender, EventArgs e)
    {

    }


    protected void Button1_Click1(object sender, EventArgs e)
    {
        //create an instance of the shipping class
        clsShipping AShipment = new clsShipping();
        //create a variable to store the primary key
        Int32 ShippingID;
        //create a variable to store the result of the find operation
        Boolean found = false;
        //get the primary key entered by the user
        ShippingID = Convert.ToInt32(txtShippingID.Text);
        //find the record
        found = AShipment.Find(ShippingID);
        //if found
        if (found == true)
        {
            //display the values of the properties in the form
            //displaying the address
            String address = AShipment.address;

            String[] totalAddress = new string[5];
            int aIndex = 0;

            while (address.Contains("-"))
            {
                int hIndex = 0;
                hIndex = address.IndexOf("-");
                totalAddress[aIndex] = address.Substring(0, hIndex);

                address = address.Substring(hIndex + 1);
                aIndex++;
            }

            totalAddress[aIndex] = address.Substring(0);

            if (totalAddress[4] != "")
            {
                txtAddressLine1.Text = totalAddress[0];
                txtAddressLine2.Text = " ";
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

            //displaying the deliveryType
            if (AShipment.deliveryType == "Tracked")
            {
                rblDeliveryType.SelectedIndex = -1;
                rblDeliveryType.Items[0].Selected = true;
            }
            else if (AShipment.deliveryType == "First Class")
            {
                rblDeliveryType.SelectedIndex = -1;
                rblDeliveryType.Items[1].Selected = true;
            }
            else if (AShipment.deliveryType == "Second Class")
            {
                rblDeliveryType.SelectedIndex = -1;
                rblDeliveryType.Items[2].Selected = true;
            }
            else
            {
                rblDeliveryType.SelectedIndex = -1;
            }
            //displaying the parcelType
            if (AShipment.parcelSize == "Small")
            {
                rblParcelSize.SelectedIndex = -1;
                rblParcelSize.Items[0].Selected = true;
            }
            else if (AShipment.parcelSize == "Medium")
            {
                rblParcelSize.SelectedIndex = -1;
                rblParcelSize.Items[1].Selected = true;
            }
            else if (AShipment.parcelSize == "Large")
            {
                rblParcelSize.SelectedIndex = -1;
                rblParcelSize.Items[2].Selected = true;
            }
            else
            {
                rblDeliveryType.SelectedIndex = -1;
            }
            //displaying the deliveryDate
            //cDeliveryDate.SelectedDates.Clear();
            cDeliveryDate.SelectedDate = (AShipment.deliveryDate);
            //displaying the orderID
            txtOrderID.Text = AShipment.orderID.ToString();
            //displaying the isDispatched
            chkIsDispatched.Checked = AShipment.isDispatched;
        } 
    }
}
