using OpenQA.Selenium;


namespace SampleProjectNunit.Pages
{
    class ResultSearchPage
    {
        private IWebDriver driver;

        IWebElement ResultSearch => this.driver.FindElement(By.CssSelector("#firstHeading"));


        public ResultSearchPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public string SearchResult()
        {
            return this.ResultSearch.Text;

        }
    }
}
