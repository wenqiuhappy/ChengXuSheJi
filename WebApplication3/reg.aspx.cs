using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length < 6)
            {
                Response.Write("用户名长度不能小于6位");
                return;
            }

            if (TextBox2.Text.Length < 6)
            {
                Response.Write("密码长度不能小于6位");
                return;
            }

            if (TextBox3.Text!=TextBox2.Text)
            {
                Response.Write("两次密码不一样！");
                return;
            }

            int r = db.exeint(
                string.Format("insert into tb_user (username,pwds) values ('{0}','{1}');",TextBox1.Text.Trim(),TextBox2.Text.Trim())
                );

            if (r>0)
            {
                Response.Write("注册成功！");
            }
            else
            {
                Response.Write("注册失败！");
            }
        }
    }
}