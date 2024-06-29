using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task16WebUI.Models.Entities;

namespace Task16WebUI.Models.Contexts.Configurations
{
    public class SubscribeEntityTypeConfiguation : IEntityTypeConfiguration<Subscribe>
    {
        public void Configure(EntityTypeBuilder<Subscribe> builder)
        {
            builder.Property(m=>m.Id).HasColumnType("int").UseIdentityColumn(1,1);
            builder.Property(m=>m.Email).HasColumnType("varchar").HasMaxLength(100).IsRequired();

            builder.HasKey(m=>m.Id);
            builder.ToTable("Subscribes");
        }
    }
}
