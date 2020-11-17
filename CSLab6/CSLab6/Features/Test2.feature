Feature: Test2

@Smoke
Scenario: User is able to Sign In
	Given I have clicked on Sign In button
	And I have entered my Name.
	And I have entered my Email.
	When I press Sign In button. 
	Then My account should be successful logged.