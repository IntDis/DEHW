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
        }                           //3.1


        [TestCase(100, new int[] {100, 200, 300, 400, 500, 600, 700, 800, 900, 1000})]
        [TestCase(333, new int[] {333, 666, 999})]
        [TestCase(1000, new int[] {1000})]
        public void GetNumbersIfDivisionByAIsZeroTest(int a, int[] expected)
        {
            int[] Actual = Cycles.GetNumbersIfDivisionByAIsZero(a);
            Assert.AreEqual(expected, Actual);
        }                  //3.2 


        [TestCase(0, 0)]
        [TestCase(100, 9)]
        [TestCase(-101, 10)]
        public void GetCountOfNumbersIfTheirSquareIsLowerThanA(int a, int expected)
        {
            int actual = Cycles.GetCountOfNumbersIfTheirSquareIsLowerThanA(a);
            Assert.AreEqual(expected, actual);
        }           //3.3


        [TestCase(135, 45)]
        [TestCase(99, 33)]
        [TestCase(56, 28)]
        public void GetMaxDividerOfA(int a, int expected)
        {
            int actual = Cycles.GetMaxDividerOfA(a);
            Assert.AreEqual(expected, actual);
        }                                     //3.4
    }
}