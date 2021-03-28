Feature: EaApp Login
	Check if Login functionality works

@mytag
Scenario: Login user as administrator
	Given I have navigated to EAapp application
	And I click the login link
	And I have entered username and password
		| UserName | Password |
		| admin    | password    |
	When I click Login
	Then I should see user logged int to the application
