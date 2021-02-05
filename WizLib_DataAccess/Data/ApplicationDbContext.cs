using Microsoft.EntityFrameworkCore;
using WizLib_Model.Models;

namespace WizLib_DataAccess.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        //public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        //no longer needed to create the special composite table
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Fluent_BookDetail> Fluent_BookDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configure fluent API
            //composite key
            modelBuilder.Entity<BookAuthor>().HasKey(ba => new { ba.AuthorId, ba.BookId });

            ////Fluent_Author
            //modelBuilder.Entity<Fluent_Author>().HasKey(bd => bd.AuthorId);
            //modelBuilder.Entity<Fluent_Author>().Property(bd => bd.FirstName).IsRequired();
            //modelBuilder.Entity<Fluent_Author>().Property(bd => bd.LastName).IsRequired();

            ////Fluent_Book   
            //modelBuilder.Entity<Fluent_Book>().HasKey(bk => bk.BookId);
            //modelBuilder.Entity<Fluent_Book>().Property(bk => bk.Title).IsRequired();
            //modelBuilder.Entity<Fluent_Book>().Property(bk => bk.ISBN).IsRequired();
            //modelBuilder.Entity<Fluent_Book>().Property(bk => bk.Price).IsRequired();

            ////Fluent_BookAuthor
            //modelBuilder.Entity<Fluent_BookAuthor>().HasKey(ba => new { ba.AuthorId, ba.BookId });

            //Fluent_BookDetails
            modelBuilder.Entity<Fluent_BookDetail>().HasKey(bd => bd.BookDetailId);
            modelBuilder.Entity<Fluent_BookDetail>().Property(bd => bd.NumberOfChapters).IsRequired();

            ////Fluent_Publisher
            //modelBuilder.Entity<Fluent_Publisher>().HasKey(p => p.PublisherId);
            //modelBuilder.Entity<Fluent_Publisher>().Property(p => p.PublisherName).IsRequired();
            //modelBuilder.Entity<Fluent_Publisher>().Property(p => p.Location).IsRequired();

        }
    }
}
