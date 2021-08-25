<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeConditionalRadioButton.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your note taking preferences<br />
            <br />
            <asp:RadioButton ID="pencilButton" runat="server" Text="Pencil" GroupName="noteGroup" />
            <br />
            <br />
            <asp:RadioButton ID="penButton" runat="server" Text="Pen" GroupName="noteGroup" />
            <br />
            <br />
            <asp:RadioButton ID="phoneButton" runat="server" Text="Phone" GroupName="noteGroup" />
            <br />
            <br />
            <asp:RadioButton ID="tabletButton" runat="server" Text="Tablet" GroupName="noteGroup" />
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" Text="OK" OnClick="okButton_Click" />
            <br />
            <br />
            <asp:Image ID="resultImage" runat="server" />
            <br />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
