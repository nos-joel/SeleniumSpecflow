using OpenQA.Selenium;

namespace SeleniumSpecflow.StepDefinitions
{
    [Binding]
    public class SeleniumStepDefinitions
    {

        Utilities utils;

        //Constructor to create the browser driver and also pass the driver to the Utilities instance.
        SeleniumStepDefinitions(WebDriver webDriver)
        {
            utils = new Utilities(webDriver.Driver);
        }

        [Given(@"I navigate the to the page (.*)")]
        public void GivenINavigateTheToThePage(string url)
        {
            utils.OnDriver().Navigate().GoToUrl(url);
        }

        [When(@"I click the main Documentation button")]
        public void WhenIClickTheMainDocumentationButton()
        {
            utils.On(PageObjects.Selenium.documentation).Click();
        }

        [When(@"Press on the Javascript tab")]
        public void WhenPressOnTheJavascriptTab()
        {
            utils.On(PageObjects.Selenium.JsTab).Click();
        }

        [Then(@"The Javascript code example is shown")]
        public void ThenTheJavascriptCodeExampleIsShown()
        {
            utils.WaitFor().VisibilityOfElement(PageObjects.Selenium.JsCodeSample, 3);
            utils.On(PageObjects.Selenium.JsCodeSample).AssertThat("class").Contains("active show");
        }

        [Then(@"A welcome message appears like (.*)")]
        public void ThenAWelcomeMessageAppears(string message)
        {
            utils.On(PageObjects.Selenium.welcomemsg).AssertThat("innerText").Equals(message);
        }
    }
}
