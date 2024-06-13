<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionHistoryPage.aspx.cs" Inherits="MakeMeUpzz.View.TransactionHistoryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server">
        <Columns>
            <asp:BoundField DataField="TransactionHeaders.TransactionID" HeaderText="TransactionID" SortExpression="Transaction ID" />
            <asp:BoundField DataField="Makeups.MakeupID" HeaderText="Makeup ID" SortExpression="Transaction ID" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Transaction ID" />
        </Columns>

    </asp:GridView>
</asp:Content>
