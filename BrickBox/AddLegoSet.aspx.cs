using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddLegoSet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void addSetBtn_Click(object sender, EventArgs e)
    {
        Server.Transfer("ViewLegoSetInventory.aspx");

    }
    protected void clearBtn_Click(object sender, EventArgs e)
    {
        setNameTextBox.Text = "";
        setNumberTextBox.Text = "";
        pieceCountTextBox.Text = "";
        msrpTextBox.Text = "";
    }
}