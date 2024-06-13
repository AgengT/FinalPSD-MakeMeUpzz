<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar.Master" AutoEventWireup="true" CodeBehind="OrderMakeupPage.aspx.cs" Inherits="MakeMeUpzz.View.OrderMakeupPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="MakeupID">
        <Columns>
            <asp:BoundField DataField="MakeupName" HeaderText="Name" SortExpression="MakeupName" />
            <asp:BoundField DataField="MakeupPrice" HeaderText="Price" SortExpression="MakeupName" />
            <asp:BoundField DataField="MakeupWeight" HeaderText="Weight" SortExpression="MakeupName" />
            <asp:BoundField DataField="MakeupType.MakeupTypeName" HeaderText="Type name" SortExpression="MakeupName" />
            <asp:boundfield datafield="MakeupBrand.MakeupBrandName" headertext="brand name" sortexpression="makeupname" />
            <asp:TemplateField HeaderText="Order">
                <ItemTemplate>
                    <asp:Button ID="OrderMakeupBtn" runat="server" Text="Order" CommandName="Order" UseSubmitBehavior="false"/>
                    <asp:TextBox ID="QuantityTextBox" runat="server"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>
</asp:Content>
