﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TabarClasses;

public partial class AnOrder : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be edited
    Int32 OrderID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //copy the data from the query string to the text box cardid
        OrderID = Convert.ToInt32(Request.QueryString["OrderID"]);
        if (IsPostBack != true)
        {
            //if this is not a new record
            DisplayItemType();
            //if the carid is not -1 then display the data from the record
            if (OrderID != -1)
            {
                //display the existing data
                DisplayOrder(OrderID);
            }
        }
    }

    ////event handler for the ok button
    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (OrderID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //updaate the record
            Update();
        }
        //all done so redirect back to the main page
        Response.Redirect("Order.aspx");
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the car log
        clsOrderCollection OrderLog = new clsOrderCollection();
        //validate the date on the web form
        String Error = OrderLog.ThisOrder.Valid(txtItemName.Text, txtQuantity.Text, txtDate.Text, txtPrice.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            OrderLog.ThisOrder.ItemName = txtItemName.Text;
            OrderLog.ThisOrder.Quantity = Convert.ToInt32(txtQuantity.Text);
            OrderLog.ThisOrder.Price = Convert.ToInt32(txtPrice.Text);
            OrderLog.ThisOrder.Date = txtDate.Text;
            OrderLog.ThisOrder.Quality = chkNew.Checked = true;
            OrderLog.ThisOrder.ItemType = ddlItemType.Text;
            //add the record
            OrderLog.Add();
            //all done to redirect back to the main page
            Response.Redirect("Order.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "there were problems with the data entered" + Error;
        }
    }

    void Update()
    {
        //create an instance of the car log
        TabarClasses.clsOrderCollection OrderLog = new TabarClasses.clsOrderCollection();
        //validate the date on the web form
        String Error = OrderLog.ThisOrder.Valid(txtItemName.Text, txtQuantity.Text, txtDate.Text, txtPrice.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            OrderLog.ThisOrder.Find(OrderID);
            //get the data entered by the user
            OrderLog.ThisOrder.ItemName = txtItemName.Text;
            OrderLog.ThisOrder.Quantity = Convert.ToInt32(txtQuantity.Text);
            OrderLog.ThisOrder.Price = Convert.ToInt32(txtPrice.Text);
            OrderLog.ThisOrder.Date = txtDate.Text;
            OrderLog.ThisOrder.Quality = chkNew.Checked = true;
            OrderLog.ThisOrder.ItemType = ddlItemType.Text;
            //update the record
            OrderLog.Update();
            //all done to redirect back to the main page
            Response.Redirect("Order.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "there were problems with the data entered" + Error;
        }
    }

    void DisplayOrder(Int32 OrderID)
    {
        //create an instance of the car log
        clsOrderCollection OrderLog = new clsOrderCollection();
        //find the record to update
        OrderLog.ThisOrder.Find(OrderID);
        //display the car name
        txtItemName.Text = OrderLog.ThisOrder.ItemName;
        //display the model
        txtQuantity.Text = Convert.ToString(OrderLog.ThisOrder.Quantity);
        //display the price
        txtPrice.Text = Convert.ToString(OrderLog.ThisOrder.Price);
        //display the year made
        txtDate.Text = OrderLog.ThisOrder.Date;
        //display the check boxes
        chkNew.Checked = OrderLog.ThisOrder.Quality = true;
        //display the drop down list
        ddlItemType.SelectedValue = Convert.ToString(OrderLog.ThisOrder.ItemType);
    }

    //function for populating the colour drop down list
    void DisplayItemType()
    {
        //create an instance of the Colour Collection
        clsItemTypeCollection ItemType = new clsItemTypeCollection();
        //set the data source to the list of colours in the collection
        ddlItemType.DataSource = ItemType.AllItemType;
        //set the name of the primary key
        ddlItemType.DataValueField = "ItemTypeNo";
        //set the data field to display
        ddlItemType.DataTextField = "ItemType";
        //bind the data to the list
        ddlItemType.DataBind();
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Order.aspx");
    }

    protected void ddlItemType_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
