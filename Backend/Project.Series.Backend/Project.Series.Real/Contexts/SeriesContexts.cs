using Project.Series.Entities;
using Project.Series.Real.ModelConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Entityes = Project.Series.Entities;

namespace Project.Series.Real.Contexts
{
    public class SeriesContexts : DbContext
    {
        public DbSet<AbstractChapter> AbstractChapters { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Entityes.Series> Series { get; set; }
        public DbSet<SeriesUser> SeriesUsers { get; set; }
        public DbSet<TypeSeries> TypeSeries { get; set; }
        public DbSet<User> Users { get; set; }

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

        public SeriesContexts() : base("SERIES")
        {
            ContextInitialization();
        }

        public SeriesContexts(string conectionString) : base(conectionString)
        {
            ContextInitialization();
        }

        private void ContextInitialization()
        {
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer<SeriesContexts>(null);
        }
    }
}
