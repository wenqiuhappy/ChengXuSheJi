using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Test01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");

            for (int i = 0; i < 100; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = new Random().Next(1,1000);
                dr[1] = DateTime.Now.ToString();
                dt.Rows.Add(dr);
                System.Threading.Thread.Sleep( new Random().Next(300));
            }
            GridView1.DataSource = dt.DefaultView;
            GridView1.DataBind();
        }


        
    }
}