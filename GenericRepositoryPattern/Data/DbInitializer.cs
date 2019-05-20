using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericRepositoryPattern.Data.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace GenericRepositoryPattern.Data
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder app,LibraryDbContext context)
        {
            if (context.Database.EnsureCreated())
            {
                // Add Customers
                var justin = new Author { FirstName = "Justin Noon", LastName = "test1", PhoneNumber = "202020" };
                var justin1 = new Author { FirstName = "Justin 2", LastName = "test2", PhoneNumber = "202020" };
                var justin2 = new Author { FirstName = "Justin 3", LastName = "test3", PhoneNumber = "202020" };


                var justinwriter = new Author
                {
                    FirstName = "Justin 3",
                    LastName = "test3",
                    PhoneNumber = "202020",


                    //Books = new Book()
                    //{
                    //  Name = "justinwriterBook",NbPage = 20

                    //}
                };



                context.Authors.Add(justin);
                context.Authors.Add(justin1);
                context.Authors.Add(justin2);
                context.Authors.Add(justinwriter);
                context.SaveChanges();



                var book1 = new Book { Name = "book1", Isbn = "11", IPAddress = "11", AddedDate = System.DateTime.Now, NbPage = 25 };
                var book2 = new Book { Name = "book2", Isbn = "12", IPAddress = "11", AddedDate = System.DateTime.Now, NbPage = 25 };
                var book3 = new Book { Name = "book3", Isbn = "13", IPAddress = "11", AddedDate = System.DateTime.Now, NbPage = 25, Author = justinwriter };



                context.Books.Add(book1);
                context.Books.Add(book2);
                context.Books.Add(book3);

                // Add Author
                
                context.SaveChanges();
            }


            //using (var serviceScope = app.ApplicationServices.CreateScope())
            //{
            //    var context = serviceScope.ServiceProvider.GetService<LibraryDbContext>();
            //}
        }
    }
}

