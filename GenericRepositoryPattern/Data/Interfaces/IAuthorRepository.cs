using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericRepositoryPattern.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepositoryPattern.Data.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
       IEnumerable<Author> GetAllAuthors();
       Task <Author> GetAuthorById(int id);


    }
}
