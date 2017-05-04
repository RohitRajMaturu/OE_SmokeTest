Feature: Login and Logout
	
@Smoke Test
Scenario: Logging and logout
	Given I have launched the application
	When  I have logged into the application
	When I agree to sell a car
	And I should check for alertBox
	Then I should land on home page
	Then I should logout

