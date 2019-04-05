using RM7.Model;
using RM7.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {
           Database.SetInitializer(new DropCreateDatabaseIfModelChanges<RM7Context>());
           
           using (RM7Context ctx=new RM7Context())
            {
                UserEntity user = new UserEntity();
                user.Account = "李四";
                user.Password = "123456";
                user.EnCode = "123456";
                ctx.UserEntitys.Add(user);

                ctx.SaveChanges();
            }
        }
    }
}
