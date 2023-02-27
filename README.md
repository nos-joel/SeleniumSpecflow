# SeleniumSpecflow

A Selenium Specflow project

## Installation
(Assuming you already have Visual Studio installed)

* Clone project (https://github.com/nos-joel/SeleniumSpecflow.git)
* Once in Visual Studio: File > Open > Select project name

## Example

Given the following Gherkin feature

```cs
Feature: JS_Selenium_Docs

Navigate the Js's documentation on the selenium.dev page

@smoke
Scenario: Navigate to the Selenium with Javscript documentation
	Given I navigate the to the selenium web page https://selenium.dev
	When I click the main Documentation button
	And Press on the Javascript tab
	Then The Javascript code example is shown
	Then Close the browser
```
Then the following Step Definitions are:

```cs
[Binding]
    public class JS_Selenium_DocsStepDefinitions
    {
        Utilities utils = new Utilities(); // Instantiate the Utilities class before any method.

        [Given(@"I navigate the to the selenium web page (.*)")]
        public void GivenINavigateTheToTheSeleniumWebPageHttpsSelenium_Dev(string url)
        {
            utils.createDriver(); // Create the driver
            utils.OnDriver().Navigate().GoToUrl(url); //Navigate to the url parameter
        }

        [When(@"I click the main Documentation button")]
        public void WhenIClickTheMainDocumentationButton()
        {
            utils.On(PageObjects.Selenium.documentation).Click();  //Use the On method and pass on the "Documentation" locator.
        }

        [When(@"Press on the Javascript tab")]
        public void WhenPressOnTheJavascriptTab()
        {
            utils.On(PageObjects.Selenium.JsTab).Click();
        }

        [Then(@"The Javascript code example is shown")]
        public void ThenTheJavascriptCodeExampleIsShown()
        {
            utils.WaitFor().VisibilityOfElement(PageObjects.Selenium.JsCodeSample, 3); //Wait for element's object visibility
            utils.On(PageObjects.Selenium.JsCodeSample).AssertThat("class").Contains("active show");

        }

        [Then(@"Close the browser")]
        public void ThenCloseTheBrowser()
        {
            utils.OnDriver().Quit();
        }
    }
```
## Usage

**1.** Initialize the Utilities class. No arguments are needed during initialization.
```cs
Utilities u = new Utilities();
```

**2.** Create the driver. Note: the driver type is created based on a global property.
```cs
u.createDriver();
```

**3.** Two options are available when it comes to using the driver object.

a. You could retrieve the driver object by
```cs
IWebDriver driver = u.getDriver();
```
### or 
b. Use the OnDriver method 
```cs
u.OnDriver().findElementBy...
```

**4.** Use any of the available methods below.

## Available Methods

 **OnDriver**

This methods is basically a getter of the browser's driver. This allows a seamless integration with this framework's sintaxis.

```cs
OnDriver()
```

*Example*
```cs
u.OnDriver().Navigate().GoToUrl(url);
```
**On**

This method will be used for most of the actions performed on an object like *click*, *sendKeys* and *select*. This method requires an input, either a selector (*By*) or an object (*IWebElement*).

```cs
On()
```
*Example*

```cs
On(By.Id("id")).Click();
```
```cs
IWebElement element = u.OnDriver().findElement(By.Id("id"));
u.On(element).Click();
```

Available **On** Actions

*Click*
```cs
u.On(selector).Click();
```
*Input*
```cs
u.On(selector).Input("input text"); // SendKeys
```
*SelectByValue*
```cs
u.On(selector).SelectByValue(value);
```
*SelectByIndex*
```cs
u.On(selector).SelectByIndex(value);
```
*SelectByText*
```cs
u.On(selector).SelectByText(value);
```
*AssertThat*
```cs
u.On(selector).AssertThat(args);
```

**AssertThat**

This method is used when performing assertions over an object.

*Equals*

```cs
u.On(selector).AssertThat(attribute-name).Equals(expected-value);
```
*Contains*

```cs
u.On(selector).AssertThat(attribute-name).Contains(expected-value);
```


**Wait**

Wait for visibility of element.

```cs
u.WaitFor().VisibilityOfElement(By locator,  int wait-time);
```
*Example*

```cs
u.WaitFor().VisibilityOfElement(By.Id("id"), 5);
```
