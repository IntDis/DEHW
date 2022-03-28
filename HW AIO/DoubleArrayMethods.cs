using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AIO
{
    public class DoubleArrayMethods
    {
        public static int GetMaxElement(int[,] doubleArray)
        {
            if (doubleArray.Length == 0)
            {
                throw new Exception("Array length is 0");
            }

            int maxElement = doubleArray[0, 0];


            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArray.GetLength(1); j++)
                {
                    if (doubleArray[i, j] > maxElement)
                    {
                        maxElement = doubleArray[i, j];
                    }
                }
            }
            return maxElement;
        }                                    //5.1

        public static int GetMinElement(int[,] doubleArray)
        {
            if (doubleArray.Length == 0)
            {
                throw new Exception("Array length is 0");
            }

            int minElement = doubleArray[0, 0];


            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArray.GetLength(1); j++)
                {
                    if (doubleArray[i, j] < minElement)
                    {
                        minElement = doubleArray[i, j];
                    }
                }
            }
            return minElement;
        }                                    //5.2

        public static int[] GetMinElementIndex(int[,] doubleArray)
        {
            if (doubleArray.Length == 0)
            {
                throw new Exception("Array length is 0");
            }

            int[] indexArray = new int[2];
            int minElement = doubleArray[0, 0];

            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArray.GetLength(1); j++)
                {
                    if (doubleArray[i, j] < minElement)
                    {
                        minElement = doubleArray[i, j];
                        indexArray[0] = i;
                        indexArray[1] = j;
                    }
                }
            }

            return indexArray;
        }                             //5.3
            
        public static int[] GetMaxElementIndex(int[,] doubleArray)
        {
            if (doubleArray.Length == 0)
            {
                throw new Exception("Array length is 0");
            }

            int[] indexArray = new int[2];
            int maxElement = doubleArray[0, 0];

            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArray.GetLength(1); j++)
                {
                    if (doubleArray[i, j] > maxElement)
                    {
                        maxElement = doubleArray[i, j];
                        indexArray[0] = i;
                        indexArray[1] = j;
                    }
                }
            }

            return indexArray;
        }                             //5.4

        public static int GetAmountOfElementsWhichHigherThanNeighbours(int[,] doubleArray)
        {
            if (doubleArray.Length == 0)
            {
                throw new Exception("Array length is 0");
            }

            int count = 0;

            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArray.GetLength(1); j++)
                {
                    if ((i == 0 || doubleArray[i,j] > doubleArray[i-1,j]) 
                     && (i == doubleArray.GetLength(0)-1 || doubleArray[i, j] > doubleArray[i + 1, j])
                     && (j == 0 || doubleArray[i, j] > doubleArray[i, j-1]) 
                     && (j == doubleArray.GetLength(1) - 1 || doubleArray[i, j] > doubleArray[i, j+1]))
                    {
                        count++;
                    }
                }
            }

            return count;
        }     //5.5     //undone

        public static int[,] GetMatrixMirroredByGeneralDiagonal(int[,] doubleArray)
        {
            if (doubleArray.Length == 0)
            {
                throw new Exception("Array length is 0");
            }
            else if (doubleArray.GetLength(0) != doubleArray.GetLength(0))
            {
                throw new ArgumentException("Input array must be matrix");
            }

            int[,] copiedDoubleArray = CopyDoubleArray(doubleArray);

            for (int i = 0; i < copiedDoubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < copiedDoubleArray.GetLength(1); j++)
                {
                    int tmp = copiedDoubleArray[i, j];
                    copiedDoubleArray[i, j] = doubleArray[j, i];
                    copiedDoubleArray[j, i] = doubleArray[i, j];
                }
            }

            return copiedDoubleArray;
        }            //5.6

        public static int[,] CopyDoubleArray(int[,] doubleArray)
        {
            if (doubleArray.Length == 0)
            {
                throw new Exception("Array length is 0");
            }

            int[,] copiedDoubleArray = new int[doubleArray.GetLength(0), doubleArray.GetLength(1)];

            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArray.GetLength(1); j++)
                {
                    copiedDoubleArray[i, j] = doubleArray[i, j];
                }
            }

            return copiedDoubleArray;
        }

        public static int[,] GenerateRandomArray(int lines, int columns)
        {
            if (columns < 0 || lines < 0)
            {
                throw new ArgumentException("Invalid double array size");
            }

            Random random = new Random();
            int[,] doubleArray = new int[lines, columns];
            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArray.GetLength(1); j++)
                {
                    doubleArray[i, j] = random.Next(0, 10);
                }
                
            }
            return doubleArray;
        }

        public static void PrintDoubleArray(int[,] doubleArray)
        {
            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArray.GetLength(1); j++)
                {
                    if (doubleArray[i, j] < 10)
                    {
                        Console.Write($" {doubleArray[i, j]} ");
                    }
                    else
                        Console.Write($"{doubleArray[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
