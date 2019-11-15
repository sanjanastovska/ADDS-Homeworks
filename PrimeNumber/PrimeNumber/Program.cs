using System;

namespace PrimeNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter a number to check if it is Prime: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("The number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("The number is Prime.");
        }
    }
}
