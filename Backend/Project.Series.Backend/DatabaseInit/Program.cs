using Project.Series.Real;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseInit
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new UsersDbContextInitializer());

            using (var context = new UsersDbContext())
            {
                context.Users.ToList();
            }
        }
    }
}
