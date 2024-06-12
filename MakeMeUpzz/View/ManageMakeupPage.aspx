<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageMakeupPage.aspx.cs" Inherits="MakeMeUpzz.View.ManageMakeupPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <h1>Manage Makeup</h1>
        <h2>Makeup</h2>
        <asp:GridView ID="Makeup" runat="server" OnSelectedIndexChanged="Makeup_SelectedIndexChanged">
            <Columns>
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <asp:Button ID="BtnDetail" runat="server" Text="Update"  CommandName="Select" UseSubmitBehavior="false"/>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                <asp:Button ID="BtnDetail" runat="server" Text="Delete"  CommandName="Select" UseSubmitBehavior="false"/>
                    </ItemTemplate>
                </asp:TemplateField>

            <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="MakeupID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="MakeupName" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="MakeupPrice" />
            <asp:BoundField DataField="Weight" HeaderText="Weight" SortExpression="MakeupWeight" />

            </Columns>
        </asp:GridView>

        <h2>Makeup Brand</h2>
            <asp:GridView ID="MakeupBrand" runat="server" OnSelectedIndexChanged="MakeupBrand_SelectedIndexChanged">
                <Columns>
                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:Button ID="BtnDetail" runat="server" Text="Update"  CommandName="Select" UseSubmitBehavior="false"/>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:Button ID="BtnDetail" runat="server" Text="Delete"  CommandName="Select" UseSubmitBehavior="false"/>
                            </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="BrandID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="BrandName" />
                    <asp:BoundField DataField="Rating" HeaderText="Rating" SortExpression="BrandRating" />

                </Columns>
            </asp:GridView>
           
        <h2>Makeup Type</h2>
            <asp:GridView ID="MakeupType" runat="server" OnSelectedIndexChanged="MakeupType_SelectedIndexChanged">
                <Columns>
                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:Button ID="BtnDetail" runat="server" Text="Update"  CommandName="Select" UseSubmitBehavior="false"/>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:Button ID="BtnDetail" runat="server" Text="Delete"  CommandName="Select" UseSubmitBehavior="false"/>
                                </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="TypeID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="TypeName" />
                </Columns>
            </asp:GridView>

        <asp:Button ID="InsertMakeup" runat="server" Text="Insert Makeup" OnClick="InsertMakeup_Click" />
        <asp:Button ID="InsertMakeupType" runat="server" Text="Insert Makeup Type" />
        <asp:Button ID="InsertMakeupBrand" runat="server" Text="Insert Makeup Brand" />
    </div>
    
</body>
</html>
