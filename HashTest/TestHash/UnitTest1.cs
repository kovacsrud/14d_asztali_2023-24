using NUnit.Framework;
using KRHash;


namespace TestHash
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("1869a0fb81975de54a5aee15f6d6a976", "hétfõ")]
        [TestCase("249d6c99eff6d0ef6c470e4254629323", "valami")]
        [TestCase("18573ab97805c55268bbf5dd225260c6", "bármi")]
        [TestCase("4e8753f05713ffe3056031f2e94458e3", "akármi")]
        [TestCase("1869a0fb81975de54a5aee15f6d6a976", "hétfõ")]
        [TestCase("1869a0fb81975de54a5aee15f6d6a976", "hétfõ")]
        [TestCase("1869a0fb81975de54a5aee15f6d6a976", "hétfõ")]
        [TestCase("1869a0fb81975de54a5aee15f6d6a976", "hétfõ")]
        [TestCase("1869a0fb81975de54a5aee15f6d6a976", "hétfõ")]
        [TestCase("1869a0fb81975de54a5aee15f6d6a976", "hétfõ")]
        [TestCase("1869a0fb81975de54a5aee15f6d6a976", "hétfõ")]
        [TestCase("1869a0fb81975de54a5aee15f6d6a976", "hétfõ")]
        [TestCase("1869a0fb81975de54a5aee15f6d6a976", "hétfõ")]
        [TestCase("1869a0fb81975de54a5aee15f6d6a976", "hétfõ")]
        [TestCase("1869a0fb81975de54a5aee15f6d6a976", "hétfõ")]
        public void Md5Test(string elvart,string szoveg)
        {
            //Arrange
            CreateHash hash = new CreateHash();


            //Act
            var sut = hash.MakeHash(HashType.MD5, szoveg);

            //Assert

            Assert.AreEqual(elvart, sut);
        }
    }
}