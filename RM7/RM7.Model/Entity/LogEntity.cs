using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM7.Model.Entity
{
    public class LogEntity:BaseEntity
    {
        public int CategoryId { get; set; }//分类Id 1-登陆2-访问3-异常

        public int SourceObject { get; set; }//来源对象

        public int SourceContension { get; set; }//来源日志内容

        public int MenuID { get; set; }//菜单ID

        public int Menu { get; set; }//菜单

        public int MenuType { get; set; }//菜单类型

        public int Mark { get; set; }//备注

    }
}
