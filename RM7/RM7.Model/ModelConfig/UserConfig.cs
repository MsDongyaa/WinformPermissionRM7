using RM7.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM7.Model.ModelConfig
{
    public class UserConfig:EntityTypeConfiguration<UserEntity>
    {
        public UserConfig()
        {
            ToTable("T_User");
            HasMany(t => t.Roles).WithMany(r => r.Users).Map(m=>m.ToTable("T_UserRoleRelations").MapLeftKey("UserID").MapRightKey("RoleID"));
            HasMany(t => t.Menus).WithMany(m => m.Users).Map(m => m.ToTable("T_UserMenuRelations").MapLeftKey("UserID").MapRightKey("MenuID"));
            Property(p => p.EnCode).HasMaxLength(50).IsRequired().IsUnicode(false);
            Property(p => p.Account).HasMaxLength(100).IsRequired().IsUnicode(false);
            Property(p => p.Name).HasMaxLength(50);
            Property(p => p.NickName).HasMaxLength(100);
            Property(p => p.HeadIcon).HasMaxLength(100);
            Property(p => p.Birthday).IsOptional();
            Property(p => p.Mobile).HasMaxLength(20);
            Property(p => p.Email).HasMaxLength(50);
            Property(p => p.QQ).HasMaxLength(50);
            Property(p => p.WeChat).HasMaxLength(100);
            Property(p => p.CreatorName).HasMaxLength(100);
            Property(p => p.ModifyUserName).HasMaxLength(100);   
            Property(p => p.ModifyDate).IsOptional();
        }
    }
}
