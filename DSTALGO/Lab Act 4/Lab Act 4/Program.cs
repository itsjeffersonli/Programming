using System;

namespace Lab_Act_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int smallest;
            int total = 0;
            int[] array = new int[5] { 1, 2, 3, 4, 5};
            Console.ReadKey();
            Console.WriteLine("Array Content:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+ " ");
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = array[smallest];
                array[smallest] = array[i];
                array[i] = temp;

                Console.WriteLine("\n");
                Console.WriteLine("Sorted array is: ");
                foreach (int item in array)
                {
                    Console.Write("\t"+item);
                }
                total = total + 1;
                Console.WriteLine( "\n" + "Iterations:  " + total);
                Console.ReadKey();
            }
        }
    }
}
