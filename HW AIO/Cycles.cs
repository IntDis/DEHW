using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AIO
{
    public class Cycles
    {
        public static int GetAInDegreeOfB(int a, int b)                                             //3.1 
        {
            if (b == 0)
            {
                return 1;
            }
            else if (b < 0)
            {
                throw new Exception("B cannot be lower than 0");
            }
            else
            {
                int result = a;
                for (int i = 1; i < b; i++)
                {
                    result *= a;
                }
                return result;
            }
            
        }

        public static void GetNumbersIfDivisionByAIsZero(int a)                                     //3.2
        {
            if (a <= 0)
            {
                throw new Exception("A cannot be 0 or lower");
            }
            else
            {
                for (int i = 0; i < 1001; i += a)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        public static int GetCountOfNumbersIfTheirSquareIsLowerThanA(int a)                         //3.3
        {
            int count = 0;

            for (int i = 1; i * i < Math.Abs(a); i++)
            {
                count += 1;
            }

            return count;
        }

        public static int GetMaxDividerOfA(int a)                                                   //3.4
        {
            int result = 0;

            for (int i = a - 1; (a % i) != 0; i--)
            {
                result = i - 1;
            }

            return result;
        }

        public static int GetSumOfNumbersFromAToBWhichDivisionBySevenIsZero(int a, int b)           //3.5
        {
            int sum = 0;

            if (a > b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }

            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                    sum += i;
            }

            return sum;
        }

        public static int GetPositonValueFromFibonacci(int a)                                       //3.6
        {
            int firstValue = 1;
            int secondValue = 1;
            int result = 1;

            if (a > 0)
            {
                for (int i = 0; i < a - 2; i++)
                {
                    result = firstValue + secondValue;
                    firstValue = secondValue;
                    secondValue = result;
                }
                return result;
            }
            else
            {
                throw new Exception("Введено неверное число");
            }

        }

        public static int GetMaxDividerOfTwoNumbersByEuclid(int a, int b)                           //3.7
        {
            int rest = 0;

            while (a % b != 0)
            {
                rest = a % b;
                a = b;
                b = rest;
            }
            return b;
        }

        public static int GetThirdRootFromNumberByHalfDivision(int a)                               //3.8
        {
            int rightBorder = a;
            int result = a;

            while (a != Math.Pow(result, 3))
            {
                result = rightBorder / 2;

                if (Math.Pow(result, 3) > a)
                {
                    rightBorder = result;
                }
                else if (Math.Pow(result, 3) < a)
                {
                    rightBorder += 1;
                }

            }

            return result;
        }

        public static int GetCountOfEvenDigitsInNumber(int a)                                       //3.9
        {


            string aLenght = Math.Abs(a).ToString();
            int count = 0;

            for (int i = 0; i < aLenght.Length; i++)
            {
                int tmp = a % 10;

                if (tmp % 2 == 0)
                {
                    count++;
                }

                a /= 10;
            }

            return count;
        }

        public static string GetReversedNumber(double a)                                            //3.10
        {
            string result = "";

            if (a < 0)
            {
                result = "-";
                a = Math.Abs(a);
            }

            string aLenght = a.ToString();

            for (int i = 0; i < aLenght.Length; i++)
            {
                result += a % 10;
                a /= 10;
            }
            return result;
        }

        public static void WriteNumbersIfEvenDigitsSumBiggerThanOdd(int a)                          //3.11
        {
            for (int i = 0; i < a; i++)
            {
                int sumEven = 0;
                int sumOdd = 0;
                int copyI = i;

                while (copyI != 0)
                {

                    int tmp = copyI % 10;

                    if (tmp % 2 == 0)
                    {
                        sumEven += tmp;
                    }
                    else
                        sumOdd += tmp;

                    copyI /= 10;
                }

                if (sumEven > sumOdd)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        public static bool AreNumbersHavingSameDigits(int a, int b)                                 //3.12
        {
            bool result = false;
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int tmpA = a;
                int crnt = b % 10;

                while (tmpA != 0)
                {

                    if (tmpA % 10 != crnt)
                    {
                        tmpA /= 10;
                    }
                    else
                    {
                        result = true;
                        break;
                    }
                }
                b /= 10;
            }

            return result;
        }
    }
}
