using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TabarClasses;

public partial class Delete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 OrderID;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        OrderID = Convert.ToInt32(Session["OrderD"]);

    }

    void DeleteOrder()
    {
        //function to delete the selected record

        //create a new instance of the car
        clsOrderCollection OrderLog = new clsOrderCollection();
        //find the record to delete
        OrderLog.ThisOrder.Find(OrderID);
        //delete the record
        OrderLog.Delete();
    }


    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteOrder();
        //redirect back to the main page
        Response.Redirect("Order.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to tthe main page 
        Response.Redirect("Order.aspx");
    }
}
