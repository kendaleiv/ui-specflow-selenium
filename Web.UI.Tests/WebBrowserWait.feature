Feature: WebBrowserWait
	In order to verify SpecFlow + Selenium is working waiting is working
	As a developer
	I want to do some simple tests

Scenario: Wait for element to exist
	Given I am on the /Home/WaitTesting page
	When I wait for element with id hidden-for-five-seconds to exist
	Then I expect that the element with id hidden-for-five-seconds exists
