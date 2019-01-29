using Project.Series.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Series.Real
{
    public class SeriesUnitOfWorkFactory : ISeriesUnitOfWorkFactory
    {
        private string _connectionString;
        private bool _connectionStringSet = false;

        public ISeriesUnitOfWork CreateInstance()
        {
            return _connectionStringSet ?
                new SeriesUnitOfWork(_connectionString) :
                new SeriesUnitOfWork();
        }

        public void SetConnectionString(string connectionString)
        {
            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                _connectionString = connectionString;
                _connectionStringSet = true;
            }
        }
    }
}
