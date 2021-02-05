using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WizLib_Model.Models;

namespace WizLib_DataAccess.Data.FluentConfig
{
    public class FluentBookConfig : IEntityTypeConfiguration<Fluent_Book>
    {
        public void Configure(EntityTypeBuilder<Fluent_Book> modelBuilder)
        {
            //Fluent_Book   
            modelBuilder.HasKey(bk => bk.BookId);
            modelBuilder.Property(bk => bk.Title).IsRequired();
            modelBuilder.Property(bk => bk.ISBN).IsRequired().HasMaxLength(15);
            modelBuilder.Property(bk => bk.Price).IsRequired();
            //one Fluent_Book to one Fluent_Bookdetail
            modelBuilder.HasOne(bd => bd.Fluent_BookDetail).WithOne(bk => bk.Fluent_Book)
                .HasForeignKey<Fluent_Book>("BookDetailId");
            //one book has one publisher which has many books
            modelBuilder.HasOne(p => p.Fluent_Publisher).WithMany(b => b.Fluent_Books)
                .HasForeignKey(k => k.PublisherId);
        }
    }
}
