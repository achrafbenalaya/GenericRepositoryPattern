using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericRepositoryPattern.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepositoryPattern.Data.Interfaces
{
   public interface IBookRepository : IRepository<Book>
   {

       IEnumerable<Book> GetBooks();
       Task<Book> GetBookById(int id);
       IEnumerable<Book> GetBookwithauthors();


   }
}
