Feature: Calculator for Spec Flow
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

@mytag @BAT
Scenario: Jian 2 numbers
	Given I have entered 0 into the calculator
	And I have also entered 99 into the calculator
	When I press Jian
	Then the result should be -99 on the screen
	But the result should not be 99 on the screen
	And the new result should be xxx