using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WizLib_Model.Models;

namespace WizLib_DataAccess.Data.FluentConfig
{
    public class FluentAuthorConfig : IEntityTypeConfiguration<Fluent_Author>
    {
        public void Configure(EntityTypeBuilder<Fluent_Author> modelBuilder)
        {
            modelBuilder.HasKey(a => a.AuthorId);
            modelBuilder.Property(a => a.FirstName).IsRequired();
            modelBuilder.Property(a => a.LastName).IsRequired();
            modelBuilder.Ignore(a => a.FullName);
        }
    }
}
