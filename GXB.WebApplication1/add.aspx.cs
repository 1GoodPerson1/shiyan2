using QJ.JDGL.GXB.BLL;
using QJ.JDGL.GXB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GXB.WebApplication1
{
    public partial class add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                userbll bll = new userbll();
                if (Request.QueryString["name"] != null)
                {
                    userModel model = bll.selname(Request.QueryString["name"].ToString());
                    TextBox1.Text = model.name;
                    TextBox2.Text = model.pwd;
                }


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["name"] != null)
            {
                userbll bll = new userbll();
                userModel model = new userModel();
                model.name = TextBox1.Text;
                model.pwd = TextBox2.Text;
                int num=bll.updata(model);
                if (num > 0)
                {
                    ClientScript.RegisterStartupScript(GetType(), "", "alert('添加成功');window.location='index.aspx';", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "", "alert('失败');", true);
                }
            }
            else
            {
                userModel model = new userModel();
                model.name = TextBox1.Text;
                model.pwd = TextBox2.Text;
                userbll bll = new userbll();
                int num = bll.add(model);
                if (num > 0)
                {
                    ClientScript.RegisterStartupScript(GetType(), "", "alert('添加成功');window.location='index.aspx';", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "", "alert('失败');", true);
                }
            }



        }
    }
}