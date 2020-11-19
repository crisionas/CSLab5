Feature: Test3

@Regression
Scenario: User is able to contact store representants
	Given I have clicked on Contact button
	And I have entered my name
	And I have entered my email
	And I have entered Subject
	And I have entered Message
	When I press Send button
	Then My message was successfull send