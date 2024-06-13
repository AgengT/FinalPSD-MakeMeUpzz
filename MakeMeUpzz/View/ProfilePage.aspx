<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="MakeMeUpzz.View.ProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <form>
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
            </div>
        </form>

        <form>
            <h1>Profile</h1>
            <div>
                <asp:Label ID="LabelUsername" runat="server" Text="Username: "></asp:Label>
                <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>

            </div>

            <div>
                <asp:Label ID="LabelEmail" runat="server" Text="Email: "></asp:Label>
                <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>


            </div>

            <div>
                <asp:Label ID="LabelGender" runat="server" Text="Gender: "></asp:Label>
                <asp:RadioButtonList ID="RadioButtonGender" runat="server">
                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                </asp:RadioButtonList>

            </div>

            <div>
                <asp:Label ID="LabelRegisterPassword" runat="server" Text="Password: "></asp:Label>
                <asp:TextBox ID="TextBoxRegisterPassword" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="LabelConfirmPassword" runat="server" Text="Confirm Password: "></asp:Label>
                <asp:TextBox ID="TextBoxConfirmPassword" runat="server"></asp:TextBox>

            </div>
            <div>
                <asp:Label ID="LabelCalenderDOB" runat="server" Text="Date Of Birth:"></asp:Label>
                <asp:Calendar ID="CalendarRegisterDOB" runat="server"></asp:Calendar>


            </div>
            <div>
                <asp:Label ID="LabelRole" runat="server" Text="Role"></asp:Label>
                <asp:TextBox ID="TextBoxRole" runat="server"></asp:TextBox>
            </div>

            <asp:Button ID="UpdateProfile" runat="server" Text="UpdateProfile" />
        </form>

        <form>
            <h1>Change Password</h1>
            <div>
                <asp:Label ID="LabelOldPassword" runat="server" Text="Old Password"></asp:Label>
                <asp:TextBox ID="TextBoxOldPassword" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="LabelNewPassword" runat="server" Text="New Password"></asp:Label>
                <asp:TextBox ID="TextBoxNewPassword" runat="server"></asp:TextBox>
            </div>

            <asp:Button ID="UpdatePassword" runat="server" Text="UpdatePassword" />
        </form>
    </form>
</body>
</html>
