using System;
using Example;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace MyProject.Specs
{
    [Binding]
    public class CalculatorSteps : TestBase
    {
        private Calculator calculator = new Calculator();

        private int result;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calculator.SecondNumber = number;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calculator.Add();
        }

        [When(@"I press Jian")]
        public void WhenIPressJian()
        {
            result = calculator.Jian();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }

        [Then(@"the result should not be (.*) on the screen")]
        public void ThenTheResultShouldNotBeOnTheScreen(int unexpectedResult)
        {
            Assert.AreNotEqual(unexpectedResult, result);
        }
    }
}
