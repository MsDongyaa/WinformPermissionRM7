using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RM7.Framework.DBHelper
{
    public class DBHelper
    {
        /// <summary>
        /// 数据库名
        /// </summary>
        private static string ConnStr = ConfigurationManager.AppSettings["ConnStr"];

        //public static DataTable GetDataTable(string sql, params SqlParameter[] paras)
        //{
        //    DataTable dt = null;
        //    using (SqlConnection conn = new SqlConnection(ConnStr))
        //    {
        //        SqlCommand command = new SqlCommand(sql, conn);
        //        command.Parameters.AddRange(paras);
        //        dt = new DataTable();
        //        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //        {
        //            adapter.Fill(dt);
        //        }
        //    }
        //    return dt;
        //}

        /// <summary>
        /// 执行添加、删除、修改的方法
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] paras)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.AddRange(paras);

                result = command.ExecuteNonQuery();

            }
            return result;
        }

        /// <summary>
        /// 执行查询并返回第一行的第一列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, params SqlParameter[] paras)
        {
            object obj = 0;
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddRange(paras);

                    obj = (object)command.ExecuteScalar();
                }
            }
            return obj;
        }

        /// <summary>
        /// 执行查询并返回SqlDataReader对象
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] paras)
        {
            SqlDataReader reader = null;
            SqlConnection conn = new SqlConnection(ConnStr);
            conn.Open();
            SqlCommand command = new SqlCommand(sql, conn);

            command.Parameters.AddRange(paras);

            reader = command.ExecuteReader(CommandBehavior.CloseConnection);


            return reader;
        }




        public static DataSet GetDataSet(string sql, params SqlParameter[] paras)
        {
            DataSet ds = null;
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.AddRange(paras);

                ds = new DataSet();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(ds);
                }

            }
            return ds;
        }
    }
}