using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace TestSebesseg
{
    public class Tests
    {
        protected const string WinAppDriver = " http://127.0.0.1:4723/";
        private const string WPFProgramId = @"D:\rud\kodtarak\13d_asztali_2023\WpfSebesseg\WpfSebesseg\bin\Debug\net7.0-windows\WpfSebesseg.exe";
        private const string WPFProgramPath = @"D:\rud\kodtarak\13d_asztali_2023\WpfSebesseg\WpfSebesseg\bin\Debug\net7.0-windows\";

        protected static WindowsDriver<WindowsElement> driver;

        [OneTimeSetUp]
        public void Setup()
        {
            if (driver==null)
            {
                var appiumOptions = new AppiumOptions();
                appiumOptions.AddAdditionalCapability("app", WPFProgramId);
                appiumOptions.AddAdditionalCapability("devicename", "WinPc");
                driver = new WindowsDriver<WindowsElement>(new Uri(WinAppDriver),appiumOptions);
            }
        }

        [Test]
        [TestCase(3.6,1)]
        [TestCase(7.2, 2)]
        public void KmhToMs(double kmh,double elvart)
        {
            var sebesseg = driver.FindElementByAccessibilityId("textboxKmh");
            sebesseg.Clear();
            driver.FindElementByAccessibilityId("radioMs").Click();
            sebesseg.SendKeys(kmh.ToString());
            driver.FindElementByAccessibilityId("buttonSzamol").Click();
            var eredmeny = driver.FindElementByAccessibilityId("textblockEredmeny");
            Assert.AreEqual(elvart,Convert.ToDouble(eredmeny.Text),0.0005);
        }

        [OneTimeTearDown]
        public void Endtest()
        {
            driver.Close();
            driver.Quit();
        }
    }
}