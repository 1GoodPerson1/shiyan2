using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using QJ.JDGL.GXB.BLL;

namespace GXB.WebApplication1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //账号 密码
            string name = TextBox1.Text;
            string pwd = TextBox2.Text;
            userbll bll = new userbll();
           object result=bll.login(name,pwd);
            if (result == null)
            {
                TextBox1.Text = "错误";
            }
            else {
                TextBox1.Text = "成功";
            }
        }
    }
}