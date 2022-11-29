using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestExample
{
    [TestClass]
    public class TestExample
    {
        private static IWebDriver driver;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            var options = new ChromeOptions();
            options.AddArguments("--headless");

            driver = new ChromeDriver(options);
        }

        [TestMethod]
        public void VerifyPageTitle()
        {
            driver.Navigate().GoToUrl("http://google.com");
            Assert.AreEqual("Google", driver.Title);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            driver.Quit();
        }
    }
}
