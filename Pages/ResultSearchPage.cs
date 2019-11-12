using OpenQA.Selenium;


namespace SampleProjectNunit.Pages
{
    class ResultSearchPage
    {
        private IWebDriver Driver;

        IWebElement ResultSearch => this.Driver.FindElement(By.CssSelector("#firstHeading"));


        public ResultSearchPage(IWebDriver driver)
        {
            this.Driver = driver;

        }

        public string SearchResult()
        {
            return this.ResultSearch.Text;

        }
    }
}
