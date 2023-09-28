using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT3101_Calculator.UnitTests
{

    internal class AdditionCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read("../../../../ICT3101_Calculator/MagicNumbers.txt")).Returns(new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            _calculator = new Calculator();
        }

        [Test]
        public void GenMagicNum_WhenGivenSelectedNumber3_ResultEqualsToMagicNumber()
        {
            // Act
            // Assert
            double result = _calculator.GenMagicNum(3, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(8));
        }
        [Test]
        public void GenMagicNum_WhenGivenSelectedNumberMinus1_ResultEqualsToMagicNumber()
        {
            // Act
            // Assert
            double result = _calculator.GenMagicNum(-1, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void GenMagicNum_WhenGivenSelectedNumber20_ResultEqualsToMagicNumber()
        {
            // Act
            // Assert
            double result = _calculator.GenMagicNum(20, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
