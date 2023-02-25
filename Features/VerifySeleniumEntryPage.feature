Feature: VerifySeleniumEntryPage

Verify welcome message on Selenium web page

Scenario: Once I land on the selenium web page, a welcome message is displayed
	Given I navigate the to the page https://selenium.dev
	Then A welcome message appears like Selenium automates browsers. That's it!
