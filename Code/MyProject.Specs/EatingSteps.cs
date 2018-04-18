using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Example;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestOperations;

namespace MyProject.Specs
{
    [Binding]
    public class EatingSteps
    {
        private Calculator calculator = new Calculator();
        private int result;

        [Given(@"test name: (.*)")]
        public void GivenTestName(string testname)
        {
            // only for display tests' name
        }

        [Given(@"there are (.*) cucumbers")]
        public void GivenThereAreCucumbers(int start)
        {
            calculator.FirstNumber = start;
        }

        [Given(@"we have following cucumber objects:")]
        public void GivenWeHaveFollowingCucumberObjects(IEnumerable<Cucumber> table)
        {
            Debug.WriteLine(table.Count());
        }

        [When(@"I eat (.*) cucumbers")]
        public void WhenIEatCucumbers(int eat)
        {
            calculator.SecondNumber = eat;
            result = calculator.Jian();
        }

        [Then(@"I should have (.*) cucumbers")]
        public void ThenIShouldHaveCucumbers(int left)
        {
            Assert.AreEqual(left, result);
        }
    }
}
