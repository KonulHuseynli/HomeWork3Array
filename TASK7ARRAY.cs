using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] task7 = { 12, 23, 34, 87, 56, 67, 6, 3, 45 };
            int min = task7[0];
            {
                for (int i = 0; i <task7.Length; i++)
                {
                    if(task7[i]<min)
                    {
                        min = task7[i];
                       
                    }
                }
                Console.WriteLine(min);
            }

        }
    }
}
