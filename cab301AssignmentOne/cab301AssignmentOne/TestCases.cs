using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cab301AssignmentOne
{
    class TestCases
    {
        /// <summary>
        /// Creates an array with random int values.
        /// </summary>
        /// <param name="min">The minimum value of the numbers in the array.</param>
        /// <param name="max">The maximum value of the numbers in the array.</param>
        /// <param name="l">The length of the array.</param>
        /// <returns>The array of random ints.</returns>
        public static int[] createRandomArray(int min, int max, int l)
        {
            int[] randArray = new int[l];
            Random randInt = new Random();
            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = randInt.Next(min, max);
            }
            return randArray;
        }

        /// <summary>
        /// Tests the algorithm and prints in the console the findings, as
        /// well as the elapsed time (in Stopwatch ticks) all as one string.
        /// </summary>
        /// <param name="a">The array to be tested</param>
        /// <returns>The results of the test, as a string</returns>
        public static string testAlgorithm(int[] a)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] result = Program.MaxMin2(a);
            sw.Stop();
            return "MaxValue: " + result[0] +
                   "\tMinValue: " + result[1] +
                   "\tTimer: " + sw.ElapsedTicks;
        }
    }
}
