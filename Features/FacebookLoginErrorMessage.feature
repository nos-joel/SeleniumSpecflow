Feature: FacebookLoginErrorMessage

Attempt to login to Facebook using invalid credentials

Scenario: A user cannot authenticate to FB using invalid credentials.
	Given I navigate the to the page https://www.facebook.com/
	When The user enter the username fakeuser123 and password fakeuser123
	And The user clicks the Login button
	Then The user cannot autheticate and the following message is displayed The email or mobile number you entered isn’t connected to an account.
