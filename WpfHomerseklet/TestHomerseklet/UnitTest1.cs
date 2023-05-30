using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Diagnostics;

namespace TestHomerseklet
{
    public class Tests
    {
        protected const string DriverUrl = "http://127.0.0.1:4723";
        private const string Program = @"D:\rud\kodtarak\13d_asztali_2023\WpfHomerseklet\WpfHomerseklet\bin\Debug\WpfHomerseklet.exe";
        private const string ProgramPath = @"D:\rud\kodtarak\13d_asztali_2023\WpfHomerseklet\WpfHomerseklet\bin\Debug\";
        protected static WindowsDriver<WindowsElement> driver;
        protected static ExtentReports extReport;
        protected static ExtentTest extTest;

        [OneTimeSetUp]
        public void ReportSetup()
        {
            extReport = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"D:\rud\kodtarak\13d_asztali_2023\WpfHomerseklet\WpfHomerseklet\bin\Debug\results.html");
            extReport.AddSystemInfo("Hõmérséklet átváltás teszt", "Auto teszt");
            extReport.AddSystemInfo("Tesztelõ:", "Junior Jenõ");
            extReport.AttachReporter(htmlReporter);
            htmlReporter.Config.DocumentTitle = "HTML teszt riport";
            htmlReporter.Config.ReportName = "Hõmérséklet átváltás teszt";
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
        }


        [OneTimeSetUp]
        public void Setup()
        {
            if (driver==null)
            {
                var appiumoptions = new AppiumOptions();
                appiumoptions.AddAdditionalCapability("app", Program);
                appiumoptions.AddAdditionalCapability("device", "WinPC");
                driver = new WindowsDriver<WindowsElement>(new Uri(DriverUrl), appiumoptions);
            }
        }

        [Test]
        [TestCase(58,14.44)]
        [TestCase(3,-16.11)]
        [TestCase(12,-11.11)]
        [TestCase(8,-12.78)]
        
        public void TestFahrenheitToCelsius(double homerseklet,double elvart)
        {
            extTest = extReport.CreateTest("Fahrenheit to Celsius test");
            var homersekletErtek = driver.FindElementByAccessibilityId("textboxHomerseklet");
            var eredmeny = driver.FindElementByAccessibilityId("textblockEredmeny");
            var button = driver.FindElementByAccessibilityId("buttonSzamol");
            
            homersekletErtek.Clear();
            eredmeny.Clear();
            homersekletErtek.SendKeys(homerseklet.ToString());
            driver.FindElementByAccessibilityId("radioCelsius").Click();
            button.Click();
            eredmeny = driver.FindElementByAccessibilityId("textblockEredmeny");

            Assert.AreEqual(elvart, Convert.ToDouble(eredmeny.Text.Replace("C","")));
            extTest.Log(Status.Pass, "Fahrenheit to celsius test ok.");

        }

        [Test]
        [TestCase(14.44,58)]
        [TestCase(14.44,58)]
        [TestCase(13.33,56)]
        [TestCase(12.78,56)]
        public void TestCelsiusToFahrenheit(double homerseklet,double elvart)
        {
            extTest = extReport.CreateTest("Celsius to fahrenheit test");
            var homersekletErtek = driver.FindElementByAccessibilityId("textboxHomerseklet");
            var eredmeny = driver.FindElementByAccessibilityId("textblockEredmeny");
            var button = driver.FindElementByAccessibilityId("buttonSzamol");

            homersekletErtek.Clear();
            eredmeny.Clear();
            homersekletErtek.SendKeys(homerseklet.ToString());
            driver.FindElementByAccessibilityId("radioFahrenheit").Click();
            button.Click();
            eredmeny = driver.FindElementByAccessibilityId("textblockEredmeny");
            Assert.AreEqual(elvart, Convert.ToDouble(eredmeny.Text.Replace("F", "")),0.01);
            extTest.Log(Status.Pass, "Celsius to fahrenheit test ok.");
        }

        [TearDown]
        public void CloseReport()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = TestContext.CurrentContext.Result.StackTrace;
            var errormsg = TestContext.CurrentContext.Result.Message;

            if (status==TestStatus.Failed)
            {
                ITakesScreenshot shot = (ITakesScreenshot)driver;
                Screenshot screenshot = shot.GetScreenshot();
                var be = TestContext.CurrentContext.Test.Arguments.GetValue(0);
                var elvart= TestContext.CurrentContext.Test.Arguments.GetValue(1);
                string filename = shot + "_" + be + "_" + elvart;
                screenshot.SaveAsFile(ProgramPath+filename + ".png", ScreenshotImageFormat.Png);


                extTest.Log(Status.Fail, stacktrace + errormsg);
                extTest.Log(Status.Fail, "Képernyõ:");
                extTest.AddScreenCaptureFromPath(filename + ".png");
            }
        }

        [OneTimeTearDown]
        public void EndTest()
        {
            if (driver!=null)
            {
                driver.Close();
                driver.Quit();
                extReport.Flush();
            }
        }
    }
}