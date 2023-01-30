using OpenQA.Selenium;
public static class PageObjects
{
    public static class Selenium
    {
        public static By documentation = By.LinkText("Documentation");
        public static By JsTab = By.Id("tabs-3-4-tab");
        public static By JsCodeSample = By.Id("tabs-3-4");
        public static By welcomemsg = By.XPath("//h1");
    }
}
