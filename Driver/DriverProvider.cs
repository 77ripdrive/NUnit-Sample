using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace SampleProjectNunit.Driver

{
    class DriverProvider
    {
        private IWebDriver driver;

        private DriverProvider() { }

        public static IWebDriver setUp(string driverType)
        {
            switch (driverType)
            {
                case "firefox":
                    var fireFoxOptions = new FirefoxOptions();
                    fireFoxOptions.AddArguments("--start-maximized");
                    fireFoxOptions.AddAdditionalCapability(CapabilityType.Version, "latest", true);
                    fireFoxOptions.AddAdditionalCapability(CapabilityType.Platform, "Windows 10", true);
                    return new FirefoxDriver(fireFoxOptions);

                default:
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArguments("--start-maximized", "--disable-notifications", "--disable-popup-blocking", "–disable-infobars");
                    chromeOptions.AddAdditionalCapability(CapabilityType.Version, "latest", true);
                    chromeOptions.AddAdditionalCapability(CapabilityType.Platform, "Windows 10", true);
                    return new ChromeDriver(chromeOptions);

            }
        }

    }
}
