<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_013.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Is
            <asp:TextBox ID="textBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="comparisonTypeLabel" runat="server"></asp:Label>
&nbsp;<asp:TextBox ID="textBox2" runat="server"></asp:TextBox>
            ?<br />
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="I am checked" />
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
            <br />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
