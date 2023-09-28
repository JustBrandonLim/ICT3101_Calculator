Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

@BasicReliability
Scenario: Calculate current failure intensity
		Given I have a calculator
		When I have entered 10 initial failure intensity and 50 as average expected number of failures and 100 as total number of failures into the calculator and press Failure Intensity
		Then the Failure Intensity result should be 5
@BasicReliability
Scenario: Calculate average number of expected failures
		Given I have a calculator
		When I have entered 100 as total number of failures and 10 as initial failure intesnisty and 10 for number of CPU hours into the calculator and press Expected Failures
		Then the Expected Failure result should be 63
