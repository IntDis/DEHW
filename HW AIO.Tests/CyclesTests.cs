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

        public void GetNumbersIfDivisionByAIsZero(int a, int expected)
        {
            
        }                        //3.2 not finished


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