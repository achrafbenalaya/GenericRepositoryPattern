using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepositoryPattern.Data.Model
{
    public class Author : BaseEntity
    {
        [Key]
        public int Idauth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }


        //[ForeignKey("Book")]
        //public Book Book { get; set; }

        public List<Book> Book { get; set; }

    }
}
