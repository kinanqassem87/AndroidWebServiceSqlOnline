<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="User F_name:"></asp:Label>
            <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="User L_name:"></asp:Label>
            <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        </div>
    </form>
</body>
</html>
