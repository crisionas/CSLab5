Feature: Test6

@Smoke
Scenario: User can search products on the website
	Given I have entered Searched item
	When I press Search button
	Then The searched item appears.