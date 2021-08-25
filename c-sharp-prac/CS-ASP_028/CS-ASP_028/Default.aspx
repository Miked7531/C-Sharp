<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_028.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Convert to Cups<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="cupsRadio" runat="server" AutoPostBack="True" GroupName="measurements" OnCheckedChanged="cupsRadio_CheckedChanged" Text="Cups" />
            <br />
            <asp:RadioButton ID="pintRadio" runat="server" AutoPostBack="True" GroupName="measurements" OnCheckedChanged="pintRadio_CheckedChanged" Text="Pints" />
            <br />
            <asp:RadioButton ID="quartsRadio" runat="server" AutoPostBack="True" GroupName="measurements" OnCheckedChanged="quartsRadio_CheckedChanged" Text="Quarts" />
            <br />
            <asp:RadioButton ID="gallonRadio" runat="server" AutoPostBack="True" GroupName="measurements" OnCheckedChanged="gallonRadio_CheckedChanged" Text="Gallon" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
