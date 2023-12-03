using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class MergeSort
    {
        public double TimeToSort { get; private set; }
        public MergeSort(int[] array)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Sort(array);
            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;
            TimeToSort = elapsedTime.TotalMilliseconds;
        }

        private static void Sort(int[] array)
        {
            if (array.Length <= 1)
                return;

            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = array[i];
            }

            for (int i = mid; i < array.Length; i++)
            {
                right[i - mid] = array[i];
            }

            Sort(left);
            Sort(right);
            Merge(array, left, right);
        }

        private static void Merge(int[] array, int[] left, int[] right)
        {
            int leftNum = 0, rightNum = 0, currentPos = 0;

            while (leftNum < left.Length && rightNum < right.Length)
            {
                if (left[leftNum] <= right[rightNum])
                {
                    array[currentPos] = left[leftNum];
                    leftNum++;
                }
                else
                {
                    array[currentPos] = right[rightNum];
                    rightNum++;
                }
                currentPos++;
            }

            while (leftNum < left.Length)
            {
                array[currentPos] = left[leftNum];
                leftNum++;
                currentPos++;
            }

            while (rightNum < right.Length)
            {
                array[currentPos] = right[rightNum];
                rightNum++;
                currentPos++;
            }
        }
    }

}
