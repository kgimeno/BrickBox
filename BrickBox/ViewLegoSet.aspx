<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewLegoSet.aspx.cs" Inherits="VewLegoSetInventory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;
        <asp:Label ID="setNameLbl" runat="server" Text="Name of set:"></asp:Label>
&nbsp;
        <asp:Label ID="theSetNameLbl" runat="server"></asp:Label>
&nbsp;<br />
&nbsp;<asp:Label ID="setNumberLbl" runat="server" Text="ID number of set:"></asp:Label>
&nbsp;
        <asp:Label ID="theSetNumberLbl" runat="server"></asp:Label>
&nbsp;<br />
&nbsp;<asp:Label ID="pieceCountLbl" runat="server" Text="Number of pieces included with the set:"></asp:Label>
&nbsp;
        <asp:Label ID="thePieceCountLbl" runat="server"></asp:Label>
&nbsp;<br />
&nbsp;<asp:Label ID="msrpLbl" runat="server" Text="MSRP:"></asp:Label>
&nbsp;<asp:Label ID="theMsrpLbl" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        &nbsp;
        <asp:Button ID="removeSetBtn" runat="server" Text="Remove Lego set from inventory" OnClick="removeSetBtn_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="removeSetMessageLbl" runat="server"></asp:Label>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="viewLegosBtn" runat="server" OnClick="viewLegosBtn_Click" Text="View Lego inventory" />
    
    </div>
    </form>
</body>
</html>
