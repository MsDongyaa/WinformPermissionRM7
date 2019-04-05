using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM7.Model.Entity
{
    public class BaseEntity
    {
        
        public int ID { get; set; }//ID
        public int CreatorId { get; set; }//创建者ID
        public string CreatorName { get; set; }//创建者名字
        public DateTime CreateDate { get; set; } = DateTime.Now;//创建时间
        public int ModifyUserId { get; set; }//修改人ID
        public string ModifyUserName { get; set; }//修改人名字
        public DateTime? ModifyDate { get; set; } = null; //修改时间
        public bool IsDelete { get; set; }//软删除标志
        public int EnableFlag { get; set; }//可用标志

    }
}
