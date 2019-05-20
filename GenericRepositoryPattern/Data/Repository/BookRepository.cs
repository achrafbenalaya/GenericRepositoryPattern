using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericRepositoryPattern.Data.Interfaces;
using GenericRepositoryPattern.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryPattern.Data.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(LibraryDbContext context) : base(context)
        {
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _context.Books.FindAsync(id);

        }

        public IEnumerable<Book> GetBookwithauthors()
        {
            return _context.Books
                .Include(a => a.Author).ThenInclude(a => a.Book).Where(a => a.Author != null);
                



        }

    }
}
