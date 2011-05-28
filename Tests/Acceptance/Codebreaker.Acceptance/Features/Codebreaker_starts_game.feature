Feature: Code-breaker starts game
	As a code-breaker
	I want to start a game
	So that I can break the code

Scenario: start game
	Given I am a codebreaker
	When I attempt to start the game
	Then I should see screen text that includes: Welcome to Codebreaker!
	And I should see screen text that includes: Enter guess:
