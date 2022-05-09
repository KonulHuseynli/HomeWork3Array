using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = Int32.Parse(input);
            int Mertebe = 0;
            int remain = 0;
            {
                while (num > 0)
                {
                    remain = num % 10;
                    num = num / 10;
                    {
                        if (remain % 2 == 0)
                            Console.WriteLine(remain);
                    }
                    Mertebe++;
                }
            }
        }
    }
}
