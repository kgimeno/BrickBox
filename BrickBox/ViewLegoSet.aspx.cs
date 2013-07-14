using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VewLegoSetInventory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void viewLegosBtn_Click(object sender, EventArgs e)
    {
        Server.Transfer("ViewLegoSetInventory.aspx");
    }
    protected void removeSetBtn_Click(object sender, EventArgs e)
    {
        removeSetMessageLbl.Text = "Coming soon...";
    }
}