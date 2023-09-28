using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilityStepDefinitions
    {
        private object _result;
        private readonly SharedData sharedData;

        public UsingCalculatorBasicReliabilityStepDefinitions(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }

        [When(@"I have entered (.*) initial failure intensity and (.*) as average expected number of failures and (.*) as total number of failures into the calculator and press Failure Intensity")]
        public void WhenIHaveEnteredInitialFailureIntensityAndAsAverageExpectedNumberOfFailuresAndAsTotalNumberOfFailuresIntoTheCalculatorAndPressFailureIntensity(double p0, double p1, double p2)
        {
            sharedData._result = sharedData._calculator.FailureIntensity(p0, p1, p2);
        }

/*        [Then(@"the Failure Intensity result should be (.*)")]
        public void ThenTheFailureIntensityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }*/

        [When(@"I have entered (.*) as total number of failures and (.*) as initial failure intesnisty and (.*) for number of CPU hours into the calculator and press Expected Failures")]
        public void WhenIHaveEnteredAsTotalNumberOfFailuresAndAsInitialFailureIntesnistyAndForNumberOfCPUHoursIntoTheCalculatorAndPressExpectedFailures(double p0, double p1, double p2)
        {
            sharedData._result = sharedData._calculator.ExpectedFailure(p0, p1, p2);
        }
/*
        [Then(@"the Expected Failure result should be (.*)")]
        public void ThenTheExpectedFailureResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }*/
        

        
    }
}
