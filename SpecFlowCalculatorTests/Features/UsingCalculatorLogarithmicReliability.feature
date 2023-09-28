Feature: UsingCalculatorLogarithmicReliability
Allow system quality engineers to customize the command line calulator program to perform quality metric calculations, 
calculating the defect density of a system, custom calculate Shipped Source Instructions (SSI) from 2nd release onwards, 
calculate Musa Logarithmic model failure intensity and to calculate the number of expected failures


Allow system quality engineers to customize the command line calulator program to perform quality metric calculations
Allow system quality engineers to calculate the defect density of a system
Allow system quality engineers to custom calculate Shipped Source Instructions (SSI) from 2nd release onwards
Allow system quality engineers to calculate Musa Logarithmic model failure intensity
Allow system quality engineers to calculate the Musa Logarithmic model number of expected failures

As a system quality engineers
I want to be able to customize the command line calulator program 
so that i can perform quality metric calculations

(1)As a system quality engineers
I want to to customize the command line calulator program 
so that i can calculate the defect density of a system

(2)As a system quality engineers
I want to to customize the command line calulator program 
so that i can custom calculate Shipped Source Instructions (SSI) from 2nd release onwards

(3)As a system quality engineers
I want to to customize the command line calulator program 
so that i can calculate Musa Logarithmic model failure intensity

(4)As a system quality engineers
I want to to customize the command line calulator program 
so that i can calculate the Musa Logarithmic model number of expected failures



@LogarithmicReliability
Scenario: Calculate Defect Density (1)
	Given I have a calculator
	When I enter 100 defects and 50 KLOC and press Defect Density
	Then the Defect Density result should be 2 defects/KLOC

@LogarithmicReliability
Scenario: Calculate SSI (2)
	Given I have a calculator
	When I enter 50 KLOC for previous SSI and 30 KLOC for CSI and 10 KLOC for deleted code and 10 KLOC for changed code and press SSI
	Then the current SSI result is 60 KLOC

@LogarithmicReliability
Scenario: Calculate logarithmic Failure Intensity (3)
	Given I have a calculator
	When I enter 0.02 for failure intensity decay and 10 for the failure intesity and 50 for the expected numebr of failures and press Failure intensity
	Then the Failure Intensity result should be 3.68

@LogarithmicReliability 
Scenario: Calculate Expected Failure (4)
	Given I have a calculator
	When I enter 0.02 for failure intensity decay and 10 for the failure intesity and 10 for number of CPU hours and press Failure intensity
	Then the Expected Failure result should be 55