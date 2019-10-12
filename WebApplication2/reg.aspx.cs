using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            string u = txt_user.Text.Trim();
            string w = txt_pwd.Text.Trim();

            int r = db.exeint("insert into tb_user values('"+u+"','"+w+"')");

            if (r > 0)
            {
                Response.Write("注册成功！");

            }
            else
            {
                Response.Write("注册错误！");
            }
        }
    }
}