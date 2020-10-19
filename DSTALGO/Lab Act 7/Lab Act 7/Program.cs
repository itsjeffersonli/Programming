using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;

namespace Lab_Act_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose from the following operations:");
            Console.WriteLine("\t" + "[1] – Add a Student");
            Console.WriteLine("\t" + "[2] – Remove a Student");
            Console.WriteLine("\t" + "[3] – Update a Student");
            Console.WriteLine("\t" + "[4] – View List of Students");
            Console.WriteLine("\t" + "[5] – Exit");
            List<string> input = new List<string>();
            for ( ; ; )
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter Your Choice: ");
                Console.ResetColor();
                int option = (Convert.ToInt32(Console.ReadLine()));
                if (option == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Enter Student Name: ");
                    Console.ResetColor();
                    String input1 = Console.ReadLine();
                    input.Add(input1);
                }
                else if (option == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Student to Remove: ");
                    Console.ResetColor();
                    String input1 = Console.ReadLine();
                    input.Remove(input1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Record Has Been Deleted...." + "\n");
                    Console.ResetColor();
                }
                else if (option == 3)
                {
                    string element = "";
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Student to Update: ");
                    Console.ResetColor();
                    String input1 = Console.ReadLine();
                    if (input.Contains(input1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Enter New Name:");
                        Console.ResetColor();
                        string new_name = Console.ReadLine();
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i].Contains(input1))
                            {
                                element = input[i];
                                input.Remove(element);
                                input.Add(new_name);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("Record Has Been Updated...." + "\n");
                                Console.ResetColor();
                            }
                        }
                    }
                    else
                    {
                        Console.Write("The Data You want to edit is not on the array");
                    }

                }
                else if (option == 4)
                {
                    Console.WriteLine("List of Students:" + "\n");
                    foreach (var value in input)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(value + "\t");
                        Console.ResetColor();
                    }
                    Console.ReadLine();
                }
                else if (option == 5)
                {
                    System.Environment.Exit(0);
                }
            }
        }
    }
}
