using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] task4 = { 12, 14, 23, 47, 86, 8 };
            int[] task4new = new int[task4.Length];
            int j = 0;
            {
                for (int i = task4.Length-1; i >= 0; i--)
                {
                    task4new[j] = task4[i];
                    Console.WriteLine(task4new[j]);
                    j++;
                }
            }
        }
    }
}