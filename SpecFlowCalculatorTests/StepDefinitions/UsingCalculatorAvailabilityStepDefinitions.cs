using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorAvailabilityStepDefinitions
    {

        private object _result;
        private readonly SharedData sharedData;

        public UsingCalculatorAvailabilityStepDefinitions(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(double p0, double p1)
        {
            _result = sharedData._calculator.Add(p0,p1);
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double p0, double p1)
        {
            _result = sharedData._calculator.Availability(p0, p1);
        }

        [Then(@"the availability result should be (.*)")]
        public void ThenTheAvailabilityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        
    }
}
