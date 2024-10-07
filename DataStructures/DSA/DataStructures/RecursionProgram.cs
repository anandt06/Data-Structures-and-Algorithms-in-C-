using System;

namespace DSA.DataStructures
{
    // Every recursion function need to have a base condition to break out of the recursive call else it will lead to stack overflow
    internal class RecursionProgram
    {
        static int x = 0;

        static void Main(string[] args)
        {

            TreeRecursion(3);

            Console.WriteLine(GetFactorialOfNumber(5));

            Console.WriteLine(GetPowerOfNumber(4, 4));

            PrintNameNTime(5);

            PrintNumberFromNto1(5);

            Console.WriteLine();

            PrintNumberFrom1toN(1, 5);

            Console.WriteLine();

            TailRecursivePower(5, 3);


        }

        public static int GetFactorialOfNumber(int number)
        {
            if (number == 1)
            {
                return 1;

            }

            var num = number * GetFactorialOfNumber(number - 1);
            return num;
        }

        static void TreeRecursion(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(n);
                TreeRecursion(n - 1);
                TreeRecursion(n - 1);
            }
        }

        static int FibannociUsingRecursion(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * FibannociUsingRecursion(num - 1);
            }
        }

        public static int GetPowerOfNumber(int number, int power)
        {
            if (number == 0)
            {
                return 1;

            }

            var num = number * GetPowerOfNumber(number, number - 1);
            return num;
        }

        public static void PrintNameNTime(int n)
        {
            if (n == 0)
            {
                return;
            }
            Console.WriteLine("Anand");
            PrintNameNTime(n - 1);

        }

        public static void PrintNumberFromNto1(int n)
        {
            if (n == 0)
            {
                return;
            }
            Console.WriteLine(n);
            PrintNumberFromNto1(n - 1);

        }

        public static void PrintNumberFrom1toN(int i, int n)
        {
            if (i > n)
            {
                return;
            }
            Console.WriteLine(i);
            PrintNumberFrom1toN(i + 1, n);

        }

        public static int TailRecursivePower(int baseNumber, int exponent, int accumulator = 1)
        {
            if (exponent == 0) // Base case
                return accumulator;

            return TailRecursivePower(baseNumber, exponent - 1, accumulator * baseNumber);
        }
    }
}
