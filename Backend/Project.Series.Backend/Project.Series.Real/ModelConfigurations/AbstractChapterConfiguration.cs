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
    public class AbstractChapterConfiguration : EntityTypeConfiguration<AbstractChapter>
    {
        public AbstractChapterConfiguration()
        {
            ToTable("AbstractChapters", DbConstants.SchemaName);

            Property(ac => ac.Name)
                .HasMaxLength(50);

            HasMany(ac => ac.ChapterCollection)
                .WithRequired(c => c.AbstractChapter)
                .HasForeignKey(c => c.AbstractChapterId)
                .WillCascadeOnDelete(false);
        }
    }
}
