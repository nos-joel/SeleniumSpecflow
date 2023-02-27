using OpenQA.Selenium;

namespace SeleniumSpecflow.StepDefinitions
{
    [Binding]
    public class FacebookStepDefinitions
    {

        Utilities utils;

        //Constructor to create the browser driver and also pass the driver to the Utilities instance.
        FacebookStepDefinitions(WebDriver webDriver)
        {
            utils = new Utilities(webDriver.driver);
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
