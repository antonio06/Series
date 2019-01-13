using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Series.Entities
{
    public class User
    {
        // Primary key
        public int Id { get; set; }

        // Properties
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Navigation Properties
        public ICollection<SeriesUser> SeriesUsersCollection { get; set; }
    }
}
