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
    public class TypeSeriesConfiguration : EntityTypeConfiguration<TypeSeries>
    {
        public TypeSeriesConfiguration()
        {
            ToTable("TypesSeries", DbConstants.SchemaName);

            Property(ts => ts.Description)
                .HasMaxLength(1200);
        }
    }
}
