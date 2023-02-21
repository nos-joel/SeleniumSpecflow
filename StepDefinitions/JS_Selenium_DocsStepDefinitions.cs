using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SeleniumSpecflow.StepDefinitions
{
    [Binding]
    public class JS_Selenium_DocsStepDefinitions
    {
        Utilities utils = new Utilities();

        [Given(@"I navigate the to the selenium web page (.*)")]
        public void GivenINavigateTheToTheSeleniumWebPageHttpsSelenium_Dev(string url)
        {
           utils.createDriver();
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
            utils.OnDriver().Quit();
        }

    }
}
