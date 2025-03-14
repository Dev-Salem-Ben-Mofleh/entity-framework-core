using EF_Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Core.Data.config
{
    public class ConfigrationMembersInstructorOverview : IEntityTypeConfiguration<MembersInstructorOverview>
    {

        public void Configure(EntityTypeBuilder<MembersInstructorOverview> builder)
        {
            builder.HasNoKey();
            builder.ToView("GetAllMemberInstructors");
        }

    }
}
