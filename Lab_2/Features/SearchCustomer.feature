@setup_feature
Feature: SearchCustomer

Scenario: Search Customer
	Given the user is on the main page
	When the user clicks on the Bank Manager Login
	And the user clicks on Customers
	And the user enters the customer
	Then the result Customer should display
