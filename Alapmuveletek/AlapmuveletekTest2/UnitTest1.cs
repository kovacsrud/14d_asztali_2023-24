using NUnit.Framework;
using Alapmuveletek;
using System.Collections.Generic;
using System.IO;
using System;

namespace AlapmuveletekTest2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        //[TestCase(20,10,10)]
        //[TestCase(40, 20, 20)]
        //[TestCase(30, 20, 10)]
        //[TestCase(100, 50, 50)]
        [TestCaseSource("GetOsszeadasAdatok")]
        public void OsszeadTest(double elvart,double a,double b)
        {
            //arrange -> elõkészület, pl. példányosítás
            //act -> valamilyen tevékenység elvégzése
            //assert -> vizsgálat pl. jó-e a kapott érték, létrejött-e az objektum

            Alapmuvelet alapmuvelet = new Alapmuvelet(); //-> arrange
            var sut = alapmuvelet.Osszead(a, b); //-> act
            Assert.AreEqual(elvart, sut); //->assert
            
        }

        public static IEnumerable<double[]> GetOsszeadasAdatok()
        {
            var sorok = File.ReadAllLines("tesztesetek_osszeadas.csv");
            for (int i = 0; i < sorok.Length; i++)
            {
                var e = sorok[i].Split(';');
                var a = Convert.ToDouble(e[0]);
                var b = Convert.ToDouble(e[1]);
                var elvart = Convert.ToDouble(e[2]);
                yield return new[] {elvart, a, b };
            }
        }


    }
}