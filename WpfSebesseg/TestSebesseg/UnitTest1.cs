using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework.Interfaces;
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

        protected static ExtentReports extReport;
        protected static ExtentTest extTest;



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

        [OneTimeSetUp]
        public static void ReportSetup()
        {
            extReport = new ExtentReports();
            //
            extReport.AddSystemInfo("Sebesség átváltás teszt","Automatizált teszt");
            extReport.AddSystemInfo("Tesztelõ:", "XY");
            var reporter = new ExtentSparkReporter(@"D:\rud\kodtarak\13d_asztali_2023\WpfSebesseg\WpfSebesseg\bin\Debug\net7.0-windows\result.html");
            reporter.Config.DocumentTitle = "Sebesség konvertálás teszt riport";
            reporter.Config.ReportName = "Sebesség konvertálás";
            reporter.Config.Theme = AventStack.ExtentReports.Reporter.Config.Theme.Standard;



        }

        [Test]
        [TestCase(3.6,1)]
        [TestCase(7.2, 2)]
        public void KmhToMs(double kmh,double elvart)
        {
            extTest = extReport.CreateTest("Kmh átszámítása m/s-ra teszt");
            var sebesseg = driver.FindElementByAccessibilityId("textboxKmh");
            sebesseg.Clear();
            driver.FindElementByAccessibilityId("radioMs").Click();
            sebesseg.SendKeys(kmh.ToString());
            driver.FindElementByAccessibilityId("buttonSzamol").Click();
            var eredmeny = driver.FindElementByAccessibilityId("textblockEredmeny");
            Assert.AreEqual(elvart,Convert.ToDouble(eredmeny.Text),0.0005);
            extTest.Log(Status.Pass, "Kmh átszámítása m/s-ra OK");
        }


        [TearDown]
        public static void CloseReport()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace=TestContext.CurrentContext.Result.StackTrace;
            var errormsg = TestContext.CurrentContext.Result.Message;

            if (status==TestStatus.Failed)
            {
                ITakesScreenshot shot = (ITakesScreenshot)driver;
                Screenshot screenshot=shot.GetScreenshot();
                screenshot.SaveAsFile(WPFProgramPath+"error.png",ScreenshotImageFormat.Png);
                extTest.Log(Status.Fail, stacktrace + errormsg);
                extTest.Log(Status.Fail, "Képernyõ:");
                extTest.AddScreenCaptureFromPath("error.png");

            }


        }

        [OneTimeTearDown]
        public void Endtest()
        {
            driver.Close();
            driver.Quit();
        }
    }
}