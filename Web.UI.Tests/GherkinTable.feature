Feature: GherkinTable
	In order to demonstrate Gherkin tables
	As a developer
	I want to do some simple tests using Gherkin tables

Scenario: Class list count
	Given I have the course information
	| Name                    | Instructor | Location                     | Scheduled         |
	| Introduction to Command | Janeway    | Ready Room                   | 4/3/2014 8:00 AM  |
	| Logic And You           | Tuvok      | Starboard Large Meeting Room | 4/3/2014 9:00 AM  |
	| Warp Core Basics        | Torres     | Engineering Meeting Room 3   | 4/3/2014 9:00 AM  |
	| Fundamentals of Cooking | Neelix     | Mess Hall                    | 4/3/2014 10:00 AM |
	When I get a list of available courses
	Then I should see there are 4 courses

Scenario: Get instructor for course
	Given I have the course information
	| Name                    | Instructor | Location                     | Scheduled         |
	| Introduction to Command | Janeway    | Ready Room                   | 4/3/2014 8:00 AM  |
	| Logic And You           | Tuvok      | Starboard Large Meeting Room | 4/3/2014 9:00 AM  |
	| Warp Core Basics        | Torres     | Engineering Meeting Room 3   | 4/3/2014 9:00 AM  |
	| Fundamentals of Cooking | Neelix     | Mess Hall                    | 4/3/2014 10:00 AM |
	When I get a list of available courses
	Then I should see Janeway is instructing Introduction to Command

Scenario: Verify scheduled datetime for course
	Given I have the course information
	| Name                    | Instructor | Location                     | Scheduled         |
	| Introduction to Command | Janeway    | Ready Room                   | 4/3/2014 8:00 AM  |
	| Logic And You           | Tuvok      | Starboard Large Meeting Room | 4/3/2014 9:00 AM  |
	| Warp Core Basics        | Torres     | Engineering Meeting Room 3   | 4/3/2014 9:00 AM  |
	| Fundamentals of Cooking | Neelix     | Mess Hall                    | 4/3/2014 10:00 AM |
	When I get a list of available courses
	Then I should see Introduction to Command is scheduled for 4/3/2014 8:00 AM