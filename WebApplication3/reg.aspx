<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reg.aspx.cs" Inherits="WebApplication3.reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
            <h2>用户注册</h2>
            <p>
                用户名：
             
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>
            <p>
                密&nbsp; 码：<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            </p>
         <p>
                确认密码：<asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
            </p>
            <p>
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Text="注册" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="登录" OnClick="Button2_Click" />
            </p>
        </div>
    </form>
</body>
</html>
