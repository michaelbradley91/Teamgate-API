using System.Collections.Generic;
using FluentAssertions;
using TechTalk.SpecFlow;
using TeamgateAPI;

namespace TeamgateAPI.Tests.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly Calculator _calculator;

        public CalculatorSteps(Calculator calculator)
        {
            _calculator = calculator;
        }

        private List<int> numbersEntered { get; set; } = new List<int>();
        private int result { get; set; }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            numbersEntered.Add(p0);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = _calculator.Add(numbersEntered[0], numbersEntered[1]);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            p0.Should().Be(result);
        }
    }
}
