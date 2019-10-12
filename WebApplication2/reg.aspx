<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reg.aspx.cs" Inherits="WebApplication2.reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>用户注册</h2>
            用户<asp:TextBox ID="txt_user" runat="server"></asp:TextBox>
            <br />
            密码<asp:TextBox ID="txt_pwd" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            确认密码<asp:TextBox ID="txt_pwd1" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btn" runat="server" Text="注册" OnClick="btn_Click" />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
