using OpenQA.Selenium;
public static class PageObjects
{
    public static class Selenium
    {
        public static By documentation = By.LinkText("Documentation");
        public static By JsTab = By.Id("tabs-3-04-tab");
        public static By JsCodeSample = By.Id("tabs-3-04");
        public static By welcomemsg = By.XPath("//h1");
    }
    
    public static class Facebook
    {
        public static By loginEmail = By.Id("email");
        public static By loginPassword = By.Id("pass");
        public static By loginButton = By.Name("login");
        public static By loginErrorMsg = By.ClassName("_9ay7");

    }
}
