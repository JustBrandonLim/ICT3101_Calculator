using TechTalk.SpecFlow.CommonModels;

namespace ICT3101_Caculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        private IFileReader _fileReader;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
            _fileReader = new FileReader();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToSubtraction()
        {
            // Act
            double result = _calculator.Subtract(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToMuliplication()
        {
            // Act
            double result = _calculator.Multiply(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(200));
        }
        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToDivision()
        {
            // Act
            double result = _calculator.Divide(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]

        public void Divide_WithZerosAsInputs_ResultThrowArugmentException(double a, double b)
        {
            // Act
            //double result = _calculator.Divide(a, b);
            // Assert
            Assert.That(() => _calculator.Divide_Zero(a,b), Throws.ArgumentException);
        }
        [Test]
        public void Factorial_WhenFindingFactorialOfANumber0_ResultEqualToFactorial()
        {
            // Act
            double result = _calculator.Factorial(3);
            // Assert
            Assert.That(result, Is.EqualTo(6));
        }
        [Test]
        public void Factorial_WhenFindingFactorialOfANumber1_ResultEqualToFactorial()
        {
            // Act
            // double result = _calculator.Factorial(3.1);
            // Assert
            Assert.Throws<ArgumentException>(() => _calculator.Factorial(3.1), "Factorial is not defined for negative values or non-whole numbers.");
        }
        [Test]
        public void Factorial_WhenFindingFactorialOfANumber2_ResultEqualToFactorial()
        {
            // Act
            // double result = _calculator.Factorial(3);
            // Assert
            Assert.Throws<ArgumentException>(() => _calculator.Factorial(-1), "Factorial is not defined for negative values or non-whole numbers.");
        }
        [Test]
        public void Triangle_WhenApplyingTriangleFormulaWithTwoNumbers_ResultEqualToMuliplication()
        {
            // Act
            double result = _calculator.Triangle(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(100));
        }
        [Test]
        public void Cricle_WhenApplyingCircleFormulaWithTwoNumbers_ResultEqualToMuliplication()
        {
            // Act
            double result = _calculator.Circle(10);
            // Assert
            Assert.That(result, Is.EqualTo(314.2));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }
        [Test]
        public void GenMagicNum_WhenGivenSelectedNumber3_ResultEqualsToMagicNumber()
        {
            // Act
            // Assert
            double result = _calculator.GenMagicNum(3, _fileReader);
            Assert.That(result, Is.EqualTo(8));
        }
        [Test]
        public void GenMagicNum_WhenGivenSelectedNumberMinus1_ResultEqualsToMagicNumber()
        {
            // Act
            // Assert
            double result = _calculator.GenMagicNum(-1, _fileReader);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void GenMagicNum_WhenGivenSelectedNumber20_ResultEqualsToMagicNumber()
        {
            // Act
            // Assert
            double result = _calculator.GenMagicNum(20, _fileReader);
            Assert.That(result, Is.EqualTo(0));
        }

    }
}