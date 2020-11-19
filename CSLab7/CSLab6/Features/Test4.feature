Feature: Test4

@Functional
Scenario: User can acces social media via buttons from footer
	Given Clicked Facebook down
	And Clicked Twitter down
	And Clicked Instagram down
	And Clicked Linkedin down
	Then Open social media