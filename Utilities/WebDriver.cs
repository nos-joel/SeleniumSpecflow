using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;


/// <summary>
/// Class to construct the browser driver.
/// </summary>
public class WebDriver : IDisposable
{
    public IWebDriver driver;

    public IWebDriver Driver
    {
        get { return driver; }
        set { Driver = value; }
    }
    
    public WebDriver()
    {
        driver = getDriver();
    }

/// <summary>
/// Method to create the desired browser driver. The driver is configured on the Configurations class
/// </summary>
    public IWebDriver getDriver()
    {
        switch (Configurations.driver_name)
        {
            case "CHROME":
                driver = new ChromeDriver(Configurations.drivers_folder_path);
                break;

            case "FIREFOX":
                driver = new FirefoxDriver();
                break;

            case "EDGE":
                EdgeOptions options = new EdgeOptions();
                options.AddArgument("start-maximized");
                options.AddArgument("--disable-features=msHubApps");

                driver = new EdgeDriver(options);
                break;

            default:
                driver = new ChromeDriver(Configurations.drivers_folder_path);
                break;
        }
        
        return driver;
    }

    /// <summary>
    /// Dispose method to close browser upon test completion
    /// </summary>
    public void Dispose()
    {
        if (driver != null)
        {
            driver.Quit();
        }
    }
}
