using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AIO
{
    public class Variables
    {

        public static void GetADividedByB(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("B cannot be 0");
            }
            else
                Console.WriteLine($"{a}:{b} = {a / b}, остаток = {a % b}");
        }                                    //1

        public static double GetSolutionOfQuadraticEquation(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("B cannot be 0");
            }
            else
            {
                return (5 * a + b * b) / (b - a);
            }
        }                  //2

        public static void SwapAtoB(ref string a, ref string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
        }                            //3

        public static void SwapAToBInts(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
            
        }

        public static double GetSolutionOfLinearEquation(int a, int b, int c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                throw new Exception("Input values cannot be 0");
            }
            else
            {
                return (c - b) / a;
            }
        }              //4

        public static string GetLinearEquation(double x1, double y1, double x2, double y2)
        {
            double k = (y1 - y2) / (x1 - x2);
            double b = y2 - k * x2;

            if (b == 0)
            {
                return ($"\nY = {k}X");
            }
            else if (b < 0)
            {
                return ($"\nY = {k}X + ({b})");
            }
            else
                return ($"\nY = {k}X + {b}");
        }   //5
    }
}
