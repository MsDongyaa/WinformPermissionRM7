using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM7.Model.Entity
{
    public class UserEntity:BaseEntity
    {
        public string EnCode { get; set; }//英文编码
        public string Account { get; set; }//登录账号
        public string Password { get; set; }//登录密码
        public string Salt { get; set; }//密码盐
        public  string Name { get; set; }//真实姓名
        public string NickName { get; set; }//昵称
        public string HeadIcon { get; set; }//图像
        public int Sex { get; set; }//性别
        public DateTime? Birthday { get; set; }//生日
        public string Mobile { get; set; }//手机
        public string Email { get; set; }//电子邮箱
        public string QQ { get; set; }//QQ
        public string WeChat { get; set; }//微信
        public int Sort { get; set; }//排序
        public string Mark { get; set; }//备注

        public ICollection<RoleEntity> Roles { get; set; } = new List<RoleEntity>();
        public ICollection<MenuEntity> Menus { get; set; } = new List<MenuEntity>();
    }
}
