using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

/// <summary>
/// WaitForActions class holds the available methods when expecting for the state of an object.
/// </summary>
public class WaitForActions
{
    private IWebDriver driver;

    public IWebDriver Driver
    {
        get { return driver; }
        set { driver = value; }
    }

    /// <summary>
    /// Method to wait for visiblity of element
    /// </summary>
    /// <param name="By selector"></param>
    /// <param name="max_wait_time"></param>
    public void VisibilityOfElement(By selector, double max_wait_time)
    {
        WebDriverWait wdw = new WebDriverWait(driver, TimeSpan.FromSeconds(max_wait_time));
        wdw.Until(d => d.FindElement(selector));
    }
}