using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AIO
{
    public class ArrayMethods
    {
        public static void PrintArrayElements(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
