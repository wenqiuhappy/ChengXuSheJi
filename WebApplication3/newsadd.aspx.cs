using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class newsadd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.QueryString["id"]))
                {
                    System.Data.DataTable dataTable = db.getdt("select * from tb_news where id=" + Request.QueryString["id"]);
                    TextBox1.Text = dataTable.Rows[0][1].ToString();
                    TextBox1.Text = dataTable.Rows[0][2].ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int r = db.exeint(
                string.Format("insert into tb_news values ('{0}','{2}','{2}')",
                TextBox1.Text.Trim(),
                TextBox2.Text.Trim(),
                DateTime.Now));

            if (r>0)
            {
                Response.Redirect("newslist.aspx");
            }
            else
            {
                Response.Write("添加失败！");
            }
        }
    }
}