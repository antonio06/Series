using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Series.Entities
{
    public class SeriesUser
    {
        // Primary key
        public int Id { get; set; }

        // Foreing key
        public int UserId { get; set; }
        public int SeriesId { get; set; }

        // Navigation Properties
        public Series Series { get; set; }
        public User User { get; set; }
    }
}
