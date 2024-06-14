<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="MakeMeUpzz.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
       <asp:Label ID="LabelUsername" runat="server" Text="Username: "></asp:Label>
         <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>
         <asp:Label ID="LabelErrorUsername" runat="server" Text=" "></asp:Label>
    </div>

    <div>
        <asp:Label ID="LabelEmail" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
        <asp:Label ID="LabelErrorEmail" runat="server" Text=" "></asp:Label>

    </div>

    <div>
        <asp:Label ID="LabelGender" runat="server" Text="Gender: "></asp:Label>
        <asp:RadioButtonList ID="RadioButtonGender" runat="server">
            <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
            <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="LabelErrorGender" runat="server" Text=" "></asp:Label>
    </div>
   
    <div>
        <asp:Label ID="LabelRegisterPassword" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="TextBoxRegisterPassword" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="LabelConfirmPassword" runat="server" Text="Confirm Password: "></asp:Label>
        <asp:TextBox ID="TextBoxConfirmPassword" runat="server"></asp:TextBox>
        <asp:Label ID="LabelErrorConfirmPassword" runat="server" Text=" "></asp:Label>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Date Of Birth:"></asp:Label>
        <asp:Calendar ID="CalendarRegisterDOB" runat="server"></asp:Calendar>
        <asp:Label ID="LabelErrorDOB" runat="server" Text=" "></asp:Label>

    </div>
     <div>
        <asp:Button ID="ButtonRegister" runat="server" Text="Register" OnClick="ButtonRegister_Click" />
    </div>
    <div>
         <asp:HyperLink ID="HyperLink1" NavigateUrl="~/View/LoginPage.aspx"  runat="server">Already Have an Account?</asp:HyperLink>
    </div>
    </form>
</body>
</html>
