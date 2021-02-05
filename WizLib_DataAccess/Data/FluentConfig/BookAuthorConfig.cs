using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WizLib_Model.Models;

namespace WizLib_DataAccess.Data.FluentConfig
{
    public class BookAuthorConfig : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> modelBuilder)
        {
            modelBuilder.HasKey(ba => new { ba.AuthorId, ba.BookId });
        }
    }
}
