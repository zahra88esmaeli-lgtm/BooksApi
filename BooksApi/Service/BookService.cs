using BooksApi.Data;
using BooksApi.Model;
using Microsoft.EntityFrameworkCore;

namespace BooksApi.Service
{
    public class BookService : IBookService
    {
        private readonly BookDBContext _dbContext;
        public BookService(BookDBContext dbContext)
        {
            _dbContext = dbContext;
        }
       
        public async Task<Book> AddBookAsync(Book book)
        {
        
            _dbContext.Books.Add(book);
            await _dbContext.SaveChangesAsync();
            return book;
        }

       

        public async Task<bool> DeleteBookAsync(int id)
        {
            var book = await _dbContext.Books.FindAsync(id);
            if (book == null) return false;
          
           _dbContext.Books.Remove(book);
            await _dbContext.SaveChangesAsync();
            return true;
        }

     

        public async Task<Book?> GetBookByIdAsync(int id)
        {
            return await _dbContext.Books.FindAsync(id);
        }

      

        public Task<List<Book>> GetBooksAsync()
        {
            return _dbContext.Books.ToListAsync();
        }

        public async Task<bool> UpdateBookAsync(int id, Book book)
        {

            var existingBook =await _dbContext.Books.FindAsync(id);
            if (existingBook == null) return false;
            
            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.PublishedDate = book.PublishedDate;
            await _dbContext.SaveChangesAsync();
            return true;
        }

        
    }
}
