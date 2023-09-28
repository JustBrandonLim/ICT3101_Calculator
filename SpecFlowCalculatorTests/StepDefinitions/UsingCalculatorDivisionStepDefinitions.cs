using NUnit.Framework;
using TechTalk.SpecFlow.CommonModels;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorDivisionStepDefinitions
    {
        private object _result;
        private readonly SharedData sharedData;

        public UsingCalculatorDivisionStepDefinitions(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }
        
        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(double p0, double p1)
        {
            _result = sharedData._calculator.Divide(p0, p1);
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        [Then(@"the division result equals positive_infinity")]
        public void ThenTheDivisionResultequals()
        {
            Assert.IsTrue(double.IsPositiveInfinity((double)_result));
        }
    }
}
