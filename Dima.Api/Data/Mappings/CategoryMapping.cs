using Dima.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dima.Api.Data.Mappings;

public class CategoryMapping : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Category");
        
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Title).IsRequired().HasColumnType("NVARCHAR(MAX)");
        builder.Property(x => x.Description).IsRequired(false).HasColumnType("NVARCHAR(MAX)");
        builder.Property(x => x.UserId).IsRequired().HasColumnType("NVARCHAR").HasMaxLength(160);
    }
}