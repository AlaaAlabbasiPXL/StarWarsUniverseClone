using NUnit.Framework;
using StarWarsUniverse.Data.Repositories.Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsUniverse.Tests
{
    [TestFixture]
    public class PlanetApiRepositoryTests
    {
        private PlanetApiRepository _repo;
        [SetUp]
        public void SetUp()
        {
            _repo = new PlanetApiRepository();
        }

        [Test]
        public void GetAllPlanets() //for lus van http request
        {
            //Act 
            // TODO: call GetAllPlanets 
            //Assert 
            var actualRepoCount = _repo.GetAllPlanets().Count;
            var expectedRepoCount = 60;
            Assert.That(actualRepoCount, Is.EqualTo(expectedRepoCount));

            //Assert.Fail("No test yet: there should be a least 60 planets");
        }
    }
}
