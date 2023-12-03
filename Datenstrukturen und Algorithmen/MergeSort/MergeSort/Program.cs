using System.Text;

namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MergeSort Started\n*****************\n");
            InputArray inputArray = new InputArray();

            do
            {
                int[] array = inputArray.Array;
                ConsoleLog.PrintUnsortedArray(array, inputArray.random);
                MergeSort mergeSort = new MergeSort(array);
                ConsoleLog.PrintSortedArray(array, mergeSort.TimeToSort);
            } while (true);
        }


    }
}
