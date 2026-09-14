<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="IT4B_2026.HelloWorld" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Hello world</title>
</head>
<body>
    <h1>Hello world</h1>
    <form id="form1" runat="server">
        <asp:Button ID="btn_hello" runat="server" Text="Click me!" OnClick="SayHello" />
    </form>
    <asp:Label ID="lbl_hello" runat="server"></asp:Label>
</body>
</html>
