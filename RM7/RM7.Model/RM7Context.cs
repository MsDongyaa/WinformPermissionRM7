using RM7.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RM7.Model
{
    public class RM7Context:DbContext
    {
        public RM7Context() : base("name=conn")
        {
           // Database.SetInitializer<RM7Context>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<UserEntity> UserEntitys { get; set; }
        public DbSet<RoleEntity> RoleEntitys { get; set; }
        public DbSet<MenuEntity> MenuEntitys { get; set; }
        public DbSet<LogEntity> LogEntitys { get; set; }
    }
}
