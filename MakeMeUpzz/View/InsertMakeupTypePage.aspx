<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertMakeupTypePage.aspx.cs" Inherits="MakeMeUpzz.View.InsertMakeupType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label ID="LabelName" runat="server" Text="MakeupTypeName"></asp:Label>
                <asp:TextBox ID="MakeupTypeName" runat="server"></asp:TextBox>
            </div>

            <asp:Button ID="InsertMakeup" runat="server" Text="InsertMakeup" OnClick="InsertMakeup_Click" />
            <asp:Button ID="ManageMakeup" runat="server" Text="ManageMakeupPage" OnClick="ManageMakeup_Click" />

        </div>

    </form>
</body>
</html>
