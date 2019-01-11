using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Series.Real
{
    public class UsersDbContextInitializer : DropCreateDatabaseAlways<UsersDbContext>
    {
        protected override void Seed(UsersDbContext context)
        {
            base.Seed(context);
        }
    }
}
