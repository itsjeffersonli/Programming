using System;

namespace Lab_Act_6
{
    class Program
    {

        static void Main(string[] args)
        {
            // Quiz
            Console.Write("Enter Quizzes Score:" + "\n");
            int[][] grade1 = new int[1][];
            grade1[0] = new int[3];
            int sum1 = 0;
            for (int quiz = 0; quiz < grade1.Length; quiz++)
            {
                for (int j = 0; j < grade1[quiz].Length; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Enter Quiz{0}: ", j);
                    Console.ResetColor();
                    grade1[quiz][j] = int.Parse(Console.ReadLine());
                    sum1 = sum1 + grade1[quiz][j];
                }
                Console.WriteLine();
            }

            //Assignment
            Console.Write("Enter Assignments Score:" + "\n");
            int[][] grade2 = new int[1][];
            grade2[0] = new int[2];
            int sum2 = 0;
            for (int assignment = 0; assignment < grade2.Length; assignment++)
            {
                for (int j = 0; j < grade2[assignment].Length; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Enter Assignment{0}: ", j);
                    Console.ResetColor();
                    grade2[assignment][j] = int.Parse(Console.ReadLine());
                    sum2 = sum2 + grade2[assignment][j];
                }
                Console.WriteLine();
            }

            //Exams
            Console.Write("Enter Exams Score:" + "\n");
            int[][] grade3 = new int[1][];
            grade3[0] = new int[2];
            int sum3 = 0;
            for (int exams = 0; exams < grade3.Length; exams++)
            {
                for (int j = 0; j < grade3[exams].Length; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Enter Exams{0}: ", j);
                    Console.ResetColor();
                    grade3[exams][j] = int.Parse(Console.ReadLine());
                    sum3 = sum3 + grade3[exams][j];
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t" + "\t" + " "+ "*** Class Standing Summary ***"+ "\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\t" + "\t" + " " + "Scores" + "\t"+ "\t" + "\t" +"Average" +"\n");
            Console.ResetColor();

            // Print Quizz
            for (int quiz=0; quiz < grade1.Length; quiz++)
            {
                Console.Write("Quiz: "+ " " + "\t" + "\t");
                for (int j = 0; j < grade1[quiz].Length; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(grade1[quiz][j] + " " + "\t");
                    Console.ResetColor();
                }
                double ave1 = sum1 / 3;
                Console.Write(ave1);
            }
            Console.WriteLine();

            // Print Assignment
            for (int assignment = 0; assignment < grade2.Length; assignment++)
            {
                Console.Write("Assignment: " + " " + "\t");
                for (int j = 0; j < grade2[assignment].Length; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(grade2[assignment][j] + " " + "\t");
                    Console.ResetColor();
                }
                double ave2 = sum2 / 2;
                Console.Write("\t"+ave2);
            }
            Console.WriteLine();

            // Print Exams
            for (int exams = 0; exams < grade3.Length; exams++)
            {
                Console.Write("Exams: " + " " + "\t");
                for (int j = 0; j < grade3[exams].Length; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(grade3[exams][j] + " " + "\t");
                    Console.ResetColor();
                }
                double ave3 = sum3 / 2;
                Console.Write("\t"+ave3);
            }
            Console.WriteLine();
        }
    }
}
