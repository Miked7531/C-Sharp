<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleCalculatorweb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
            <p>
                <span class="auto-style1">First Value: </span>
                <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <span class="auto-style1">Second Value:</span>
                <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="plusButton" runat="server" OnClick="plusButton_Click" Text="+" />
&nbsp;
                <asp:Button ID="subtractButton" runat="server" OnClick="subtractButton_Click" Text="-" />
&nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="*" />
&nbsp;
                <asp:Button ID="divideButton" runat="server" OnClick="divideButton_Click" Text="/" />
            </p>
            <p>
                <asp:Label ID="resultLabel" runat="server" BackColor="#66CCFF" Font-Bold="True" Font-Size="Larger"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
