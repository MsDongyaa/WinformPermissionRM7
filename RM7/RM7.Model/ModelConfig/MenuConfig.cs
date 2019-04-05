using RM7.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM7.Model.ModelConfig
{
    public class MenuConfig:EntityTypeConfiguration<MenuEntity>
    {
        public MenuConfig()
        {
            ToTable("T_Menu");
            HasMany(m => m.Roles).WithMany(r => r.Menus).Map(m => m.ToTable("T_RoleMenuRelations").MapLeftKey("MenuID").MapRightKey("RoleID")); 
            Property(p => p.ParentID).IsOptional();
            Property(p => p.EnCode).HasMaxLength(50).IsUnicode(false).IsRequired();
            Property(p => p.Icon).HasMaxLength(50);
            Property(p => p.Level).IsOptional();
            Property(p => p.CreatorName).HasMaxLength(100);
            Property(p => p.ModifyUserName).HasMaxLength(100);        
            Property(p => p.Type).IsOptional();
            Property(p => p.Sort).IsOptional();
            Property(p => p.Level).IsOptional();
            Property(p => p.ModifyDate).IsOptional();
        }
    }
}
