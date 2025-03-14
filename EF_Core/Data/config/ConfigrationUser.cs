using EF_Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Core.Data.config
{
    public class ConfigrationUser : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.Property(x => x.UserName).HasColumnType("VARCHAR").HasMaxLength(20).IsRequired();
            builder.Property(x => x.Password).HasColumnType("VARCHAR").HasMaxLength(100).IsRequired();

            builder.HasData(LoadUsers());
            builder.ToTable("Users");

        }
        public static List<User> LoadUsers()
        {
            return new List<User>
            {
                new User{PersonID=1,Name="Salem",  Address="1Street",Phone="77829388",Email=null,DateOfBirth=Convert.ToDateTime("2005-06-01"),Gender=1,UserName="s123",Password="1111",Permission=1,IsActive=true},
                new User{PersonID=25,Name="Hadi",  Address="1Street",Phone="77829388",Email=null,DateOfBirth=Convert.ToDateTime("2005-06-01"),Gender=1,UserName="s123",Password="1111",Permission=1,IsActive=true},
                new User{PersonID=42,Name="ALi Faozy",Address="1Street",Phone="77829388",Email=null,DateOfBirth=Convert.ToDateTime("2005-06-01"),Gender=1,UserName="s123",Password="1111",Permission=1,IsActive=true}
        };
        
        }
    }
}
