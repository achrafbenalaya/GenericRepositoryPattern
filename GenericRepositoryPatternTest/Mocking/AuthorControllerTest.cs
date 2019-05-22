using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericRepositoryPattern.Controllers;
using GenericRepositoryPattern.Data.Interfaces;
using GenericRepositoryPattern.Data.Model;
using Moq;
using NUnit.Framework;

namespace GenericRepositoryPatternTest.Mocking
{
    [TestFixture]
    public class AuthorControllerTest
    {
        private Author _existingAuthor;
        private Mock<IAuthorRepository> _repository;
        private AuthorController _authorController;
        [SetUp]
        public void SetUp()
        {
            _existingAuthor = new Author
            {Idauth = 1,
           FirstName = "achraf",
           LastName = "Ben alaya",
           IPAddress = "127.0.0.1",
           AddedDate = System.DateTime.Now,
           PhoneNumber = "20202020"

            };

            _repository = new Mock<IAuthorRepository>();
            _repository.Setup(r => r.GetAllAuthors()).Returns(new List<Author>
            {
                _existingAuthor

            }.AsEnumerable);

            
        }

       



        [Test]
        public void should_return_Two_author()
        {
            
            //arrange

            List<Author> _existingAuthors = new List<Author>();
            var justin = new Author { FirstName = "Justin Noon", LastName = "test1", PhoneNumber = "202020" };
            var justin2 = new Author { FirstName = "Justin Noon", LastName = "test1", PhoneNumber = "202020" };
            _existingAuthors.Add(justin2);
            _existingAuthors.Add(justin);
              var authors= new Mock<IAuthorRepository>();
             authors.Setup(c => c.GetAllAuthors()).Returns(_existingAuthors);
            //act
            AuthorController home = new AuthorController(authors.Object);
            var result = home.GetAllAuthors().Count();
            Console.WriteLine("The Result is "+result);
            //assert 
            Assert.AreEqual(2, result);



        }



        [Test]
        public void should_return_one_author()
        {

            //arrange

          
            Author _existingAuthors = new Author()
            {

                Idauth = 1,
                FirstName = "Justin1",
                LastName = "test1",
                PhoneNumber = "202020"

            };




            var authors = new Mock<IAuthorRepository>();
            authors.Setup(c => c.GetAuthorById(1)).ReturnsAsync(_existingAuthors);

            //act
            AuthorController home = new AuthorController(authors.Object);
            var result = home.GetAuthorById(1);
            Console.WriteLine("Justin1" + result.FirstName);

            //assert 
            Assert.AreEqual("Justin1", result.FirstName);



        }









    }
}
