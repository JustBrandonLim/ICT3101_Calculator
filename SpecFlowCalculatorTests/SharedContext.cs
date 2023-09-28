using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    public class SharedData
    {
        public Calculator _calculator;
        public object _result;
    }
    [Binding]
    public class SharedContext
    {
        private readonly SharedData sharedData;
        public SharedContext (SharedData sharedData)
        {
            this.sharedData = sharedData;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            sharedData._calculator = new Calculator();
        }

        [Then(@"the Failure Intensity result should be (.*)")]
        public void ThenTheFailureIntensityResultShouldBe(double p0)
        {
            Assert.That(sharedData._result, Is.EqualTo(p0));
        }

        [Then(@"the Expected Failure result should be (.*)")]
        public void ThenTheExpectedFailureResultShouldBe(int p0)
        {
            Assert.That(sharedData._result, Is.EqualTo(p0));
        }
    }
}
