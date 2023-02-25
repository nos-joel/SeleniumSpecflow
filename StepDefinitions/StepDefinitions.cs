using OpenQA.Selenium;

namespace SeleniumSpecflow.StepDefinitions
{
    [Binding]
    public class StepDefinitions
    {

        Utilities utils;

        //Constructor to create the browser driver and also pass the driver to the Utilities instance.
        StepDefinitions(WebDriver webDriver)
        {
            utils = new Utilities(webDriver.driver);
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

        [Given(@"A user navigates to the Facebook login page (.*)")]
        public void GivenAUserNavigatesToTheFacebookLoginPage(string url)
        {
            utils.OnDriver().Navigate().GoToUrl(url);
        }

        [When(@"The user enter the username (.*) and password (.*)")]
        public void WhenTheUserEnterTheUsernameUserAndPasswordPassword(string user, string password)
        {
            utils.On(PageObjects.Facebook.loginEmail).Input(user);
            utils.On(PageObjects.Facebook.loginPassword).Input(password);
        }

        [When(@"The user clicks the Login button")]
        public void WhenTheUserClicksTheLoginButton()
        {
            utils.On(PageObjects.Facebook.loginButton).Click();
        }

        [Then(@"The user cannot autheticate and the following message is displayed (.*)")]
        public void ThenTheUserCannotAutheticateAndTheFollowingMessageIsDisplayedMessage(string message)
        {
            utils.WaitFor().VisibilityOfElement(PageObjects.Facebook.loginErrorMsg, 3);
            utils.On(PageObjects.Facebook.loginErrorMsg).AssertThat("innerText").Contains(message);
        }
    }
}
