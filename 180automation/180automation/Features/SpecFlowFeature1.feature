Feature: Login and Logout
	
@Smoke Test
Scenario: Logging in
	Then I should check for alertBox
	Then I should check for Passwordchange box
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

@Smoke Test
Scenario: Finding Customer
	Given I am on Homepage
	When I hover on customer menu 
	And I hover on Retail Menu
	And  I click on Find customer
	Then I should land on customersearch page
	Then I can search for a customer by lastname or firstname or company name or phone Number


	
     

