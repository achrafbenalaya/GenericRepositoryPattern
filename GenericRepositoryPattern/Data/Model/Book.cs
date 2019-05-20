using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryPattern.Data.Model
{
    public class Book :BaseEntity
    {
        [Key]
        public int BookId { get; set; }
        public string Name { get; set; }
        public int NbPage { get; set; }

        public string Isbn { get; set; }


        //[ForeignKey("Author")]
        public int? AuthorId { get; set; }
        public Author Author { get; set; }



    }
}
