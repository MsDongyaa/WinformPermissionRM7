using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace RM7.Framework
{
    public class StaticConstant
    {
        ///// <summary>
        ///// sqlserver数据库连接
        ///// </summary>
        //public static string SqlServerConnString = ConfigurationManager.ConnectionStrings["Customers"].ConnectionString;

        //private static string DALTypeDll = ConfigurationManager.AppSettings["DALTypeDll"];
        //public static string DALDllName = DALTypeDll.Split(',')[1];
        //public static string DALTypeName = DALTypeDll.Split(',')[0];

        /// <summary>
        /// 文本地址记录路径
        /// </summary>
        public static string LogPath = ConfigurationManager.AppSettings["LogPath"];
        public static string JsonPath = ConfigurationManager.AppSettings["JsonPath"];
    }
}
