using NUnit.Framework;

namespace HW_AIO.Tests
{
    public class CyclesTests
    {
        [TestCase(2,3,8)]
        [TestCase(1,0,1)]
        [TestCase(-2,3,-8)]
        public void GetAInDegreeOfBTest(int a, int b, int expected)
        {
            int actual = Cycles.GetAInDegreeOfB(a, b);
            Assert.AreEqual(expected, actual);
        }

        public void GetNumbersIfDivisionByAIsZero(int a, int expected)
        {
            int actual = Cycles.GetNumbersIfDivisionByAIsZero(a);
        }
    }
}