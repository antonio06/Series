using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Series.Entities
{
    public class TypeSeries
    {
        // Primary key
        public int Id { get; set; }

        // Properties
        public string Description { get; set; }

        // Navigation Properties
        public ICollection<Series> SeriesCollection { get; set; }
    }
}
