using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class InputArray
    {
        private int[] array;
        public bool random;
        public int[] Array
        {
            get
            {
                GetUserChoice();
                return array;
            }
        }

        private void GetUserChoice()
        {
            Console.Write($"For random array \"r\", for manual input \"m\": ");
            string choice = Console.ReadLine();
            Console.Write("\n");
            if (choice.ToLower() == "r")
            {
                array = GetRandomArray();
                random = true;
            }
            else if (choice.ToLower() == "m")
            {
                array = GetManualArray();
                random = false;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                GetUserChoice();
            }
        }

        private static int[] GetRandomArray()
        {
            bool validlength = false;
            int length = 0;
            do
            {
                try
                {
                    Console.Write("Enter the length of the array you want to sort: ");
                    length = int.Parse(Console.ReadLine());
                    if (length > 0)
                    {
                        validlength = true;
                    }
                    else
                    {
                        Console.WriteLine("Length must be greater than 0!");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("invalid input!");
                }
            } while (!validlength);
            int[] array = new int[length];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(0, 1000000);
            return array;
        }

        private int[] GetManualArray()
        {
            bool validlength = false;
            int length = 0;
            do
            {
                try
                {
                    Console.Write("Enter the length of the array you want to sort: ");
                    length = int.Parse(Console.ReadLine());
                    if (length > 0)
                    {
                        validlength = true;
                    }
                    else
                    {
                        Console.WriteLine("Length must be greater than 0!");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("invalid input!");
                }
            } while (!validlength);
            int[] array = new int[length];
            Console.WriteLine($"Enter {length} numbers:");
            for (int i = 0; i < array.Length; i++)
            {
                bool valid = false;
                do
                {
                    Console.Write($"{i + 1}: ");
                    try
                    {
                        array[i] = int.Parse(Console.ReadLine());
                        valid = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("invalid input!");
                    }
                } while (!valid);
            }
            return array;
        }
    }
}
