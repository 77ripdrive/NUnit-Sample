using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using SampleProjectNunit.Driver;
using SampleProjectNunit.Pages;

using System;


namespace SampleProjectNunit
{
    [TestFixture]
    class SampleTest
    {
        private IWebDriver driver;
        private string driverType = "chrome";

        [SetUp]
        public void SetUp()
        {
            this.driver = DriverProvider.setUp(driverType);
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

        [Test]
        [TestCase("IBM")]
        public void WikiSearch(String data)
        {
            var homeWiki = new HomeWiKiPage(driver);
            homeWiki.goToPage();
            var resultSearchPage = homeWiki.goToResultPage(data);
            Assert.AreEqual(data, resultSearchPage.SearchResult());

        }
    }
}
