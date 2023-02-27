Feature: JS_Selenium_Docs

Navigate the Js's documentation on the selenium.dev page

Scenario: Navigate to the Selenium with Javscript documentation
	Given I navigate the to the page https://selenium.dev
	When I click the main Documentation button
	And Press on the Javascript tab
	Then The Javascript code example is shown
