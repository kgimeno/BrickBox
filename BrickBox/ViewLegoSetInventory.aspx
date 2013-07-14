<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewLegoSetInventory.aspx.cs" Inherits="ViewLegoSet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="viewLegoSetLbl" runat="server" Text="Showing inventory of Lego sets to select from"></asp:Label>
        <br />
        <br />
        <asp:ListBox ID="legoSetInventoryListBox" runat="server" Height="103px" Width="526px" OnSelectedIndexChanged="legoSetInventoryListBox_SelectedIndexChanged">
            <asp:ListItem>R2D2</asp:ListItem>
        </asp:ListBox>
    
    </div>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="viewBtn" runat="server" Text="View selected set" OnClick="viewBtn_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="navigateToAddSetbtn" runat="server" OnClick="navigateToAddSetbtn_Click" Text="Add new set to Lego inventory" />
    </form>
</body>
</html>
