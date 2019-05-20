using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericRepositoryPattern.Data.Interfaces;
using GenericRepositoryPattern.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository =bookRepository;
        }

        [Route("books")]
        public IEnumerable<Book> ListBooks()
        {
            var books = _bookRepository.GetBooks();
            return books;


        }

        [Route("bookbyId/{id}")]
        public Task<Book> GetBookByID([FromRoute] int id)
        {
            var book = _bookRepository.GetBookById(id);
            return book;

        }



        [Route("bookbyauth")]
        public IEnumerable<Book> GetBookswithAuthors()
        {
            var Bookandauthor = _bookRepository.GetBookwithauthors().ToList();
            Bookandauthor.ForEach(Book => Book.Author.Book = null);
            return Bookandauthor;

        }
        




    }
}