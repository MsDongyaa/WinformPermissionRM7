using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM7.Model.Entity
{
    public  class MenuEntity:BaseEntity
    {
        public int ParentID { get; set; }//父级菜单

        public string EnCode { get; set; }//菜单编码

        public string Icon { get; set; }//图标

        public string UrlAddress { get; set; }//导航地址

        public int Level { get; set; }//菜单等级

        public string Path { get; set; }//菜单路径

        public int Type { get; set; }//菜单类型

        public int Sort { get; set; }//排序号

        public string Mark { get; set; }//备注

        public ICollection<UserEntity> Users { get; set; } = new List<UserEntity>();
        public ICollection<RoleEntity> Roles { get; set; } = new List<RoleEntity>();

    }
}
