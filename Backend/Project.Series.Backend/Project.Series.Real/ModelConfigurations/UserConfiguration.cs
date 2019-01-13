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
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("Users", DbConstants.SchemaName);

            Property(u => u.Name)
                .HasMaxLength(50);

            Property(u => u.Email)
                .HasMaxLength(50);

            Property(u => u.Password)
                .HasMaxLength(255);

            HasMany(u => u.SeriesUsersCollection)
                .WithRequired(su => su.User)
                .HasForeignKey(su => su.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}
