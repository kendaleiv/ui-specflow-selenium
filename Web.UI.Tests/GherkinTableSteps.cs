using System;
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
            // If this was an actual UI test
            // We might be invoking the browser here.
        }

        [Then(@"I should see there are (.*) courses")]
        public void ThenIShouldSeeThereAreCourses(int count)
        {
            Assert.Equal(count, Courses.Count());
        }

        [Then(@"I should see (.*) is instructing (.*)")]
        public void ThenIShouldSeeIsInstructing(string instructor, string name)
        {
            var course = Courses.Single(
                x => string.Equals(x.Name, name, StringComparison.OrdinalIgnoreCase));

            Assert.Equal(instructor, course.Instructor);
        }

        [Then(@"I should see (.*) is scheduled for (.*)")]
        public void ThenIShouldSeeIsScheduledFor(string name, string scheduled)
        {
            var scheduledDateTime = DateTime.Parse(scheduled);

            var course = Courses.Single(
                x => string.Equals(x.Name, name, StringComparison.OrdinalIgnoreCase));

            Assert.Equal(scheduledDateTime, course.Scheduled);
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
