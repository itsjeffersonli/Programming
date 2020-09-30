using System;
using System.Collections.Generic;

namespace Lab_Act_5
{
    class Program
    {

        static void Main(string[] args)
        {
            for (int numbers_ask = 0; numbers_ask < 5; numbers_ask++)
            {
                int[] numbers = new int[5];

                for(int i = 0; i < numbers.Length; i++)
                {
                    Console.Write("Enter Number: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < numbers.Length; i++)
                {
                    int temp;
                    int smallest;
                    smallest = i;
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[j] < numbers[smallest])
                        {
                            smallest = j;
                        }
                    }
                    temp = numbers[smallest];
                    numbers[smallest] = numbers[i];
                    numbers[i] = temp;
                }
                Console.WriteLine("\n");
                Console.WriteLine("Sorted Array: ");
                foreach (int item in numbers)
                {
                    Console.Write("\t" + item);
                }
            }
            Console.ReadKey();
        }
    }
}
