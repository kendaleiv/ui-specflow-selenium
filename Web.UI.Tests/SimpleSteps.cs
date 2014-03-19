using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Web.UI.Tests
{
    [Binding]
    public class SimpleSteps
    {
        private static int MarblesCount;

        [Given(@"I have (.*) marbles")]
        public void GivenIHaveMarbles(int count)
        {
            MarblesCount = count;
        }

        [When(@"I give away (.*) marbles")]
        public void WhenIGiveAwayMarbles(int count)
        {
            if (count > MarblesCount)
                throw new ArgumentOutOfRangeException("count must be less than to equal to MarblesCount.");

            MarblesCount = MarblesCount - count;
        }

        [Then(@"I should have (.*) marbles")]
        public void ThenIShouldHaveMarbles(int count)
        {
            Assert.Equal(count, MarblesCount);
        }
    }
}
