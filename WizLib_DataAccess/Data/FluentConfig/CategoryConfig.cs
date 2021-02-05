using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WizLib_Model.Models;

namespace WizLib_DataAccess.Data.FluentConfig
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> modelBuilder)
        {
            //category table and column name
            modelBuilder.ToTable("tbl_category");
            modelBuilder.Property(c => c.Name).HasColumnName("CategoryName");
        }
    }
}
