using OpenQA.Selenium;

/// <summary>
/// This class holds most actions as creation of the driver, driver getter, and common selenium actions to
/// perform on an object.
/// </summary>
 
public class Utilities
{
    
    private IWebDriver driver;

    WaitForActions waitforactions;
    OnActions onactions = new OnActions();

    public Utilities(IWebDriver _driver)
    {
        driver = _driver;

        waitforactions = new WaitForActions();
        waitforactions.Driver = driver;
    }

    /// <summary>
    /// getDriver fuction returns the driver object of the configured Browser 
    /// </summary>
    /// <returns>driver</returns>
    public IWebDriver getDriver()
    {
        return driver;
    }

    /// <summary>
    /// WaitFor method that returns available chained actions for the WaitFor operations
    /// </summary>
    /// <returns>WaitForActions class</returns>
    public WaitForActions WaitFor()
    {
        return waitforactions;
    }

    /// <summary>
    /// Method that returns available chained actions on the element being interactied with
    /// </summary>
    /// <param name="IWebElement element"></param>
    /// <returns>OnActions class</returns>
    public OnActions On(IWebElement element)
    {
        onactions.Element = element;
        return onactions;
    }

    /// <summary>
    /// Method that returns available chained actions on the selector being interactied with
    /// </summary>
    /// <param name="By selector"></param>
    /// <returns>OnActions class</returns>
    public OnActions On(By selector)
    {
        try
        {
            IWebElement element = driver.FindElement(selector);
            onactions.Element = element;
        }
        catch (NoSuchElementException ex)
        {
            //Needs completion
            onactions.Element = null;
        }

        return onactions;
    }

    /// <summary>
    /// OnDriver method returns the driver's object.
    /// </summary>
    /// <returns>IWebDriver driver</returns>
    public IWebDriver OnDriver()
    {
        return driver;
    }


}