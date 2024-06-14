<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="MakeMeUpzz.View.TransactionDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="TransactionHeaders.TransactionID" HeaderText="Transaction ID" SortExpression="Transaction ID" />
            <asp:BoundField DataField="Makeups.MakeupID" HeaderText="Makeup ID" SortExpression="Makeup ID" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"/>
        </Columns>
    </asp:GridView>
</asp:Content>
