Feature: Search Google Feature

@Chrome
Scenario: Simple Google Search
	Given I am on google
	When I search for "SpecFlow"
	Then I get results
