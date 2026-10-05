<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PodmACykly.aspx.cs" Inherits="IT4B_2026.PodmACykly.PodmACykly" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Podm a cykly</title>
    <style>
        table, td, th {
            border: 1px solid black;
            border-collapse: collapse;
        }
    </style>
</head>
<body>
    Test pole: <asp:Label ID="lbl_pole" runat="server"></asp:Label><br />
    Test retezce: <asp:Label ID="lbl_retezec" runat="server"></asp:Label><br />

    for-cyklus: 
    <form runat="server">
        <asp:BulletedList ID="bl_for" runat="server"></asp:BulletedList><br />
        <asp:BulletedList ID="bl_while" runat="server" BulletStyle="Numbered"></asp:BulletedList><br />
        <asp:DropDownList ID="ddl_do" runat="server"></asp:DropDownList><br />
        <h1>Tabulka druhych mocnin</h1>
        <asp:Table ID="tbl_moc" runat="server">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell>i</asp:TableHeaderCell>
                <asp:TableHeaderCell>i<sup>2</sup></asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
        <h1>Tabulka male nasobilky</h1>
        <asp:Table ID="tbl_nas" runat="server"></asp:Table>
        <asp:Label ID="lbl_if" runat="server"></asp:Label><br />
        <asp:Label ID="lbl_switch" runat="server"></asp:Label>


    </form>
</body>
</html>
