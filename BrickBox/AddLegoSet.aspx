<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddLegoSet.aspx.cs" Inherits="AddLegoSet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 540px">
        <asp:Label ID="setNameLbl" runat="server" Text="Name of set:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="setNameTextBox" runat="server" Width="408px">R2-D2</asp:TextBox>
        <br />
        <br />
        <asp:Label ID="setNumberLbl" runat="server" Text="ID number of set:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="setNumberTextBox" runat="server">10225</asp:TextBox>
        <br />
        <br />
        <asp:Label ID="pieceCountLbl" runat="server" Text="Number of pieces included with the set:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="pieceCountTextBox" runat="server" Width="88px">2127</asp:TextBox>
        <br />
        <br />
        <asp:Label ID="msrpLbl" runat="server" Text="MSRP:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="msrpTextBox" runat="server">$179.99</asp:TextBox>
        <br />
        <br />
        <asp:Button ID="addSetBtn" runat="server" Text="Add set to inventory" OnClick="addSetBtn_Click" />
        <br />
        <br />
        <asp:Button ID="clearBtn" runat="server" Text="Clear set information" OnClick="clearBtn_Click" />
    
    </div>
    </form>
</body>
</html>
