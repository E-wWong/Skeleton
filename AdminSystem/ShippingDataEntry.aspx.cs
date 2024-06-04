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

    //variable to store the primary key with the page level scope
    Int32 shippingID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the shipment to be processed
        shippingID = Convert.ToInt32(Session["shippingID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (shippingID != 0)
            {
                //display the current data for the record
                DisplayShipment();
            }
        }
    }

    void DisplayShipment()
    {
        //create an instance of the shipment book
        clsShippingCollection shipmentBook = new clsShippingCollection();
        //find the record to update
        shipmentBook.ThisShipment.Find(shippingID);
        //display the data for the record
        txtShippingID.Text = shipmentBook.ThisShipment.shippingID.ToString();
        //displaying the address
        String address = shipmentBook.ThisShipment.address;

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

        txtAddressLine1.Text = totalAddress[0];
        txtAddressLine2.Text = totalAddress[1];
        txtTownCity.Text = totalAddress[2];
        txtCounty.Text = totalAddress[3];
        txtPostcode.Text = totalAddress[4];

        //displaying the deliveryType
        if (shipmentBook.ThisShipment.deliveryType == "Tracked")
        {
            rblDeliveryType.SelectedIndex = -1;
            rblDeliveryType.Items[0].Selected = true;
        }
        else if (shipmentBook.ThisShipment.deliveryType == "First Class")
        {
            rblDeliveryType.SelectedIndex = -1;
            rblDeliveryType.Items[1].Selected = true;
        }
        else if (shipmentBook.ThisShipment.deliveryType == "Second Class")
        {
            rblDeliveryType.SelectedIndex = -1;
            rblDeliveryType.Items[2].Selected = true;
        }
        else
        {
            rblDeliveryType.SelectedIndex = -1;
        }
        //displaying the parcelType
        if (shipmentBook.ThisShipment.parcelSize == "Small")
        {
            rblParcelSize.SelectedIndex = -1;
            rblParcelSize.Items[0].Selected = true;
        }
        else if (shipmentBook.ThisShipment.parcelSize == "Medium")
        {
            rblParcelSize.SelectedIndex = -1;
            rblParcelSize.Items[1].Selected = true;
        }
        else if (shipmentBook.ThisShipment.parcelSize == "Large")
        {
            rblParcelSize.SelectedIndex = -1;
            rblParcelSize.Items[2].Selected = true;
        }
        else
        {
            rblDeliveryType.SelectedIndex = -1;
        }
        //displaying the deliveryDate
        cDeliveryDate.SelectedDate = (shipmentBook.ThisShipment.deliveryDate);
        //displaying the orderID
        txtOrderID.Text = shipmentBook.ThisShipment.orderID.ToString();
        //displaying the isDispatched
        chkIsDispatched.Checked = shipmentBook.ThisShipment.isDispatched;

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
        //capture the data
        string address = txtAddressLine1.Text + "-" + txtAddressLine2.Text + "-" + txtTownCity.Text + "-" + txtCounty.Text + "-" + txtPostcode.Text;
        string deliveryType = rblDeliveryType.Text;
        string parcelSize = rblParcelSize.Text;
        string deliveryDate = cDeliveryDate.SelectedDate.ToString();
        string orderID = txtOrderID.Text;
        string isDispatched = chkIsDispatched.Text;

        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AShipment.Valid(address, deliveryType, parcelSize, deliveryDate, orderID);
        if (Error == "")
        {
            //capture some data
            AShipment.shippingID = shippingID;
            AShipment.address = txtAddressLine1.Text + "-" + txtAddressLine2.Text + "-" + txtTownCity.Text + "-" + txtCounty.Text + "-" + txtPostcode.Text;
            AShipment.deliveryType = rblDeliveryType.Text;
            AShipment.parcelSize = rblParcelSize.Text;
            AShipment.deliveryDate = Convert.ToDateTime(cDeliveryDate.SelectedDate);
            AShipment.orderID = Convert.ToInt32(txtOrderID.Text);
            AShipment.isDispatched = chkIsDispatched.Checked;
            //create a new instance of the shipping collection
            clsShippingCollection shippingList = new clsShippingCollection();

            //if this is a new record i.e. shippingID = 0 the a the data
            if (shippingID == 0)
            {
                //set the ThisAddress property
                shippingList.ThisShipment = AShipment;
                //add the new record
                shippingList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                shippingList.ThisShipment.Find(shippingID);
                //set the thisShipment property
                shippingList.ThisShipment = AShipment;
                //update the record
                shippingList.Update();
            }
            //redirect back to the list page
            Response.Redirect("ShippingList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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

            txtAddressLine1.Text = totalAddress[0];
            txtAddressLine2.Text = totalAddress[1];
            txtTownCity.Text = totalAddress[2];
            txtCounty.Text = totalAddress[3];
            txtPostcode.Text = totalAddress[4];

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
                rblParcelSize.SelectedIndex = -1;
            }
            //displaying the deliveryDate
            cDeliveryDate.SelectedDate = (AShipment.deliveryDate);
            //displaying the right month
            cDeliveryDate.VisibleDate = AShipment.deliveryDate;
            //displaying the orderID
            txtOrderID.Text = AShipment.orderID.ToString();
            //displaying the isDispatched
            chkIsDispatched.Checked = AShipment.isDispatched;
            lblError.Text = "";
        }
        else
        {
            txtAddressLine1.Text = "";
            txtAddressLine2.Text = "";
            txtTownCity.Text = "";
            txtCounty.Text = "";
            txtPostcode.Text = "";
            rblDeliveryType.SelectedIndex = -1;
            rblParcelSize.SelectedIndex = -1;
            cDeliveryDate.SelectedDate = (AShipment.deliveryDate);
            txtOrderID.Text = "";
            chkIsDispatched.Checked = false;
            lblError.Text = "Record could not be found";
        }
    }

    protected void btnCancel_Click1(object sender, EventArgs e)
    {
        Response.Redirect("ShippingList.aspx");
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}

