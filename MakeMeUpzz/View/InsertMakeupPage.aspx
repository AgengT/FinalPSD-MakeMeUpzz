<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertMakeupPage.aspx.cs" Inherits="MakeMeUpzz.View.InsertMakeupPage" %>

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
                <asp:Label ID="LabelName" runat="server" Text="MakeupName"></asp:Label>
                <asp:TextBox ID="MakeupName" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="LabelPrice" runat="server" Text="MakeupPrice"></asp:Label>
                <asp:TextBox ID="MakeupPrice" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="LabelWeight" runat="server" Text="MakeupWeight"></asp:Label>
                <asp:TextBox ID="MakeupWeight" runat="server"></asp:TextBox>

            </div>
            <div>
                <asp:Label ID="LabelTypeID" runat="server" Text="MakeupTypeID"></asp:Label>
                <asp:TextBox ID="MakeupTypeID" runat="server"></asp:TextBox>

            </div>
            <div>
                <asp:Label ID="LabelBrandID" runat="server" Text="MakeupBrandID"></asp:Label>
                <asp:TextBox ID="MakeupBrandID" runat="server"></asp:TextBox>
            </div>

            <asp:Button ID="InsertMakeup" runat="server" Text="InsertMakeup" OnClick="InsertMakeup_Click" />
            <asp:Button ID="ManageMakeup" runat="server" Text="ManageMakeupPage" OnClick="ManageMakeup_Click3" />

        </div>
    </form>
</body>
</html>
