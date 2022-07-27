using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieTelerik.Models;

namespace MovieTelerik.Data.Mappings
{
    public class MovieMap : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movies");

            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnType("INT")
                .ValueGeneratedOnAdd()
                .IsUnicode()
                .UseIdentityColumn();

            builder.Property(x => x.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(40);

            builder.Property(x => x.CreatedDate)
                .IsRequired()
                .HasColumnType("DATETIME")
                .HasColumnName("CreatedDate")
                .HasDefaultValueSql("getdate()");


            builder.Property(x => x.GenreId)
                .IsRequired()
                .HasColumnName("GenreId")
                .HasColumnType("INT");

            builder.Property(x => x.MetaScore)
                .IsRequired()
                .HasColumnName("MetaScore")
                .HasColumnType("INT");

            builder.Property(x => x.UrlImg)
                .IsRequired()
                .HasColumnName("UrlImg")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(110);

            builder.Property(x => x.Resume)
                .IsRequired()
                .HasColumnName("Resume")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(250);


        }
    }
}