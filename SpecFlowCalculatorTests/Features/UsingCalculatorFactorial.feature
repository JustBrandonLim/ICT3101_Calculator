Feature: UsingCalculatorFactorial

@Factorial
Scenario: Doing a factorial for a number
		Given I have a calculator
		When I have entered 5 and press factorial
		Then the factorial result should be 120
@Factorial
Scenario: Doing a factorial for zero
		Given I have a calculator
		When I have entered 0 and press factorial
		Then the factorial result should be 1
