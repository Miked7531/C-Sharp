<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PostageCalcChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Postal Calculator<br />
            <br />
            Width:
            <asp:TextBox ID="widthTextBox" runat="server"></asp:TextBox>
            <br />
            Height:
            <asp:TextBox ID="heightTextBox" runat="server"></asp:TextBox>
            <br />
            Length:
            <asp:TextBox ID="lengthTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="groundRadio" runat="server" Text="Ground" GroupName="deliveryGroup" />
            <br />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Air" GroupName="deliveryGroup" />
            <br />
            <asp:RadioButton ID="nextRadio" runat="server" GroupName="deliveryGroup" Text="Next Day" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
