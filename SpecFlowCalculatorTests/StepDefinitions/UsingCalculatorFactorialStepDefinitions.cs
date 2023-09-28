using NUnit.Framework;
using TechTalk.SpecFlow.CommonModels;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorFactorialStepDefinitions
    {
        private object _result;
        private readonly SharedData sharedData;

        public UsingCalculatorFactorialStepDefinitions(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }

        [When(@"I have entered (.*) and press factorial")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(double p0)
        {
            _result = sharedData._calculator.Factorial(p0);
        }

        [Then(@"the factorial result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
    }
}
