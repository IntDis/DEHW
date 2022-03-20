using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AIO
{
    public class Branches
    {
        public static double GetSumOfAAndB(double a, double b)
        {
            if (a > b)
            {
                return a + b;
            }
            else if (a == b)
            {
                return a * b;
            }
            else
                return a - b;
        }                             //2.1

        public static string GetQuarterOfPoint(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                return "Первая четверь";
            }
            else if (x < 0 && y > 0)
            {
                return "Вторая четверть";
            }
            else if (x < 0 && y < 0)
            {
                return "Третья четверть";
            }
            else if (x > 0 && y < 0)
            {
                return "Четвертая четверть";
            }
            else
                return "Точка лежит на оси";
        }                         //2.2

        public static string GetNumbersInAscendingOrder(double a, double b, double c)
        {
            if ((a > b) && (b > c))                  //321
            {
                return $"\nВведённые числа в порядке возрастания: {c}, {b}, {a}.";
            }
            else if ((a > b) && (a > c))             //312
            {
                return $"\nВведённые числа в порядке возрастания: {b}, {c}, {a}.";
            }
            else if ((a < b) && (b > c) && (c < a))  //231
            {
                return $"\nВведённые числа в порядке возрастания: {c}, {a}, {b}.";
            }
            else if ((a > b) && (b < c) && (c > a))  //213
            {
                return $"\nВведённые числа в порядке возрастания: {b}, {a}, {c}.";
            }
            else if ((a < b) && (b > c) && (c > a))  //132
            {
                return $"\nВведённые числа в порядке возрастания: {a}, {c}, {b}.";
            }
            else if ((a < b) && (b < c))             //123
            {
                return $"\nВведённые числа в порядке возрастания: {a}, {b}, {c}.";
            }
            else
                throw new Exception("Problem with input numbers");
        }        //2.3

        public static void GetSolutionOfQuadraticEquation(double a, double b, double c)
        {
            double discr = Math.Pow(b, 2) - 4 * a * c;


            if ((discr > 0) && (a != 0))
            {
                Console.WriteLine($"\nХ1 = {((-b + Math.Sqrt(discr)) / (2 * a))} \nХ2 = {((-b - Math.Sqrt(discr)) / (2 * a))}");
            }
            else if ((discr == 0) && (a != 0))
            {
                Console.WriteLine($"\nX = {(-b) / (2 * a)}");
            }
            else
            {
                Console.WriteLine("\nУравнение не имеет корней.");
            }

        }    //2.4

        public static string GetNumberInWords(int a)
        {
            double firstNumber = a / 10;
            double secondNumber = a % 10;
            string result = "";

            if (firstNumber == 0 || firstNumber > 9)
            {
                throw new Exception("Number is not double-digit");
            }

            if (a < 0)
            {
                result += "Минус ";
                firstNumber = Math.Abs(firstNumber);
                secondNumber = Math.Abs(secondNumber);
            }

            if (firstNumber == 1 && secondNumber == 0)
            {
                result += "Десять";

            }
            else if (firstNumber == 1 && secondNumber == 1)
            {
                result += "Одиннадцать";

            }
            else if (firstNumber == 1 && secondNumber == 2)
            {
                result += "Двенадцать";

            }
            else if (firstNumber == 1 && secondNumber == 3)
            {
                result += "Тринадцать";

            }
            else if (firstNumber == 1 && secondNumber == 4)
            {
                result += "Четырнадцать";

            }
            else if (firstNumber == 1 && secondNumber == 5)
            {
                result += "Пятнадцать";
            }
            else if (firstNumber == 1 && secondNumber == 6)
            {
                result += "Шестнадцать";
            }
            else if (firstNumber == 1 && secondNumber == 7)
            {
                result += "Семнадцать";

            }
            else if (firstNumber == 1 && secondNumber == 8)
            {
                result += "Восемнадцать";

            }
            else if (firstNumber == 1 && secondNumber == 9)
            {
                result += "Девятнадцать";

            }

            if (result == "" || result == "Минус ")
            {
                if (firstNumber == 2)
                    result += "Двадцать";
                else if (firstNumber == 3)
                    result += "Тридцать";
                else if (firstNumber == 4)
                    result += "Сорок";
                else if (firstNumber == 5)
                    result += "Пятьдесят";
                else if (firstNumber == 6)
                    result += "Шестьдесят";
                else if (firstNumber == 7)
                    result += "Семьдесят";
                else if (firstNumber == 8)
                    result += "Восемьдесят";
                else if (firstNumber == 9)
                    result += "Девяносто";

                if (secondNumber == 0) { }

                else if (secondNumber == 1)
                    result += " один";
                else if (secondNumber == 2)
                    result += " два";
                else if (secondNumber == 3)
                    result += " три";
                else if (secondNumber == 4)
                    result += " четыре";
                else if (secondNumber == 5)
                    result += " пять";
                else if (secondNumber == 6)
                    result += " шесть";
                else if (secondNumber == 7)
                    result += " семь";
                else if (secondNumber == 8)
                    result += " восемь";
                else if (secondNumber == 9)
                    result += " девять";
            }



            return result;
        }                                       //2.5
    }
}
