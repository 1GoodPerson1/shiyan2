using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QJ.JDGL.GXB.DAL;
using QJ.JDGL.GXB.Model;

namespace QJ.JDGL.GXB.BLL
{
    public class userbll
    {
        public userdal dal = new userdal();
        public object login(string name, string pwd)
        {
            return dal.login(name, pwd);
        }
        public List<userModel> sel()
        {
            return dal.sel();
        }
        public int add(userModel model)
        {
            return dal.add(model);
        }
        public int updata(userModel model)
        {
            return dal.updata(model);
        }
        public userModel selname(string model)
        {
            return dal.selname(model);
        }
    }
}
