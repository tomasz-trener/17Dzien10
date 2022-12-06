<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P01AjaxWstep.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:TextBox ID="txtLiczba1" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtLiczba2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnPolicz" OnClick="btnPolicz_Click" runat="server" Text="Button" />
        <asp:TextBox ID="txtWynik" runat="server"></asp:TextBox>

    </form>
</body>
</html>
