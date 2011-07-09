Feature: Code-breaker submits guess
	The codebreaker submits a guess of four numbers.
	The game marks the guess with + and - signs

	For each number in the guess that matches the number and 
	position of a number in the secret code, the mark includes one
	+ sign.
	
	For each number in the guess that matches the number but not the 
	position of a number in the secret code, the mark inclues one
	- sign.

Scenario Outline: submit guess
	Given I am a codebreaker
	And there is a secret code generator
	When the secret code generator did set the code to: <code>
	And I attempt to submit a guess: <guess> 
	Then I should see screen text that includes: <mark>

	Scenarios: no matches
	| code | guess | mark |
	| 1234 | 5555  |      |
	
	Scenarios: 1 number correct
	| code | guess | mark |
	| 1234 | 1555  | +    |
	| 1234 | 2555  | -    |

	Scenarios: 2 numbers correct
	| code | guess | mark |
	| 1234 | 5254  | ++   |
	| 1234 | 5154  | +-   |
	| 1234 | 2545  | --   |

	Scenarios: 3 numbers correct
	| code | guess | mark | 
	| 1234 | 5234  | +++  |
	| 1234 | 5134  | ++-  |
	| 1234 | 5124  | +--  |
	| 1234 | 5123  | ---  |

	Scenarios: all numbers correct
	| code | guess | mark | 
	| 1234 | 1234  | ++++ | 
	| 1234 | 1243  | ++-- |
	| 1234 | 1423  | +--- |
	| 1234 | 4321  | ---- |

