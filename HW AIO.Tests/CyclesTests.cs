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
        }                                                  //3.1


        [TestCase(100, new int[] {100, 200, 300, 400, 500, 600, 700, 800, 900, 1000})]
        [TestCase(333, new int[] {333, 666, 999})]
        [TestCase(1000, new int[] {1000})]
        public void GetNumbersIfDivisionByAIsZeroTest(int a, int[] expected)
        {
            int[] actual = Cycles.GetNumbersIfDivisionByAIsZero(a);
            Assert.AreEqual(expected, actual);
        }                                         //3.2 


        [TestCase(0, 0)]
        [TestCase(100, 9)]
        [TestCase(-101, 10)]
        public void GetCountOfNumbersIfTheirSquareIsLowerThanATest(int a, int expected)
        {
            int actual = Cycles.GetCountOfNumbersIfTheirSquareIsLowerThanA(a);
            Assert.AreEqual(expected, actual);
        }                              //3.3


        [TestCase(135, 45)]
        [TestCase(99, 33)]
        [TestCase(56, 28)]
        public void GetMaxDividerOfATest(int a, int expected)
        {
            int actual = Cycles.GetMaxDividerOfA(a);
            Assert.AreEqual(expected, actual);
        }                                                        //3.4


        [TestCase(0, 15, 21)]
        [TestCase(20, 50, 175)]
        [TestCase(0, 0, 0)]
        public void GetSumOfNumbersFromAToBWhichDivisionBySevenIsZeroTest(int a, int b, int expected)
        {
            int actual = Cycles.GetSumOfNumbersFromAToBWhichDivisionBySevenIsZero(a, b);
            Assert.AreEqual(expected, actual);
        }                //3.5

        [TestCase(2, 1)]
        [TestCase(5, 5)]
        [TestCase(10, 55)]
        public void GetPositonValueFromFibonacciTest(int a, int expected)
        {
            int actual = Cycles.GetPositonValueFromFibonacci(a);
            Assert.AreEqual(expected, actual);
        }                                            //3.6

        [TestCase(30, 18, 6)]
        [TestCase(32, 48, 16)]
        [TestCase(-28, -64, 4)]
        public void GetMaxDividerOfTwoNumbersByEuclidTest(int a, int b, int expected)
        {
            int actual = Cycles.GetMaxDividerOfTwoNumbersByEuclid(a, b);
            Assert.AreEqual(expected, actual);
        }                                //3.7

        [TestCase(27, 3)]
        [TestCase(1000, 10)]
        [TestCase(64, 4)]
        public void GetThirdRootFromNumberByHalfDivisionTest(int a, int expected)
        {
            int actual = Cycles.GetThirdRootFromNumberByHalfDivision(a);
            Assert.AreEqual(expected, actual);
        }                                    //3.8

        [TestCase(64, 2)]
        [TestCase(222, 3)]
        [TestCase(1091, 1)]
        public void GetCountOfEvenDigitsInNumberTest(int a, int expected)
        {
            int actual = Cycles.GetCountOfEvenDigitsInNumber(a);
            Assert.AreEqual(expected, actual);
        }                                            //3.9

        [TestCase(1234, "4321")]
        [TestCase(-128, "-821")]
        [TestCase(1002, "2001")]
        public void GetReversedNumberTest(int a, string expected)
        {
            string actual = Cycles.GetReversedNumber(a);
            Assert.AreEqual(expected, actual);
        }                                                    //3.10

        public void WriteNumbersIfEvenDigitsSumBiggerThanOdd(int a)
        {

        }                                                  //3.11 rewrite using array instead of Console.WriteLine()

        [TestCase(100, 1, true)]
        [TestCase(238, -8, true)]
        [TestCase(3, 2048, false)]
        public void AreNumbersHavingSameDigitsTest(int a, int b, bool expected)
        {
            bool actual = Cycles.AreNumbersHavingSameDigits(a, b);
            Assert.AreEqual(expected, actual);
        }                                      //3.12
    }
}