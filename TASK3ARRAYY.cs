using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 6, 7, 8, 9 };
            int Avg = 0;
            int count = 0;
            int sum = 0;
            for (int i = 2; i < array.Length; i += 2)
            {
                sum += array[i];
                count++;

            }
            Console.WriteLine(Avg = (sum / count));
        }
    }
}
