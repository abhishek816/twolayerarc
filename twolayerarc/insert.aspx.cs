using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace twolayerarc
{
    public partial class insert : System.Web.UI.Page
    {
        ConnectionClass cls = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/img/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string strinsert = "insert into information values('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "','" + p + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
            int i = cls.fun_exenonquery(strinsert);
            if (i == 1)
            {
                Label1.Text = "Inserted";
            }

            
        }
    }
}