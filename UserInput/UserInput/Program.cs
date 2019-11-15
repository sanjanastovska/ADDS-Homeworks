using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int num = Convert.ToInt32(Console.ReadLine());
            while(num<11)
            {
                Console.WriteLine("Enter another integer");
                num = Convert.ToInt32(Console.ReadLine());
            }

                Console.WriteLine("Integer greater than 10 detected!");
    
            
     
        }
    }
}
