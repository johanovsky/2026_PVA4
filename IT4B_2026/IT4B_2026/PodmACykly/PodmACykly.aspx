<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PodmACykly.aspx.cs" Inherits="IT4B_2026.PodmACykly.PodmACykly" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Podm a cykly</title>
</head>
<body>
    Test pole: <asp:Label ID="lbl_pole" runat="server"></asp:Label><br />
    Test retezce: <asp:Label ID="lbl_retezec" runat="server"></asp:Label><br />

    for-cyklus: 
    <form runat="server">
        <asp:BulletedList ID="bl_for" runat="server"></asp:BulletedList>
    </form>
</body>
</html>
