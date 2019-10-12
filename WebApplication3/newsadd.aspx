<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="newsadd.aspx.cs" Inherits="WebApplication3.newsadd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    标题<asp:TextBox ID="TextBox1" runat="server" Width="100%"></asp:TextBox>
    <br />
    内容<asp:TextBox ID="TextBox2" runat="server" Height="300px" TextMode="MultiLine" Width="100%"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="添加" OnClick="Button1_Click" />
</asp:Content>
