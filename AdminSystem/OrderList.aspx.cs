using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_List : System.Web.UI.Page
{ Int32 orderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        orderId = Convert.ToInt32(Session["orderId"]);
        if (!IsPostBack == false)
        {
         
            
          DisplayOrder();

        }

     }
    void DisplayOrder()
    {
        //create an instance of the Order collection
        clsOrderCollection Order = new clsOrderCollection();
        //set the data source to list of addresses in the collection
        lstOrderList.DataSource = Order.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the data field to display
        lstOrderList.DataTextField = "OrderId";
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["orderId"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 orderId;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        { 
            //get he primary key value of the record to edit
            orderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data i the session oject
            Session["orderId"] = orderId;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else  //if no record has been selected
        
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted 
        Int32 orderId;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the reord delete
            orderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["orderId"] = orderId;
            //redirect to the delete page
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error message
            lblError.Text = "Pleaase select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsOrderCollection AnOrder = new clsOrderCollection();
        AnOrder.ReportByItemCodes(txtFilter.Text);
        lstOrderList.DataSource = AnOrder.OrderList;
        lstOrderList.DataValueField = "orderId";
        lstOrderList.DataTextField = "itemCodes";
        lstOrderList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsOrderCollection AnOrder = new clsOrderCollection();
        AnOrder.ReportByItemCodes("");
        txtFilter.Text = "";
        lstOrderList.DataSource = AnOrder.OrderList;
        lstOrderList.DataValueField = "orderId";
        lstOrderList.DataTextField = "itemCodes";
        lstOrderList.DataBind();

    }
}