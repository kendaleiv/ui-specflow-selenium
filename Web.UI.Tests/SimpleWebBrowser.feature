Feature: SimpleWebBrowser
	In order to verify SpecFlow + Selenium is working
	As a developer
	I want to do some simple tests

Scenario: Verify root page content
	Given I am on the / page
	Then I expect to see the text ASP.NET

Scenario: Verify about page content
	# Includes leading slash on url
	Given I am on the /Home/About page
	Then I expect to see the text Your application description page.

Scenario: Verify contact page content
	# No leading slash on url
	Given I am on the Home/Contact page
	Then I expect to see the text Your contact page.

Scenario: Verify Home button on navbar works
	Given I am on the /Home/Contact page
	When I click Home on the navbar
	Then I expect to be at the / page