using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TabarClasses; 

public partial class CarTypeAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsCarType ACarType = new clsCarType();
        string Error;
        String CarTypeName;
        CarTypeName = txtCarType.Text;
        Error = ACarType.Valid(CarTypeName);
        lblCarType.Text = Error;
    }
}