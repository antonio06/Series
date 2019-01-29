using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Series.Entities
{
    public class Chapter
    {
        // Primary key
        public int Id { get; set; }

        // Foreing key
        public int AbstractChapterId { get; set; }

        // Properties
        public DateTime Date { get; set; }
        public decimal Duration { get; set; }

        // Navigation Properties
        public AbstractChapter AbstractChapter { get; set; }
    }
}
