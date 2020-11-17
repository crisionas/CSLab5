Feature: Test5

@Regression
Scenario: User can add an review for an product.
	Given I have clicked on Shop button
	And I have clicked on Quick View button
	And I have clicked Reviews tab
	And I have entered Name
	And I have entered Email
	And I have entered Message.
	When I press Send button.
	Then The review has been send