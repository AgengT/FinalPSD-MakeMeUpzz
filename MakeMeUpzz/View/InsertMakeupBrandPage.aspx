<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertMakeupBrandPage.aspx.cs" Inherits="MakeMeUpzz.View.InsertMakeupBrandPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="Customer-Navbar">
                <asp:Button ID="Button1" runat="server" Text="Order Makeup" OnClick="OrderMakeupClick" />
                <asp:Button ID="Button2" runat="server" Text="History" OnClick="HistoryClick" />
                <asp:Button ID="Button3" runat="server" Text="Profile" OnClick="ProfileClick" />
                <asp:Button ID="Button4" runat="server" Text="Logout" OnClick="LogoutClick" />
            </div>

            <div id="Admin-Navbar">
                <asp:Button ID="Button5" runat="server" Text="Manage Makeup" OnClick="ManageMakeupClick2" />
                <asp:Button ID="Button6" runat="server" Text="Order Queue" OnClick="OrderQueueClick" />
                <asp:Button ID="Button7" runat="server" Text="Profile" OnClick="ProfileClick" />
                <asp:Button ID="Button8" runat="server" Text="Transaction Report" OnClick="TransactionReportClick" />
                <asp:Button ID="Button9" runat="server" Text="Logout" OnClick="LogoutClick" />
            </div>
            <div>
                <asp:Label ID="LabelName" runat="server" Text="MakeupBrandName"></asp:Label>
                <asp:TextBox ID="MakeupBrandName" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label1" runat="server" Text="MakeupBrandRating"></asp:Label>
                <asp:TextBox ID="MakeupBrandRating" runat="server"></asp:TextBox>
            </div>

            <asp:Button ID="InsertMakeupBrand" runat="server" Text="InsertMakeupBrand" OnClick="InsertMakeupBrand_Click" />
            <asp:Button ID="ManageMakeupBrand" runat="server" Text="ManageMakeupPage" OnClick="ManageMakeup_Click" />
        </div>
    </form>
</body>
</html>
