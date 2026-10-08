using BooksApi.Model;
using Microsoft.EntityFrameworkCore;

namespace BooksApi.Data
{
    public class BookDBContext: DbContext
    {
        public BookDBContext(DbContextOptions<BookDBContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }  
    }
}
