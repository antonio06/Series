using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Series.Entities
{
    public class Series
    {
        // Primary key
        public int Id { get; set; }

        // Foreing key
        public int TypeSeriesId { get; set; }

        // Properties
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }

        // Navigation Properties
        public TypeSeries TypeSeries { get; set; }
        public ICollection<Season> SeasonsCollection { get; set; }
        public ICollection<SeriesUser> SeriesUsersCollection { get; set; }
    }
}
