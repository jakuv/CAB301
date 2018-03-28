using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cab301AssignmentOne
{
    class Program
    {
        public static int[] MaxMin2(int[] A)
        {
            int MaxValue = A[0];
            int MinValue = A[0];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > MaxValue)
                {
                    MaxValue = A[i];
                } else if (A[i] < MinValue)
                {
                    MinValue = A[i];
                }
            }

            return new int[] { MaxValue, MinValue };
        }


        static void Main(string[] args)
        {
            // single int
            int[] testmock = { 42 };
                        // test for numbers incrementing from 1 to 9
            int[] test1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // test for numbers decrementing from 9 to 1
            int[] test2 = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            // test for numbers all the same
            int[] test3 = { 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            // test for numbers with double digits
            int[] test4 = { 16, 19, 20, 11, 43, 27, 16, 33, 24 };
            // test for random numbers
            int[] test0 = { 5, 2, 6, 3, 8, 7, 3, 6, 4 };
            // test for random array of large numbers
            int[] test5 = TestCases.createRandomArray(100, 999, 9);
            // test for large random array
            int[] test6 = TestCases.createRandomArray(1, 500, 100);
            // test for even larger array
            int[] test7 = { };
            Console.WriteLine("CAB301: ALGORITHM EXECUTION ANALYSIS\n*****");
            Console.WriteLine(TestCases.testAlgorithm(testmock));
            Console.WriteLine(TestCases.testAlgorithm(test0));
            Console.WriteLine(TestCases.testAlgorithm(test1));
            Console.WriteLine(TestCases.testAlgorithm(test2));
            Console.WriteLine(TestCases.testAlgorithm(test3));
            Console.WriteLine(TestCases.testAlgorithm(test4));
            Console.WriteLine(TestCases.testAlgorithm(test5));
            Console.WriteLine(TestCases.testAlgorithm(test6));
            Console.ReadKey();
        }
    }
}
