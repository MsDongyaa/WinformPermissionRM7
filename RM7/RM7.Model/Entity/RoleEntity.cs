using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM7.Model.Entity
{
    public class RoleEntity:BaseEntity
    {
        public int UserID { get; set; }//用户ID
        public string EnCode { get; set; }//英文编码
        public string FullName { get; set; }//角色名称
        public bool IsPublic { get; set; }//是否公共角色
        public DateTime OverDueTime { get; set; }//过期时间
        public int Sort { get; set; }//排序
        public string Mark { get; set; }//备注
        public ICollection<UserEntity> Users { get; set; } = new List<UserEntity>();
        public ICollection<MenuEntity> Menus { get; set; } = new List<MenuEntity>();
    }
}
