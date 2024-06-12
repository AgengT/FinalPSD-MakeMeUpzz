<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="MakeMeUpzz.View.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
            <asp:GridView ID="User" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="UserID" HeaderText="ID" SortExpression="UserID" />
                    <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                    <asp:BoundField DataField="UserEmail" HeaderText="UserEmail" SortExpression="UserEmail" />
                    <asp:BoundField DataField="UserDOB" HeaderText="UserDOB" SortExpression="UserDOB" />
                    <asp:BoundField DataField="UserGender" HeaderText="UserGender" SortExpression="UserGender" />
                    <asp:BoundField DataField="UserRole" HeaderText="UserRole" SortExpression="UserRole" />
                    <asp:BoundField DataField="UserPassword" HeaderText="UserPassword" SortExpression="UserPassword" />
                </Columns>

            </asp:GridView>
        </div>
    </form>
</body>
</html>
