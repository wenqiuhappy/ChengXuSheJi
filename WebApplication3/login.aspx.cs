using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("reg.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int r = (int)db.exeobj("select count(id) from tb_user where username='"+TextBox1.Text.Trim()+"' and pwds='"+TextBox2.Text.Trim()+"'");
            if (r>0)
            {
                Response.Write("登录成功！");
                Session["username"] = TextBox1.Text.Trim();
                Response.Redirect("newslist.aspx");
            }
            else
            {
                Response.Write("登录失败！");
            }
        }
    }
}