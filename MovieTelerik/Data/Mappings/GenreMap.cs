using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieTelerik.Models;

namespace MovieTelerik.Data.Mappings
{
    public class GenreMap : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genres");

            builder.Property("Id")
                .IsRequired()
                .HasColumnType("INT")
                .ValueGeneratedOnAdd()
                .IsUnicode()
                .UseIdentityColumn();

            builder.Property("Name")
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR");


        }
    }
}