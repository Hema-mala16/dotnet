<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Operations.aspx.cs" Inherits="ConnectedObjects1.Operations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            Emp Id
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <br />
            Emp Name
            <asp:TextBox ID="TtxtName" runat="server"></asp:TextBox>
            <br />
            Emp Sal
            <asp:TextBox ID="txtSal" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
&nbsp;<asp:Button ID="btnName" runat="server" OnClick="btnName_Click" Text="Delete" />
&nbsp;<asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" Text="Update" />
&nbsp;
            <asp:Button ID="btnSpInsert" runat="server" OnClick="btnSpInsert_Click" Text="Sp_Insert" />
&nbsp;
            <asp:Button ID="btnSpUpdate" runat="server" OnClick="btnSpUpdate_Click" Text="Sp_Update" />
&nbsp;
            <asp:Button ID="btnDel" runat="server" OnClick="btnDel_Click" Text="DelWithParameters" />
        </div>
    </form>
</body>
</html>
