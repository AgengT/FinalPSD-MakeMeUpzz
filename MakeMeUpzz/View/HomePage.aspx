<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="MakeMeUpzz.View.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Order Makeup" OnClick="OrderMakeupClick" />
            <asp:Button ID="Button2" runat="server" Text="History" OnClick="HistoryClick" />
            <asp:Button ID="Button3" runat="server" Text="Profile" OnClick="ProfileClick" />
            <asp:Button ID="Button4" runat="server" Text="Logout" OnClick="LogoutClick" />
        </div>
    </form>
</body>
</html>
