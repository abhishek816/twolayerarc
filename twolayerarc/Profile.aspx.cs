using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace twolayerarc
{
    public partial class Profile : System.Web.UI.Page
    {
        ConnectionClass cls = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "select Name,Age,Address,Photo from information where id=" + Session["uid"] + "";
            SqlDataReader dr = cls.fun_exereader(s);
            while (dr.Read())
            {
                Label1.Text = dr["Name"].ToString();
                Label2.Text = dr["Age"].ToString();
                Label3.Text = dr["Address"].ToString();
                Image1.ImageUrl = dr["Photo"].ToString();
            }
            DataSet ds = cls.fun_exeadapter(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            DataTable dt = cls.fn_exedatatable(s);
            DataList1.DataSource = dt;
            DataList1.DataBind();

        }
    }
}