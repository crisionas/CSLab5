@setup_feature
Feature: Test1

Feature: Name Of Your Feature

@setup_scenario
Scenario: User is able to Sign Up
	Given I have clicked on Sign Up button
	And I have entered my Name
	And I have entered my Email
	And I have entered my Password
	When I press Sign Up button 
	Then My account should be successful registered.