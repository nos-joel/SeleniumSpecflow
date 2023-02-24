
using OpenQA.Selenium;

namespace SeleniumSpecflow.StepDefinitions
{
    [Binding]
    public class VerifySeleniumEntryPageStepDefinitions
    {
        Utilities utils;
        IWebDriver driver;

        //Constructor to create the browser driver and also pass the driver to the Utilities instance.
        VerifySeleniumEntryPageStepDefinitions(WebDriver webDriver)
        {
            driver = webDriver.driver;
            utils = new Utilities(driver);
        }

        [Given(@"I navigate to the (.*)")]
        public void GivenINavigateToTheHttpsSelenium_Dev(string url)
        {
            utils.OnDriver().Navigate().GoToUrl(url);
        }

        [Then(@"A welcome message appears like (.*)")]
        public void ThenAWelcomeMessageAppears(string message)
        {
            utils.On(PageObjects.Selenium.welcomemsg).AssertThat("innerText").Equals(message);
        }
    }
}
