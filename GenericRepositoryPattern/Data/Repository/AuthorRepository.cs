using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericRepositoryPattern.Data.Interfaces;
using GenericRepositoryPattern.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepositoryPattern.Data.Repository
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {


        public AuthorRepository(LibraryDbContext context) : base(context)
        {

        }

        public IEnumerable<Author> GetAllAuthors()
        {
            return _context.Authors;
        }

        public async Task<Author> GetAuthorById(int id)
        {
            return await _context.Authors.FindAsync(id);
        }

        //public Author GetAuthorById(int id)
        //{

        //}

        //Task<Author> IAuthorRepository.GetAuthorById(int id)
        // {
        //     return _context.Authors.Where(a => a.Id == id).FirstOrDefault();
        // }
    }
}
