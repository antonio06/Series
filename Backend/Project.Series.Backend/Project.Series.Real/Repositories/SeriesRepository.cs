using Project.Series.Contracts;
using Project.Series.Real.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Series.Real.Repositories
{
    public class SeriesRepository : ISeriesRepository
    {
        private SeriesContexts _context;

        public SeriesRepository()
        {
            _context = new SeriesContexts();
        }

        public SeriesRepository(string connectionString)
        {
            _context = new SeriesContexts(connectionString);
        }
    }
}
