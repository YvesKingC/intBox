
using System;

namespace intBox
{
    class Program
    {
        static int CekPrime(int input)
        {
            int i;
            for (i = 2; i <= input - 1; i++)
            {
                if (input % i == 0)
                {
                    return 0;
                }
            }
            if (i == input)
            {
                return 1;
            }
            return 0;
        }
        static bool cekPrime2(int input)
        {
            if (input == 1|| input == 0)return false;
            for (int x = 2; x * x < input; x++)
            {
                if (input % x == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int input, i, j, x;
            Console.Write("Input: ");
            input = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nOutput: \n");
            int result = CekPrime(input);
            if (result == 0)
            {
                Console.WriteLine("{0} is  a not a prime number", input);
            }
            else
            {
                for (i = 0; i <= input; i++)
                {
                    for (j = 0; j <= input; j++)
                    {
                        for (x = 1; x <= input; x++)
                        {
                            if (cekPrime2(x))
                            {
                                Console.Write(x + "\t");
                            }
                        }
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
