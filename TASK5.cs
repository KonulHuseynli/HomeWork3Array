using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 16, 487, 32, 9875, 1243,9 };
            int floor = 0;
            {
                for (int i = 0; i < array.Length; i++)
                {
                    while (array[i] > 0)
                    {
                        {
                            array[i] = array[i] / 10;
                        }
                        floor++;
                    }
                    Console.WriteLine(floor);
                    floor = 0;
                }

            }
           

            
            }
        }
    }
