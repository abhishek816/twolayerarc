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
    public partial class Login : System.Web.UI.Page
    {
        ConnectionClass cls=new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select count(id) from information where Username='" + TextBox1.Text + "'and Password='" + TextBox2.Text + "'";
            string cid = cls.fun_exescalar(s);
            if (cid == "1")
            {
                int id1 = 0;
                string str= "select id from information where Username='" + TextBox1.Text + "'and Password='" + TextBox2.Text + "'";
                SqlDataReader dr = cls.fun_exereader(str);
                while (dr.Read())
                {
                    id1 = Convert.ToInt32(dr["id"].ToString());
                }
                Session["uid"] = id1;
                Response.Redirect("Profile.aspx");
            }
            else
            {
                Label1.Text = "Error logging in!!";
            }

        }
    }
}