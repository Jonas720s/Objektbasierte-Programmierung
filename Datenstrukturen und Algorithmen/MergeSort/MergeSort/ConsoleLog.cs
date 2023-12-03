using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class ConsoleLog
    {
        public static void PrintUnsortedArray(int[] array, bool random)
        {
            StringBuilder output = new StringBuilder();

            if (random)
            {
                output.Append("Unsorted random array:\n");
            }
            else
            {
                output.Append("Unsorted array:\n");
            }
            for (int i = 0; i < array.Length; i++)
            {
                output.Append(array[i]);

                if (i < array.Length - 1)
                {
                    output.Append(", ");
                }
            }

            Console.WriteLine(output.ToString() + "\n");
        }

        public static void PrintSortedArray(int[] array, double timeToSort)
        {
            StringBuilder output = new StringBuilder();

            output.Append("Sorted array:\n");

            for (int i = 0; i < array.Length; i++)
            {
                output.Append(array[i]);

                if (i < array.Length - 1)
                {
                    output.Append(", ");
                }
            }
            output.AppendFormat("\n\nTime to sort the array {0} milliseconds", timeToSort);

            Console.WriteLine(output.ToString() + "\n");
        }
    }
}
