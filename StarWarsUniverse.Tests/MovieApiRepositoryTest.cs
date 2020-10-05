using NUnit.Framework;
using StarWarsUniverse.Data.Repositories.Api;
using System;

namespace StarWarsUniverse.Tests
{
        [TestFixture]
        public class MovieApiRepositoryTests
        {
            private MovieApiRepository _repo;
            [SetUp]
            public void SetUp()
            {
                _repo = new MovieApiRepository();
            }

            [Test]
            public void GetAllMovies()
            {
            //Act 
            // TODO: call GetAllMovies 
            //Assert 
            var actualRepoCount = _repo.GetAllMovies().Count;
            var expectedRepoCount = 6;
            Assert.That(actualRepoCount,Is.EqualTo(expectedRepoCount));
            
            //Assert.Fail("No test yet: there should be a least 6 movies");
            }
        }
    }
