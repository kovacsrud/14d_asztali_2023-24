using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;


namespace TestKonverter
{
    public class Tests
    {

        protected const string WinAppDriver = "http://127.0.0.1:4723";
        private const string WPFProgramId = @"D:\rud\kodtarak\13d_asztali_2023\WpfKonverter\WpfKonverter\bin\Debug\net7.0-windows\WpfKonverter.exe";
        private const string WPFProgramPath = @"D:\\rud\\kodtarak\\13d_asztali_2023\\WpfKonverter\\WpfKonverter\\bin\\Debug\\net7.0-windows";

        protected static WindowsDriver<WindowsElement> driver;

        [OneTimeSetUp]
        public void Setup()
        {
            if (driver == null)
            {
                var appiumOptions=new AppiumOptions();
                appiumOptions.AddAdditionalCapability("app", WPFProgramId);
                appiumOptions.AddAdditionalCapability("devicename", "WinPc");
                driver = new WindowsDriver<WindowsElement>(new Uri(WinAppDriver),appiumOptions);
            }
        }

        [Test]
        [TestCase(1.11112,"Angle","Degree","Gradian")]
        public void BaseTest(double elvart,string mennyiseg,string inMertekegyseg,string outMertekegyseg)
        {
            Thread.Sleep(500);
            driver.FindElementByAccessibilityId("listboxMennyisegek").FindElementByName(mennyiseg).Click();
            Thread.Sleep(500);
            driver.FindElementByAccessibilityId("listboxInMertekegyseg").FindElementByName(inMertekegyseg).Click();
            Thread.Sleep(500);
            driver.FindElementByAccessibilityId("listboxOutMertekegyseg").FindElementByName(outMertekegyseg).Click();
            Thread.Sleep(500);
            var eredmeny = driver.FindElementByAccessibilityId("textboxOutErtek").Text.Replace('.',',');
            Assert.AreEqual(elvart, Convert.ToDouble(eredmeny),0.00005);
            //Assert.That(elvart, Is.EqualTo(Convert.ToDouble(eredmeny)));
        }

        [OneTimeTearDown]
        public void Endtest()
        {
            //driver.Close();
            //driver.Quit();
        }
    }
}