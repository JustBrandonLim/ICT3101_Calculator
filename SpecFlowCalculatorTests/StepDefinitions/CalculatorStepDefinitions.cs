using NUnit.Framework;
using SpecFlowCalculatorTests;
namespace SpecFlowCalculatorTests.StepDefinitions
{


    [Binding]
    public sealed class UsingCalculatorStepDefinitions
    {
/*        private Calculator _calculator;
*/        private object _result;
        private readonly SharedData sharedData;

        public UsingCalculatorStepDefinitions (SharedData sharedData)
        {
            this.sharedData = sharedData;
        }
        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = sharedData._calculator.Add(p0, p1);
        }
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}