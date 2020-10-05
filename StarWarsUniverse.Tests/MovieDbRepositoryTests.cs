using NUnit.Framework;
using StarWarsUniverse.Data.Repositories.Db;
using StarWarsUniverse.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsUniverse.Tests
{
    //the unit test itself will be the same as for MovieApiRepository, but this time you check your data 
    //    to be retrieved from a (mocked) database.
    [TestFixture]
    public class MovieDbRepositoryTests : StarWarsDbTestBase
    {
        [Test]
        public void GetAllMoviesShouldReturnEveryMovie()
        {
            //Arrange 
            var repo = new MovieDbRepository(Context);
            //Act
            var returnedMovies = repo.GetAllMovies();
            Context.Planets.Add(new Planet {
                Name = "P1",
            });
            //Assert 
            // Write your unit test here! 
            var expectedRepoCount = 6;
            Assert.That(returnedMovies.Count, Is.EqualTo(expectedRepoCount));
        }


        //Now you could elaborate on MovieDbRepositoryTests to check if the GetAllMovies method also loads 
        //    the planets of each movie.Put one or more planets and movieplanets in the in-memory database and 
        //    write a test that checks if the relations are loaded. 
    
    
    
    }
}


//// Arrange
//var mockContext = new Mock<INorthwindContext>();

//// Populate Customers "table"
//var customerDbSet = customers.GetQueryableMockDbSet();
//foreach (var customer in customers)
//{
//    customerDbSet.Add(customer);
//}

//mockContext.Setup(context => context.Customers).Returns(customerDbSet);
//var dbContext = mockContext.Object;

//// Act
//var customerData = dbContext.Customers;

//// Assert
//Assert.IsTrue(customerData.Count() == 3);