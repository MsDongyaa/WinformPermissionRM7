using RM7.Model.Entity;
using System;
using System.Collections.Generic;

using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM7.Model.ModelConfig
{
    public class RoleConfig:EntityTypeConfiguration<RoleEntity>
    {
        public RoleConfig()
        {
            ToTable("T_Role");
            Property(p => p.EnCode).HasMaxLength(50).IsRequired().IsUnicode(false);
            Property(p => p.FullName).HasMaxLength(50).IsRequired();
            Property(p => p.CreatorName).HasMaxLength(100);
            Property(p => p.ModifyUserName).HasMaxLength(100);
            Property(p => p.OverDueTime).IsOptional();
            Property(p => p.ModifyDate).IsOptional();
            Property(p => p.Sort).IsOptional();
        }
    }
}
