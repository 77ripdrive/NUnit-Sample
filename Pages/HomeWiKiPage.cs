using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SampleProjectNunit.Pages
{
    class HomeWiKiPage
    {
        private IWebDriver driver;
       
        public HomeWiKiPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        IWebElement SearchField => this.driver.FindElement(By.XPath("//*[@id='searchInput']"));
        IWebElement SearchButton => this.driver.FindElement(By.CssSelector("#search-form > fieldset > button > i"));

        public void OpenPage()
        {
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");
        }

        public ResultSearchPage OpenResultPage(String data)
        {
            this.SearchField.SendKeys(data);
            this.SearchButton.Click();
            return new ResultSearchPage(driver);
        }

    }
}

