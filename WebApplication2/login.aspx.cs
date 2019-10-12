using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            string u = txt_user.Text.Trim();
            string w = txt_pwd.Text.Trim();

            int r = (int)db.exeobj(string.Format("select count(id) from tb_user WHERE user1='{0}' and pwd1='{1}';", u, w));

            if (r>0)
            {
                Response.Write("登录成功！");

            }
            else
            {
                Response.Write("用户名或密码错误！");
            }
        }
    }
}