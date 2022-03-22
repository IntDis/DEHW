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

        public static int GetSumOfEvenNumbers(int[] array)
        {
            int sumOfEvenNumbers = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                sumOfEvenNumbers += array[i];
            }
            return sumOfEvenNumbers;
        }
    }
}
