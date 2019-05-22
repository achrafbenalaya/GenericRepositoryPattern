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
    [Produces("application/json")]
    //[ApiController]
    public class AuthorController : BaseController
    {

        private readonly IAuthorRepository _authorRepository;

        public AuthorController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [Route("Author")]
        public IActionResult GetAllAuthors()
        {
           
           


          //  return BuildJsonResponse(200, "SUCCESS", resultAllAuthors, null);

            List<string> error = new List<string>();


            try
            {
                var resultAllAuthors = _authorRepository.GetAllAuthors();
                //return Ok(Roles.ToList());
                return BuildJsonResponse(200, "Success", resultAllAuthors, null);
                //return roleManager.Roles;
            }
            catch (Exception ex)
            {
                error.Add(ex.Message);
                return BuildJsonResponse(500, "SERVER ERROR", null, error);
                // return null;
            }





        }

        [Route("AuthorById/{id}")]
        public  Author GetAuthorById([FromRoute] int id)
        {
            var author = _authorRepository.GetAuthorById(id);

            if (author == null)
            {    return null;}

            else
            {
                return author.Result;
            }
           
        }





    }
}