using EF_Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Core.Data.config
{
    public class ConfigrationMemberDetails : IEntityTypeConfiguration<MembersDetails>
    {

        public void Configure(EntityTypeBuilder<MembersDetails> builder)
        {
            builder.HasNoKey();
        }

    }
}
