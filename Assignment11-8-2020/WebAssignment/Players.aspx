<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Players.aspx.cs" Inherits="WebAssignment.Players" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:RadioButton runat="server" Text="CricketPlayers" AutoPostBack="True" GroupName="b" OnCheckedChanged="Unnamed2_CheckedChanged" />
        <asp:RadioButton runat="server" Text="TennisPlayers" AutoPostBack="True" GroupName="b" OnCheckedChanged="Unnamed1_CheckedChanged" />
        <asp:Panel ID="Panel1" runat="server">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/HtmlSachin.html">Sachin</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/HtmlDhoni.html">dhoni</asp:HyperLink>
            <br />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/HtmlVirat.html">viratKohli</asp:HyperLink>
        </asp:Panel>
        <p>
            &nbsp;</p>
        <asp:Panel ID="Panel2" runat="server">
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/HtmlSerena.html">SerenaWilliams</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/HtmlSania.html">SaniaMirza</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/HtmlLeander.html">Leander</asp:HyperLink>
            <br />
        </asp:Panel>
    </form>
</body>
</html>
