<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertMakeupPage.aspx.cs" Inherits="MakeMeUpzz.View.InsertMakeupPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
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
                <asp:Button ID="ManageMakeup" runat="server" Text="ManageMakeupPage" OnClick="ManageMakeup_Click" />

        </div>
    </form>
</body>
</html>
