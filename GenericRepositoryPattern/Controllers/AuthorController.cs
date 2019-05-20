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
    public class AuthorController : Controller
    {

        private readonly IAuthorRepository _authorRepository;

        public AuthorController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [Route("Author")]
        public  IEnumerable<Author> GetAllAuthors()
        {
            var authors = _authorRepository.GetAllAuthors();

            return authors;

        }

        [Route("AuthorById/{id}")]
        public  Author GetAuthorById([FromRoute] int id)
        {
            var author = _authorRepository.GetById(id);

            if (author == null)
            {    return null;}

            else
            {
                return author;
            }
           
        }





    }
}