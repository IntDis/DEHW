using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AIO
{
    public class ArrayMethods
    {
        public static int GetMaxElement(int[] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Invalid array");
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

        public static int[] Reverse(int[] array)
        {
            int[] copiedArray = CopyArray(array);

            int count = 1;
            for (int i = 0; i < copiedArray.Length / 2; i++)
            {
                Swap(ref copiedArray, i, copiedArray.Length - count);
                count++;

            }
            return copiedArray;
        }                              //4.6

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

        public static int[] ReverseHalf(int[] array)
        {
            int[] copiedArray = CopyArray(array);
            int evensity = copiedArray.Length % 2;

            for (int i = 0; i < copiedArray.Length / 2; i++)
            {   
                Swap(ref copiedArray, i, copiedArray.Length / 2 + i + evensity);
            }

            return copiedArray;

        }                        //4.8

        public static int[] SortArrayInAscendingOrderByInjection(int[] array)
        {
            int[] copiedArray = CopyArray(array);

            for (int i = 1; i < copiedArray.Length; i++)
            {
                for (int j = i; j > 0 && copiedArray[j - 1] > copiedArray[j]; j--)
                {
                    Swap(ref copiedArray, j - 1, j);
                }
            }
            return copiedArray;
        }      //4.9

        public static int[] SortArrayInDescendingOrderBySelection(int[] array)
        {
            int[] copiedArray = CopyArray(array);
            int maxElement;
            int max;

            for (int i = 0; i < copiedArray.Length; i++)
            {
                max = i;

                for (int j = i + 1; j < copiedArray.Length; j++)
                {
                    if (copiedArray[j] > copiedArray[max])
                    {
                        max = j;
                        maxElement = copiedArray[j];
                    }
                }

                Swap(ref copiedArray, i, max);
            }

            return copiedArray;
        }     //4.10

        public static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write($"{i} ");

            }
            Console.WriteLine();
        }

        public static void Swap<T>(ref T[] array, int firstIndex, int secondIndex)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array length cannot be 0");
            }

            T tmp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = tmp;
        }

        public static int[] CopyArray(int[] array)
        {
            int[] copiedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                copiedArray[i] = array[i];
            }

            return copiedArray;
        }

        public static int[] GenerateRandomArray(int size)
        {
            if (size < 0)
            {
                throw new ArgumentException("Invalid size");
            }

            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {

                array[i] = random.Next(100);
            }
            return array;
        }
    }
}
