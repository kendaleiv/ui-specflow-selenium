﻿using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

namespace Web.UI.Tests
{
    [Binding]
    public class GherkinTableSteps
    {
        private static IEnumerable<CourseInformation> Courses;

        [Given(@"I have the course information")]
        public void GivenIHaveTheCourseInformation(Table table)
        {
            Courses = table.CreateSet<CourseInformation>();
        }

        [When(@"I get a list of available courses")]
        public void WhenIGetAListOfAvailableCourses()
        {
        }

        [Then(@"I should see there are (.*) courses")]
        public void ThenIShouldSeeThereAreCourses(int count)
        {
            Assert.Equal(count, Courses.Count());
        }

        public class CourseInformation
        {
            public string Name { get; set; }
            public string Instructor { get; set; }
            public string Location { get; set; }
            public DateTime Scheduled { get; set; }
        }
    }
}
