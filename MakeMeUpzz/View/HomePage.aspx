<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="MakeMeUpzz.View.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="User" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="UserID" HeaderText="ID" SortExpression="UserID" />
                    <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                    <asp:BoundField DataField="UserEmail" HeaderText="UserEmail" SortExpression="UserEmail" />
                    <asp:BoundField DataField="UserDOB" HeaderText="UserDOB" SortExpression="UserDOB" />
                    <asp:BoundField DataField="UserGender" HeaderText="UserGender" SortExpression="UserGender" />
                    <asp:BoundField DataField="UserRole" HeaderText="UserRole" SortExpression="UserRole" />
                    <asp:BoundField DataField="UserPassword" HeaderText="UserPassword" SortExpression="UserPassword" />
                </Columns>
                
            </asp:GridView>
        </div>
    </form>
</body>
</html>
