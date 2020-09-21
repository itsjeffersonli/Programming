using System;

namespace ConsoleApp1
{
    class Program
    {
        static int binarySearch(String[] array, String Student)
        {
            int l = 0, r = array.Length - 2;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                int res = Student.CompareTo(array[m]);

                if (res == 0)
                    return m;

                if (res > 0)
                    l = m + 1;

                else
                    r = m - 1;
            }

            return -1;
        }


        public static void Main(String[] args)
        {
            String[] array = { "Jewel", "Sam", "Cha", "Cloud", "Shine" };
            Console.Write("Enter student name to be searched:");
            String Student = Console.ReadLine();
            int result = binarySearch(array, Student);

            if (result == -1)
            {
                Console.WriteLine("The name {0} Does Not Exist", Student);
            }
            else
            {
                Console.WriteLine("{0} is found at " + "index " + result, Student);
            }
            Console.WriteLine("List Of Existing Students: ");
            foreach (var data in array)
            {
                Console.WriteLine(data);
            }
            Console.ReadKey();
        }
    }
}
