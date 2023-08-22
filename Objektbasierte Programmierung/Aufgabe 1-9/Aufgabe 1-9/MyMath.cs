using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1_9
{
    internal class MyMath
    {
        public static int Calc_ggT(int a, int b)
        {
            int z = 0;
            while (b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }
            return a;
        }

        public static int Calc_kgV(int a, int b)
        {
            return a * b / Calc_ggT(a, b);
        }
        public static void Swap(ref int a, ref int b)
        {
            int z = b;
            b = a;
            a = z;

        }
        public static int Calc_ggT_r(int a, int b)
        {
            int y = 0;
            if (b == 0)
            {
                return a;
            }
            else
            {
                return y = a % b;
                b = y;
            }
        }
        public static double ArithmeticMean(double[] values)
        {
            double sum = 0;
            foreach (int v in values) {
            sum += v;}
            return sum / values.Length;
        }
        public static double SmallestValue(double[] values)
        {
            double numSmallest = values[0];

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < numSmallest)
                {
                    numSmallest = values[i];
                }
            }
            return numSmallest;
        }

        public static double BiggestValue(double[] values)
        {
            double numBiggest = values[0];

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > numBiggest)
                {
                    numBiggest = values[i];
                }
            }
            return numBiggest;
        }
    }
}