Feature: Login and Logout
	
@Smoke Test
Scenario: Logging in
	Given I have launched the application
	When  I have logged into the application
	When I agree to sell a car
	And I should check for alertBox
	Then I should land on home page
	
@Smoke Test
Scenario: Adding Customer
	Given I am on Homepage
	When I hover on customer menu 
	And I hover on Retail Menu
	And  I click on Add customer
	Then I should land on customerFind page
	When I can search for a customer by lastname
	Then I should click on AddNew button
	And I should land on CustomerAdd screen
	Given I should fill the form with basic info
	When I click on Save Customer Info
	Then I should redirect to Customer View Screen

	
     

