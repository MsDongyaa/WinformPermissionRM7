using RM7.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM7.Model.ModelConfig
{
    public class LogConfig: EntityTypeConfiguration<LogEntity>
    {
        public LogConfig()
        {
            ToTable("T_AdminLogs");
            Property(p => p.ModifyDate).IsOptional();
            Property(p => p.CreatorName).HasMaxLength(50).IsRequired();
            Property(p => p.ModifyUserName).HasMaxLength(50);
        }
    }
}
