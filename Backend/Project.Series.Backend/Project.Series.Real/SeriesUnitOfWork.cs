using Lemoncode.libs.ORM.utils;
using Project.Series.Contracts;
using Project.Series.Real.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Series.Real
{
    public class SeriesUnitOfWork : ISeriesUnitOfWork
    {
        private IRepositoryFactory<SeriesRepository> _seriesRepositoryFactory;

        public SeriesUnitOfWork(string connectionString = null)
        {
            InitializeRepositoryFactories(connectionString);
        }

        private void InitializeRepositoryFactories(string connectionString = null)
        {
            _seriesRepositoryFactory = new RepositoryFactory<SeriesRepository>();

            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                _seriesRepositoryFactory.SetConnectionString(connectionString);
            }
        }

        public ISeriesRepository SeriesRepository => 
            _seriesRepositoryFactory.CreateInstance();
    }
}
