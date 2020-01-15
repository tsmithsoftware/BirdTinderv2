
using NUnit.Framework;
using BirdTinderv2.DAL;
using BirdTinderv2.DAL.Repositories;
using Moq;

namespace BirdTinderv2.DALTests
{
    public class SystemUserRepoTest
    {
        SystemUserRepo systemUserRepo;
        Mock<ModelContext> mockContext;

        [SetUp]
        public void Setup()
        {
            systemUserRepo = new SystemUserRepo(mockContext.Object);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}