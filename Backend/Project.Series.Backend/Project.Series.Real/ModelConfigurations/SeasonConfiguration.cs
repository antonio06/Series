using Project.Series.Constants;
using Project.Series.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Series.Real.ModelConfigurations
{
    public class SeasonConfiguration : EntityTypeConfiguration<Season>
    {
        public SeasonConfiguration()
        {
            ToTable("Seasons", DbConstants.SchemaName);

            Property(s => s.Name)
                .HasMaxLength(50);

            HasMany(s => s.AbstractChapterCollection)
                .WithRequired(ac => ac.Season)
                .HasForeignKey(ac => ac.SeasonId)
                .WillCascadeOnDelete(false);
        }
    }
}
