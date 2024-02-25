using Domain.Entities;
using Infrastracture.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastracture
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) 
        { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Author>(new AuthorEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration<Book>(new BookEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration<BorrowedBook>(new BorrowedBookEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration<Genre>(new GenreEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration<Publisher>(new PublisherEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration<Reader>(new ReaderEntityTypeConfiguration());
        }
    }
}
