
namespace SeleniumSpecflow.StepDefinitions
{
    [Binding]
    public class VerifySeleniumEntryPageStepDefinitions
    {
        Utilities utils = new Utilities();

        [Given(@"I open the browser")]
        public void GivenIOpenTheBrowser()
        {
            utils.createDriver();
        }

        [When(@"I navigate to the (.*)")]
        public void WhenINavigateToTheHttpsSelenium_Dev(string url)
        {

            utils.OnDriver().Navigate().GoToUrl(url);
        }


        [Then(@"A welcome message appears like (.*)")]
        public void ThenAWelcomeMessageAppears(string message)
        {
            utils.On(PageObjects.Selenium.welcomemsg).AssertThat("innerText").Equals(message);
            utils.OnDriver().Quit();
        }
    }
}
