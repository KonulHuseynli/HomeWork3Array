using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {

			string input = Console.ReadLine();
			int n = Int32.Parse(input);
			int[] task1 = { 876, 856, 342, 67, 654, 421, 965, 76, 739, 934 };
			bool result = false;
			for (int i = 0; i < task1.Length; i++)
			{
				if (task1[i] > n)
				{
					result = true;
				}
			}
			Console.WriteLine(result);
		}
    }
}
