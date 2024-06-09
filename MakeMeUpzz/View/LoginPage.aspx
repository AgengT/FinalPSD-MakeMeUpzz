<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="MakeMeUpzz.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelUsername" runat="server" Text="Username: "></asp:Label><asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>
             <asp:Label ID="LabelPassword" runat="server" Text="Password: "></asp:Label><asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonLogin" runat="server" Text="Submit" />
        </div>
        <div>
            <asp:CheckBox ID="CheckBoxRememberMe" runat="server" Text="Remember Me"/>
        </div>
        <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
        <div>
            <asp:Button ID="ButtonRegister" runat="server" Text="Register an Account?" OnClick="ButtonRegister_Click" /> 
        </div>
    </form>
</body>
</html>
