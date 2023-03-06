using NUnit.Framework;
using Alapmuveletek;

namespace AlapmuveletekTest2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(20,10,10)]
        [TestCase(40, 20, 20)]
        [TestCase(30, 20, 10)]
        [TestCase(100, 50, 50)]
        public void OsszeadTest(double elvart,double a,double b)
        {
            //arrange -> elõkészület, pl. példányosítás
            //act -> valamilyen tevékenység elvégzése
            //assert -> vizsgálat pl. jó-e a kapott érték, létrejött-e az objektum

            Alapmuvelet alapmuvelet = new Alapmuvelet(); //-> arrange
            var sut = alapmuvelet.Osszead(a, b); //-> act
            Assert.AreEqual(elvart, sut); //->assert
            
        }


    }
}