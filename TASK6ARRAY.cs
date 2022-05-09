using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] task6 = { 12, 34, 7, 98, 42, 3 };
            int max = task6[0];
            {
                for(int i=0;i<task6.Length;i++)
                {
                    if(task6[i]>max)
                    {
                        max = task6[i];
                    }

                }
                Console.WriteLine(max);
            }
        }
    }
}
