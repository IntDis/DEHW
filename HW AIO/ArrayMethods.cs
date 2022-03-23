using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AIO
{
    public class ArrayMethods
    {
        public static void PrintArray(int[] array)
        {
            foreach(int i in array)
            {
                Console.Write($"{i} ");
                
            }
            Console.WriteLine();
        }

        public static void SwapAToB<T>(ref T[] array, int firstIndex, int secondIndex)
        {
            if(array.Length == 0)
            {
                throw new ArgumentException("Array length cannot be 0");
            }

            T tmp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = tmp;
        }

        public static int[] GenerateRandomArray(int size)
        {
            if (size < 0)
            {
                throw new ArgumentException("Invalid size");
            }

            int[] array = new int[size];
            for(int i = 0; i < array.Length; i++)
            {
                Random random = new Random();
                array[i] = random.Next(100);
            }
            return array;
        }

        public static int GetMaxElement(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Invalid array");
            }

            int max = array[0];
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }                               //4.1

        public static int GetMinElement(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Invalid array");
            }

            int min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array [i] < min)
                {
                    min = array [i];
                }
            }
            return min;
        }                               //4.2

        public static int GetMinElementIndex(int[] array)
        {

            if (array.Length == 0)
            {
                throw new ArgumentException("Invalid array");
            }

            int minElement = array[0];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minElement)
                {
                    index = i;
                    minElement = array[i];
                }
            }
            return index;
        }                          //4.3

        public static int GetMaxElementIndex(int[] array)
        {

            if (array.Length == 0)
            {
                throw new ArgumentException("Invalid array");
            }

            int maxElement = array[0];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > maxElement)
                {
                    index = i;
                    maxElement = array[i];
                }
            }
            return index;
        }                          //4.4

        public static int GetSumOfEvenIndexNumbers(int[] array)
        {
            int sumOfEvenNumbers = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                sumOfEvenNumbers += array[i];
            }
            return sumOfEvenNumbers;
        }                    //4.5

        public static void ReverseArray(ref int[] array)
        {
            int count = 1;
            for (int i = 0; i < array.Length / 2; i++)
            {
                SwapAToB(ref array, i, array.Length - count);
                count++;

            }
        }                           //4.6

        public static int GetAmountOfOddElements(int[] array)
        {
            int oddCounter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    oddCounter++;
                }
            }
            return oddCounter;
        }                      //4.7

        public static void ReverseHalfOfArray(ref int[] array)
        {
            int evensity = array.Length % 2;

            for (int i = 0; i < array.Length / 2; i++)
            {   
                SwapAToB(ref array, i, array.Length / 2 + i + evensity);
            }
        }                     //4.8

        public static void SortArrayInAscendingOrderByInjection(ref int[] array)
        {

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0 && array[j - 1] > array[j]; j--)
                {
                    SwapAToB(ref array, j - 1, j);
                }
            }
        }   //4.9

        public static void SortArrayInDescendingOrderBySelection(ref int[] array)
        {
            int maxElement;
            int max;
            for (int i = 0; i < array.Length; i++)
            {
                max = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[max])
                    {
                        max = j;
                        maxElement = array[j];
                    }
                }

                SwapAToB(ref array, i, max);
            }
        }  //4.10
    }
}
