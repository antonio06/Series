using Project.Series.Real.ModelConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entityes = Project.Series.Entities;

namespace Project.Series.Real
{
    public class UsersDbContext : DbContext
    {
        public DbSet<Entityes.Series> Users { get; set; }

        public UsersDbContext() : base("SERIES")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new AbstractChapterConfiguration());
            modelBuilder.Configurations.Add(new ChapterConfiguration());
            modelBuilder.Configurations.Add(new SeasonConfiguration());
            modelBuilder.Configurations.Add(new SeriesConfiguration());
            modelBuilder.Configurations.Add(new SeriesUserConfiguration());
            modelBuilder.Configurations.Add(new TypeSeriesConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
        }
    }
}
