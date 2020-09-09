using System;

namespace Lab_Act_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int high = 0;
            int low = 0;
            float ave = 0;

            Console.Write("How many numbers you want? : ");
            int x = Int32.Parse(Console.ReadLine());
            int[] array = new int[x + 1];

            for (i = 1; i <= x; i++)
            {
                Console.Write("Enter Numbers " + i + ": ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    high = array[i];
                }
                else
                {
                    if (array[i] > high)
                    {
                        high = array[i];
                    }
                }
                if (i == 1)
                {
                    low = array[i];
                }
                else
                {
                    if (array[i] < low)
                    {
                        low = array[i];
                    }
                }
                ave += array[i];
            }
            Console.Write("You Typed : ");
            for (i = 1; i <= x; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n" + "Smallest: {0:N}", low);
            Console.Write("Largest: {0:N}", high + "\n");
            Console.Write("Average : " + ave / x);
            Console.ReadKey();
        }
    }
}
