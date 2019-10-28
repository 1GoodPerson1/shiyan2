using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace GXB.WebApplication1
{
    public  class DBhelper
    {
        //连接数据库
        public static readonly string connStr = ConfigurationManager.ConnectionStrings["testConnectionString"].ConnectionString;
        //查询首列
        public static object Excutesclar(string sql, params SqlParameter[] sqlparames)
        {
            //创建连接
            using (SqlConnection sqlconn = new SqlConnection(connStr))
            {
                //创建命令
                using (SqlCommand sqlcmd = new SqlCommand(sql, sqlconn))
                {
                    //执行
                    if (sqlconn.State == ConnectionState.Closed)
                    {
                        sqlconn.Open();
                    }
                    //添加参数
                    sqlcmd.Parameters.AddRange(sqlparames);
                    //返回结果
                    return sqlcmd.ExecuteScalar();
                }
            }
        }
        //查询结果
        public static  SqlDataReader ExcuteSqlDataReader(string sql, params SqlParameter[] sqlParameters)
        {
            //创建连接
            SqlConnection connection = new SqlConnection(connStr);
            //创建命令
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                //执行
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                //添加参数
                command.Parameters.AddRange(sqlParameters);
                //返回结果,及时关闭掉连接
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }
        //增删改
        public static int ExcuteSqlNonQuery(string sql, SqlParameter[] parames)
        {
            //创建连接
            using (SqlConnection sqlconn = new SqlConnection(connStr))
            {
                //创建命令
                using (SqlCommand sqlcmd = new SqlCommand(sql, sqlconn))
                {
                    //执行
                    if (sqlconn.State == ConnectionState.Closed)
                    {
                        sqlconn.Open();
                    }
                    //添加参数
                    sqlcmd.Parameters.AddRange(parames);
                    //返回结果，及时关闭连接
                    return sqlcmd.ExecuteNonQuery();
                }
            }
        }
    }
}