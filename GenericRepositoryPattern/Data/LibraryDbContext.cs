using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryPattern.Data.Model
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext()
        {

        }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {

        }
       
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
