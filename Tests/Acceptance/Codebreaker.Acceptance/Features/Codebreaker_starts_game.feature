Feature: Code-breaker starts game
	As a code-breaker
	I want to start a game
	So that I can break the code

Scenario: start game
	Given I am a codebreaker
	When I attempt to start the game
	Then I should see on the screen 'Welcome to Codebreaker!'
	And I should see on the screen 'Enter guess:'
