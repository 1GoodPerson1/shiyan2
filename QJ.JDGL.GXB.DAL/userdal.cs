using GXB.WebApplication1;
using QJ.JDGL.GXB.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QJ.JDGL.GXB.DAL
{
    public class userdal
    {
        public object login(string name, string pwd)
        {
            string sql = "select * from login where name=@name and pwd= @pwd";
            SqlParameter[] parames = new SqlParameter[2];
            parames[0] = new SqlParameter("@name", name);
            parames[1] = new SqlParameter("@pwd", pwd);
            object result = DBhelper.Excutesclar(sql, parames);
                return result;
        }
        public List<userModel> sel()
        {
            string sql = "select * from login";
            SqlDataReader reader = DBhelper.ExcuteSqlDataReader(sql);
            List<userModel> list = new List<userModel>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    userModel usermodel = new userModel();
                    usermodel.name = reader["name"].ToString();
                    usermodel.pwd = reader["pwd"].ToString();
                    list.Add(usermodel);
                }
            }
            return list;
        }
        public int add(userModel model)
        {
            string sql = "insert into  login values(@name,@pwd);";
            List<SqlParameter> parames = new List<SqlParameter>();
            parames.Add(new SqlParameter("@name", model.name));
            parames.Add(new SqlParameter("@pwd", model.pwd));
            return DBhelper.ExcuteSqlNonQuery(sql, parames.ToArray());
        }
        public int updata(userModel model)
        {
            string sql = "update login set pwd=@pwd where name=@name";
            List<SqlParameter> parames = new List<SqlParameter>();
            parames.Add(new SqlParameter("@name", model.name));
            parames.Add(new SqlParameter("@pwd", model.pwd));

            return DBhelper.ExcuteSqlNonQuery(sql,parames.ToArray());
        }
        public userModel selname(string model)
        {
            string sql = "select * from login where name=@name";
            SqlParameter[] parames = new SqlParameter[1];
            parames[0] = new SqlParameter("@name",model);
            SqlDataReader reader = DBhelper.ExcuteSqlDataReader(sql,parames);
            userModel usermodel = new userModel();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    usermodel.name = reader["name"].ToString();
                    usermodel.pwd = reader["pwd"].ToString();
                }
            }
            return usermodel;

        }
        
    }
}
