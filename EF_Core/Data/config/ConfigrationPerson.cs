using EF_Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography;

namespace EF_Core.Data.config
{
    public class ConfigrationPerson : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(x => x.PersonID);
            builder.Property(x => x.PersonID).ValueGeneratedNever();
            builder.Property(x => x.Address).HasColumnType("VARCHAR").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Email).HasColumnType("VARCHAR").HasMaxLength(80).IsRequired(false);
            builder.Property(x => x.Phone).HasColumnType("VARCHAR").HasMaxLength(20).IsRequired();
            builder.Property(x => x.Name).HasColumnType("VARCHAR").HasMaxLength(100).IsRequired();


            //builder.HasQueryFilter(x => x.Email != null);

            builder.ToTable("Persons");
        }
       
    }
}
