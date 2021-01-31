namespace GettingStartedLib.Tests
{
    using System;
    using System.Collections.Generic;
    using Fixtures;
    using FluentAssertions;
    using NUnit.Framework;
    using TestCases;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class CalculatorServise_Tests : ServiceFixture
    {
        private readonly ICalculator _calculator;

        public CalculatorServise_Tests()
        {
            _calculator = CalculatorService;
        }

        public static IEnumerable<CalculatorServiceTestCase> GetCalculatorService_Add_TestCase()
        {
            yield return new CalculatorServiceTestCase(2, 2, 4);
            yield return new CalculatorServiceTestCase(-10, -20, -30);
            yield return new CalculatorServiceTestCase(-10, 20, 10);
            yield return new CalculatorServiceTestCase(2.25d, 3.54d, 5.79);
            yield return new CalculatorServiceTestCase(0, 6, 6);
            yield return new CalculatorServiceTestCase(6, 0, 6);
        }

        public static IEnumerable<CalculatorServiceTestCase> GetCalculatorService_Subtract_TestCase()
        {
            yield return new CalculatorServiceTestCase(10, 5, 5);
            yield return new CalculatorServiceTestCase(10, -5, 15);
            yield return new CalculatorServiceTestCase(-10, 5, -15);
            yield return new CalculatorServiceTestCase(-10, -5, -5);
            yield return new CalculatorServiceTestCase(10, 0, 10);
            yield return new CalculatorServiceTestCase(0, 10, -10);
            yield return new CalculatorServiceTestCase(0, 10, -10);
            yield return new CalculatorServiceTestCase(2.5d, 3.5d, -1d);
        }

        public static IEnumerable<CalculatorServiceTestCase> GetCalculatorService_Multiply_TestCase()
        {
            yield return new CalculatorServiceTestCase(2, 2, 4);
            yield return new CalculatorServiceTestCase(2, 0, 0);
            yield return new CalculatorServiceTestCase(0, 2, 0);
            yield return new CalculatorServiceTestCase(0, 0, 0);
            yield return new CalculatorServiceTestCase(2, -2, -4);
            yield return new CalculatorServiceTestCase(-2, 2, -4);
            yield return new CalculatorServiceTestCase(-2, -2, 4);
            yield return new CalculatorServiceTestCase(2.5d, 2.5d, 6.25d);
        }

        public static IEnumerable<CalculatorServiceTestCase> GeCalculatorService_Divide_TestCases()
        {
            yield return new CalculatorServiceTestCase(2, 2, 1);
            yield return new CalculatorServiceTestCase(2, -2, -1);
            yield return new CalculatorServiceTestCase(-2, 2, -1);
            yield return new CalculatorServiceTestCase(-2, -2, 1);
            yield return new CalculatorServiceTestCase(0, 2, 0);
            yield return new CalculatorServiceTestCase(0, -2, 0);
            yield return new CalculatorServiceTestCase(0, -2, 0);
            yield return new CalculatorServiceTestCase(2, 0, double.PositiveInfinity);
        }

        [Test]
        [TestCaseSource(nameof(GetCalculatorService_Add_TestCase))]
        public void CalculatorService_Add_Test(CalculatorServiceTestCase testCase)
        {
            // Act
            var actualResult = _calculator.Add(testCase.N1, testCase.N2);

            // Assert
            actualResult.Should().Be(testCase.ExpectedResult);
        }

        [Test]
        [TestCaseSource(nameof(GetCalculatorService_Subtract_TestCase))]
        public void CalculatorService_Subtract_Test(CalculatorServiceTestCase testCase)
        {
            // Act
            var actualResult = _calculator.Subtract(testCase.N1, testCase.N2);

            // Assert
            actualResult.Should().Be(testCase.ExpectedResult);
        }

        [Test]
        [TestCaseSource(nameof(GetCalculatorService_Multiply_TestCase))]
        public void CalculatorService_Multiply_Test(CalculatorServiceTestCase testCase)
        {
            // Act
            var actualResult = _calculator.Multiply(testCase.N1, testCase.N2);

            // Assert
            actualResult.Should().Be(testCase.ExpectedResult);
        }

        [Test]
        [TestCaseSource(nameof(GeCalculatorService_Divide_TestCases))]
        public void CalculatorService_Divide_Test(CalculatorServiceTestCase testCase)
        {
            // Act
            var actualResult = _calculator.Divide(testCase.N1, testCase.N2);

            // Assert
            actualResult.Should().Be(testCase.ExpectedResult);
        }
    }
}