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
    public class ChapterConfiguration : EntityTypeConfiguration<Chapter>
    {
        public ChapterConfiguration()
        {
            ToTable("Chapters", DbConstants.SchemaName);
        }
    }
}
