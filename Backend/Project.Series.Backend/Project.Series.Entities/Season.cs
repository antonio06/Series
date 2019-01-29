using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Series.Entities
{
    public class Season
    {
        // Primary key
        public int Id { get; set; }

        // Foreing key
        public int SeriesId { get; set; }

        // Properties
        public string Name { get; set; }
        public bool Active { get; set; }
        public int NumOfChapter { get; set; }

        // Navigation Properties
        public Series Series { get; set; }
        public ICollection<AbstractChapter> AbstractChapterCollection { get; set; }
    }
}
