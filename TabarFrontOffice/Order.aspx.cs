using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TabarClasses;

public partial class Order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first apperance of this form 
        if (IsPostBack == false)
        {
            //display all Order
            DisplayOrder("");
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value 
        Int32 OrderID;
        //check the list has been clicked first 
        if (lstOrder.SelectedIndex != -1)
        {
            //get the primary key value from the list box
            OrderID = Convert.ToInt32(lstOrder.SelectedValue);
            //redirect to the edit page 
            Response.Redirect("Delete.aspx?OrderID=" + OrderID);
        }
        else
        {
            //display an error message 
            lblError.Text = "You must select an item off the list first to delete it.";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //redirect to the new add page
        Response.Redirect("AnOrder.aspx?OrderID=-1");
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //display all the Order
        DisplayOrder("");
    }

    Int32 DisplayOrder(string ItemTypeFilter)
    {
        Int32 OrderID; //var to store the primary key 
        string ItemName; //var to store the item name
        string ItemType; // var to store the ItemType
        clsOrderCollection MyOrderCollection = new clsOrderCollection();
        //create an instance of the Order collection class
        MyOrderCollection.ReportByItemType(ItemTypeFilter);
        //create an instance of the Order collection class 
        Int32 RecordCount;//var to store the count of records 
        Int32 Index = 0;//var to store the index for the loop
        RecordCount = MyOrderCollection.Count;//get the count of records 
        lstOrder.Items.Clear();//clear the list box 
        while (Index < RecordCount)//while there are records to process
        {
            OrderID =  MyOrderCollection.OrderList[Index].OrderID;//get the primary key
            ItemName = MyOrderCollection.OrderList[Index].ItemName;// get the ItemName 
            ItemType = MyOrderCollection.OrderList[Index].ItemType;//get the ItemType
            //create a new entry for the list box 
            ListItem NewEntry = new ListItem(ItemName + "  ,   " + ItemType, OrderID.ToString());
            lstOrder.Items.Add(NewEntry);//add the Order to the list
            Index++;//move the index to the next record 
        }
        return RecordCount;// return the count of records found

    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value 
        Int32 OrderID;
        //check the list has been clicked first 
        if (lstOrder.SelectedIndex != -1)
        {
            //get the primary key value from the list box
            OrderID = Convert.ToInt32(lstOrder.SelectedValue);
            //redirect to the editing page 
            Response.Redirect("AnOrder.aspx?OrderID=" + OrderID);
        }
        else
        {
            //display an error message 
            lblError.Text = "You must select an item from the list first, to edit it.";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //display only games matching the text in the publisher box
        DisplayOrder(txtItemType.Text);
    }
}
