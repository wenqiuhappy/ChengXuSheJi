<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication2.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>用户登录</h2>
            用户<asp:TextBox ID="txt_user" runat="server"></asp:TextBox>
            <br />
            密码<asp:TextBox ID="txt_pwd" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btn" runat="server" Text="登录" OnClick="btn_Click" />
        &nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/reg.aspx">注册用户</asp:HyperLink>
        </div>
    </form>
</body>
</html>
