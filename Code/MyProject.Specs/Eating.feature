Feature: Eating outline test

Scenario Outline: eating
  Given test name: <testname>
  And there are <start> cucumbers
  And we have following cucumber objects:
	| Name | Desc     |
	| Cu0  | desc_cu0 |
	| Cu1  | desc_cu1 |
	| Cu2  | desc_cu2 |
	| Cu3  | desc_cu3 |
	| Cu4  | desc_cu4 |

  When I eat <eat> cucumbers
  Then I should have <left> cucumbers

  Examples:
    | testname		| start | eat	| left	|
    | test name 1,	| 12    | 5		| 7		|
    | test name 2,	| 20	| 5		| 15	|
