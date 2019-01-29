using Entityes = Project.Series.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Series.Constants;

namespace Project.Series.Real.ModelConfigurations
{
    public class SeriesConfiguration : EntityTypeConfiguration<Entities.Series>
    {
        public SeriesConfiguration()
        {
            ToTable("Series", DbConstants.SchemaName);

            Property(s => s.Name)
                .HasMaxLength(50);

            Property(s => s.Director)
                .HasMaxLength(50);

            Property(s => s.Description)
                .HasMaxLength(1000);

            HasMany(s => s.SeriesUsersCollection)
                .WithRequired(su => su.Series)
                .HasForeignKey(su => su.SeriesId)
                .WillCascadeOnDelete(false);

            HasMany(s => s.SeasonsCollection)
                .WithRequired(s => s.Series)
                .HasForeignKey(s => s.SeriesId)
                .WillCascadeOnDelete(false);
        }
    }
}
