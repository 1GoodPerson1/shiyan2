using QJ.JDGL.GXB.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GXB.WebApplication1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            userbll bll = new userbll();
           Repeater1.DataSource= bll.sel();
            Repeater1.DataBind();
        }
    }
}