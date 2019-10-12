<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="newslist.aspx.cs" Inherits="WebApplication3.newslist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" Width="100%" OnRowEditing="GridView1_RowEditing">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="编号" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="title" HeaderText="标题" SortExpression="title" />
            <asp:BoundField DataField="dates" HeaderText="日期" SortExpression="dates" />
            <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="newsadd.aspx?id={0}" Text="编辑" />
            <asp:CommandField HeaderText="操作" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Test2ConnectionString %>" DeleteCommand="DELETE FROM [tb_news] WHERE [Id] = @Id" InsertCommand="INSERT INTO [tb_news] ([title], [cont], [dates]) VALUES (@title, @cont, @dates)" SelectCommand="SELECT * FROM [tb_news]" UpdateCommand="UPDATE [tb_news] SET [title] = @title, [cont] = @cont, [dates] = @dates WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="title" Type="String" />
            <asp:Parameter Name="cont" Type="String" />
            <asp:Parameter Name="dates" Type="DateTime" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="title" Type="String" />
            <asp:Parameter Name="cont" Type="String" />
            <asp:Parameter Name="dates" Type="DateTime" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <br />
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Test2ConnectionString %>" SelectCommand="SELECT * FROM [tb_news] WHERE ([Id] = @Id)">
        <SelectParameters>
            <asp:QueryStringParameter DefaultValue="0" Name="Id" QueryStringField="id" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

