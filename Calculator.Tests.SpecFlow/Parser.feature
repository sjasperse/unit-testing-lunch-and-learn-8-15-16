Feature: Parser can parse simple mathmatical expression
	A parser which can take plan text and process it as mathmatical expressions

Scenario: Can process number plus number (1+1)
	Given the expression "1+1"
	When it is parsed
	Then the result should be "2"

Scenario: Can process variable plus number (x+1) when x = 2
	Given the expression "x+1"
	And that parameter x = 2
	When it is parsed
	Then the result should be "3"

Scenario: Can process variable plus number (x+1) when x = 3
	Given the expression "x+1"
	And that parameter x = 3
	When it is parsed
	Then the result should be "4"
