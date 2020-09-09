using System;

namespace Lab_Act_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int end = 10;
            int guess;
            Random rand_num = new Random();
            int winning_number = rand_num.Next(start, end);

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Enter Guess {0}: ", i);
                guess = Convert.ToInt32(Console.ReadLine());
                if (i >= 3)
                {
                    Console.WriteLine("Sorry, you have reached a maximum of three attempts! ");
                    Console.Write("The Secret Number is {0}", winning_number);
                    break;
                }
                else
                {
                    if (guess == winning_number)
                    {
                        Console.Write("Good Job! You have successfully guess the secret number in {0} attempts.", i);
                        break;
                    }
                    else if (guess < winning_number)
                    {
                        Console.WriteLine("Your guess is LOW, try guessing for a HIGHER number");
                    }
                    else if (guess > winning_number)
                    {
                        Console.WriteLine("Your guess is HIGH, try guessing for a LOWER number");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}