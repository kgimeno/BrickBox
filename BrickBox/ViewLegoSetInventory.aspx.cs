using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewLegoSet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void legoSetInventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void viewBtn_Click(object sender, EventArgs e)
    {
        Server.Transfer("ViewLegoSet.aspx");
    }
  
    protected void navigateToAddSetbtn_Click(object sender, EventArgs e)
    {
        Server.Transfer("AddLegoSet.aspx");
    }
}