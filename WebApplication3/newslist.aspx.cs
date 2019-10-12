using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class newslist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string _id = GridView1.DataKeys[e.NewEditIndex].Value.ToString(); 
            Response.Redirect("newsedit.aspx?id="+_id);
        }
    }
}