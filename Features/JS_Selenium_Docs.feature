Feature: JS_Selenium_Docs

Navigate the Js's documentation on the selenium.dev page

@tag1
Scenario: Navigate to the Selenium with Javscript documentation
	Given I navigate the to the selenium web page https://selenium.dev
	When I click the main Documentation button
	And Press on the Javascript tab
	Then The Javascript code example is shown
	Then Close the browser
