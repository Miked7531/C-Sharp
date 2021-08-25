<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_13_pizza_challenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: 40pt;
        }
        .auto-style2 {
            color: #FF0000;
            font-size: large;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style3 {
            font-size: large;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style4 {
            width: 200px;
            height: 200px;
        }
        .auto-style5 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style1"><strong>
                <img alt="" class="auto-style4" src="PapaBob.png" /><span class="auto-style5">Papa Bob&#39;s Pizza and Software</span></strong></h1>
            <br />
            <br />
            <br />
            <asp:RadioButton ID="sizebutton1" runat="server" GroupName="pizzaSize" Text="Baby Bob Size (10&quot;) - $10" />
            <br />
            <asp:RadioButton ID="sizebutton2" runat="server" GroupName="pizzaSize" Text="Mama Bob Size (13&quot;) - $13" />
            <br />
            <asp:RadioButton ID="sizebutton3" runat="server" GroupName="pizzaSize" Text="Papa Bob Size (16&quot;) - $16" />
            <br />
            <br />
            <asp:RadioButton ID="thinButton" runat="server" GroupName="crust" Text="Thin Crust" />
            <br />
            <asp:RadioButton ID="deepButton" runat="server" GroupName="crust" Text="Deep Dish (+$2)" />
            <br />
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Pepperoni (+$1.50)" />
            <br />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Onions (+0.75)" />
            <br />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Green Peppers (+$0.50)" />
            <br />
            <asp:CheckBox ID="CheckBox4" runat="server" Text="Red Peppers (+$0.75)" />
            <br />
            <asp:CheckBox ID="CheckBox5" runat="server" Text="Anchovies (+$2)" />
            <br />
            <br />
            <strong><span class="auto-style3">Papa Bob&#39;s</span></strong> <span class="auto-style2"><strong>Special Deal</strong></span><br class="auto-style5" />
            <br />
            Save $2.00 when you add Pepperoni, Green Peppers and Anchovices OR Pepperoni, Red Peppers and Onions to you pizza.<br />
            <br />
            <asp:Button ID="purchaseButton" runat="server" BorderStyle="Groove" OnClick="purchaseButton_Click" style="background-color: #FFCCCC" Text="Purchase" />
            <br />
            <br />
            Total:
            <asp:Label ID="resultLabel" runat="server" Text="$0.00"></asp:Label>
            <br />
            <br />
            Sorry, at this time you can only order one pizza online, and pick-up only ... we need a better website!</div>
    </form>
</body>
</html>
