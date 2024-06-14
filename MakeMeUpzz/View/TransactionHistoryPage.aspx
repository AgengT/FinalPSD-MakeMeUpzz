<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionHistoryPage.aspx.cs" Inherits="MakeMeUpzz.View.TransactionHistoryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="TransactioID">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="Transaction ID" />
            <asp:BoundField DataField="Users.UserID" HeaderText="User ID" SortExpression="Transaction ID" />
            <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="Transaction ID" />
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Transaction ID" />

            <asp:TemplateField HeaderText="Detail">
                <ItemTemplate>
                    <asp:Button ID="ButtonDetail" runat="server" Text="Detail" CommandName="Detail" UseSubmitBehavior="false"/>/>
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>

    </asp:GridView>
</asp:Content>
