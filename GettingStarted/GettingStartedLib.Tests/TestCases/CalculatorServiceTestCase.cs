namespace GettingStartedLib.Tests.TestCases
{
    public class CalculatorServiceTestCase
    {
        public CalculatorServiceTestCase(double n1, double n2, double expectedResult)
        {
            N1 = n1;
            N2 = n2;
            ExpectedResult = expectedResult;
        }

        public double N1 { get; set; }
        public double N2 { get; set; }
        public double ExpectedResult { get; set; }
    }
}