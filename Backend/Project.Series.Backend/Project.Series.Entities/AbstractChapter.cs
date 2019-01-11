using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Series.Entities
{
    public class AbstractChapter
    {
        // Primary key
        public int Id { get; set; }

        // Foreing key
        public int SeasonId { get; set; }

        // Properties
        public string Name { get; set; }

        // Navigation Properties
        public ICollection<Chapter> ChapterCollection { get; set; }
        public Season Season { get; set; }
    }
}
