using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorLogarithmicReliabilityStepDefinitions
    {
        private object _result;
        private readonly SharedData sharedData;

        public UsingCalculatorLogarithmicReliabilityStepDefinitions(SharedData sharedData)
        {
            this.sharedData = sharedData;
        }

        [When(@"I enter (.*) defects and (.*) KLOC and press Defect Density")]
        public void WhenIEnterDefectsAndKLOCAndPressDefectDensity(double p0, double p1)
        {
            _result = sharedData._calculator.Divide(p0, p1);
        }

        [Then(@"the Defect Density result should be (.*) defects/KLOC")]
        public void ThenTheDefectDensityResultShouldBeDefectsKLOC(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"I enter (.*) KLOC for previous SSI and (.*) KLOC for CSI and (.*) KLOC for deleted code and (.*) KLOC for changed code and press SSI")]
        public void WhenIEnterKLOCForPreviousSSIAndKLOCForCSIAndKLOCForDeletedCodeAndKLOCForChangedCodeAndPressSSI(double p0, double p1, double p2, double p3)
        {
            _result = sharedData._calculator.SSI(p0, p1, p2, p3);
        }

        [Then(@"the current SSI result is (.*) KLOC")]
        public void ThenTheCurrentSSIResultIsKLOC(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"I enter (.*) for failure intensity decay and (.*) for the failure intesity and (.*) for the expected numebr of failures and press Failure intensity")]
        public void WhenIEnterForFailureIntensityDecayAndForTheFailureIntesityAndForTheExpectedNumebrOfFailuresAndPressFailureIntensity(double p0, double p1, double p2)
        {
            sharedData._result = sharedData._calculator.LogarithmicFailureIntensity(p0, p1, p2);
        }

/*        [Then(@"the Failure Intensity result should be (.*)")]
        public void ThenTheFailureIntensityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }*/

        [When(@"I enter (.*) for failure intensity decay and (.*) for the failure intesity and (.*) for number of CPU hours and press Failure intensity")]
        public void WhenIEnterForFailureIntensityDecayAndForTheFailureIntesityAndForNumberOfCPUHoursAndPressFailureIntensity(double p0, int p1, int p2)
        {
            sharedData._result = sharedData._calculator.LogarithmicExpectedFailure(p0, p1, p2);
        }
/*
        [Then(@"the Expected Failure result should be (.*)")]
        public void ThenTheExpectedFailureResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }*/
    }
}
