<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageMakeupPage.aspx.cs" Inherits="MakeMeUpzz.View.ManageMakeupPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Manage Makeup</h1>
        <h2>Makeup</h2>
        <asp:GridView ID="Makeup" runat="server" OnRowEditing="Makeup_RowEditing" OnRowDeleting="Makeup_RowDeleting" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <asp:Button runat="server" Text="Update"  CommandName="Edit" UseSubmitBehavior="false"/>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                <asp:Button runat="server" Text="Delete"  CommandName="Delete" UseSubmitBehavior="false"/>
                    </ItemTemplate>
                </asp:TemplateField>

            <asp:BoundField DataField="MakeupID" HeaderText="ID" SortExpression="MakeupID" />
            <asp:BoundField DataField="MakeupName" HeaderText="Name" SortExpression="MakeupName" />
            <asp:BoundField DataField="MakeupPrice" HeaderText="Price" SortExpression="MakeupPrice" />
            <asp:BoundField DataField="MakeupWeight" HeaderText="Weight" SortExpression="MakeupWeight" />

            </Columns>
        </asp:GridView>

        <h2>Makeup Brand</h2>
            <asp:GridView ID="MakeupBrand" runat="server" OnRowEditing="MakeupBrand_RowEditing" OnRowDeleting="MakeupBrand_RowDeleting" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:Button runat="server" Text="Update"  CommandName="Edit" UseSubmitBehavior="false"/>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:Button runat="server" Text="Delete"  CommandName="Delete" UseSubmitBehavior="false"/>
                            </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="MakeupBrandID" HeaderText="ID" SortExpression="BrandID" />
                    <asp:BoundField DataField="MakeupBrandName" HeaderText="Name" SortExpression="BrandName" />
                    <asp:BoundField DataField="MakeupBrandRating" HeaderText="Rating" SortExpression="BrandRating" />

                </Columns>
            </asp:GridView>
           
        <h2>Makeup Type</h2>
            <asp:GridView ID="MakeupType" runat="server" OnRowEditing="MakeupType_RowEditing" OnRowDeleting="MakeupType_RowDeleting" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:Button runat="server" Text="Update"  CommandName="Edit" UseSubmitBehavior="false"/>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:Button runat="server" Text="Delete"  CommandName="Delete" UseSubmitBehavior="false"/>
                                </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="MakeupTypeID" HeaderText="ID" SortExpression="TypeID" />
                    <asp:BoundField DataField="MakeupTypeName" HeaderText="Name" SortExpression="TypeName" />
                </Columns>
            </asp:GridView>

        <asp:Button ID="InsertMakeup" runat="server" Text="Insert Makeup" OnClick="InsertMakeup_Click" />
        <asp:Button ID="InsertMakeupType" runat="server" Text="Insert Makeup Type" OnClick="InsertMakeupType_Click" />
        <asp:Button ID="InsertMakeupBrand" runat="server" Text="Insert Makeup Brand" OnClick="InsertMakeupBrand_Click" />
    </div>
   </form>
</body>
</html>
