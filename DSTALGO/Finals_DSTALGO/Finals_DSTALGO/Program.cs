using System;
using System.Collections.Generic;
using System.Linq;

namespace FINALS_DSTALGO
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> Book_ID_Q = new Queue<string>();
            Queue<string> Book_Name_Q = new Queue<string>();
            Queue<string> Book_Author_Q = new Queue<string>();
            Queue<string> Book_Publisher_Q = new Queue<string>();
            Queue<string> Book_Genre_Q = new Queue<string>();
            Queue<string> Book_Year_Q = new Queue<string>();

            Stack<string> Book_id = new Stack<string>();
            Stack<string> Book_name = new Stack<string>();
            Stack<string> Book_author = new Stack<string>();
            Stack<string> Book_publisher = new Stack<string>();
            Stack<string> Book_genre = new Stack<string>();
            Stack<string> Book_year = new Stack<string>();

            Console.WriteLine("Welcome to the Library.");
            Console.WriteLine("\nChoose from the following operations below to execute the program: \n");

            Console.WriteLine("\t[1] - Add New Book");
            Console.WriteLine("\t[2] - Search A Book");
            Console.WriteLine("\t[3] - Delete A Book");
            Console.WriteLine("\t[4] - Book List");
            Console.WriteLine("\t[5] - Close Program");

            bool programOver = false;
            int userChoice = 0;

            while (programOver == false)
            {
                Console.Write("\nType the number of the operation that you want to execute: ");
                userChoice = Convert.ToInt32(Console.ReadLine());

                if (userChoice == 1)
                {
                    Console.Write("\nBook ID: ");
                    string id = Console.ReadLine();
                    Console.Write("\nBook Name: ");
                    string name = Console.ReadLine();
                    Console.Write("\nAuthor: ");
                    string author = Console.ReadLine();
                    Console.Write("\nPublisher: ");
                    string publisher = Console.ReadLine();
                    Console.Write("\nGenre: ");
                    string genre = Console.ReadLine();
                    Console.Write("\nYear: ");
                    string year = Console.ReadLine();

                    //Add to Stack

                    Book_id.Push(id);
                    Book_name.Push(name);
                    Book_author.Push(author);
                    Book_publisher.Push(publisher);
                    Book_genre.Push(genre);
                    Book_year.Push(year);

                    //Add to Queue
                    Book_ID_Q.Enqueue("11907436");
                    Book_Name_Q.Enqueue("Harry Potter");
                    Book_Author_Q.Enqueue("author");
                    Book_Publisher_Q.Enqueue("publisher");
                    Book_Genre_Q.Enqueue("Horror");
                    Book_Year_Q.Enqueue("2011");

                    Book_ID_Q.Enqueue("11928892");
                    Book_Name_Q.Enqueue("CSB");
                    Book_Author_Q.Enqueue("CSB");
                    Book_Publisher_Q.Enqueue("Google");
                    Book_Genre_Q.Enqueue("Comedy");
                    Book_Year_Q.Enqueue("2008");


                    Book_ID_Q.Enqueue(id);
                    Book_Name_Q.Enqueue(name);
                    Book_Author_Q.Enqueue(author);
                    Book_Publisher_Q.Enqueue(publisher);
                    Book_Genre_Q.Enqueue(genre);
                    Book_Year_Q.Enqueue(year);

                    Console.WriteLine("\nBook has been successfully added.");
                }
                else if (userChoice == 2)
                {
                    Console.Write("\nYou can search the book by: \n\n");

                    Console.WriteLine("\t[1] - Searching the Name");
                    Console.WriteLine("\t[2] - Searching the Author");

                    Console.Write("\nType the number of the operation that you want to execute: ");
                    int userSearch = Convert.ToInt32(Console.ReadLine());

                    if (userSearch == 1)
                    {
                        Console.Write("\nEnter Name of the Book: ");
                        string book_name = Console.ReadLine();

                        //Copy from the Temp Stack to a New Array to Search

                        string[] book_arr = new string[Book_name.Count];
                        Book_name.CopyTo(book_arr, 0);

                        int index = Array.IndexOf(book_arr, book_name);
                        Console.Write("\n{0} is found at Index {1}\n", book_name, index);
                    }
                    else if (userSearch == 2)
                    {
                        Console.Write("\nEnter the Author of the Book: ");
                        string book_auth = Console.ReadLine();

                        //Copy from the Temp Stack to a New Array to Search

                        string[] book_auth_arr = new string[Book_author.Count];
                        Book_author.CopyTo(book_auth_arr, 0);

                        int index = Array.IndexOf(book_auth_arr, book_auth);
                        Console.Write("\n{0} is found at Index {1}.\n", book_auth, index);
                    }
                    else
                    {
                        Console.WriteLine("\nWrong input! Type the correct number that corresponds to the operation.\n");
                    }
                }
                else if (userChoice == 3)
                {
                    var list_id = Book_ID_Q.ToList();
                    var list_name = Book_Name_Q.ToList();
                    var list_author = Book_Author_Q.ToList();
                    var list_publisher = Book_Publisher_Q.ToList();
                    var list_genre = Book_Genre_Q.ToList();
                    var list_year = Book_Year_Q.ToList();

                    Console.Write("\nList of all books in the library:\n");

                    for (int i = 0; i < Book_ID_Q.Count; i++)
                    {
                        Console.WriteLine("\nID: " + list_id[i] + "\t" + "Name: " + list_name[i] + "\t" + "Author: " + list_author[i] + "\t" + "Publisher: " + list_publisher[i] + "\t" + "Genre: " + list_genre[i] + "\t" + "Year: " + list_year[i]);
                    }

                    Console.Write("\nEnter the ID of the book that you want to delete: ");
                    Console.Write("\nEnter the name of the book that you want to delete: ");
                    Console.Write("\nEnter the Author of the book that you want to delete: ");
                    Console.Write("\nEnter the Publisher of the book that you want to delete: ");
                    Console.Write("\nEnter the Genre of the book that you want to delete: ");
                    Console.Write("\nEnter the Year of the book that you want to delete: ");
                    string id = Console.ReadLine();
                    string book = Console.ReadLine();
                    string author = Console.ReadLine();
                    string publisher = Console.ReadLine();
                    string genre = Console.ReadLine();
                    string year = Console.ReadLine();
                    Book_ID_Q = new Queue<string>(Book_ID_Q.Where(x => x != id));
                    Book_Name_Q = new Queue<string>(Book_Name_Q.Where(x => x != book));
                    Book_Author_Q = new Queue<string>(Book_Author_Q.Where(x => x != author));
                    Book_Publisher_Q = new Queue<string>(Book_Publisher_Q.Where(x => x != publisher));
                    Book_Genre_Q = new Queue<string>(Book_Genre_Q.Where(x => x != genre));
                    Book_Year_Q = new Queue<string>(Book_Year_Q.Where(x => x != year));

                    //Pwede for edit to

                    //var list_book = Book_Name_Q.ToList();
                    //string element = "";
                    //Console.Write("Book to Update: ");
                    //String input1 = Console.ReadLine();
                    //if (list_book.Contains(input1))
                    //{
                    //Console.Write("Enter Book Title:");
                    //Console.ResetColor();
                    //string new_name = Console.ReadLine();
                    //for (int i = 0; i < list_book.Count; i++)
                    //{
                    //if (list_book[i].Contains(input1))
                    //{
                    //element = list_book[i];
                    //list_book.Remove(element);
                    //list_book.Add(new_name);
                    //Console.Write("Record Has Been Updated...." + "\n");
                    //}
                    //}
                    //}

                    Console.WriteLine("{0} has been deleted.", book);
                }
                else if (userChoice == 4)
                {
                    var list_id = Book_ID_Q.ToList();
                    var list_name = Book_Name_Q.ToList();
                    var list_author = Book_Author_Q.ToList();
                    var list_publisher = Book_Publisher_Q.ToList();
                    var list_genre = Book_Genre_Q.ToList();
                    var list_year = Book_Year_Q.ToList();

                    Console.Write("\nList of all books in the library:\n");

                    for (int i = 0; i < Book_ID_Q.Count; i++)
                    {
                        Console.WriteLine("\nID: " + list_id[i] + "\t" + "Name: " + list_name[i] + "\t" + "Author: " + list_author[i] + "\t" + "Publisher: " + list_publisher[i] + "\t" + "Genre: " + list_genre[i] + "\t" + "Year: " + list_year[i]);
                    }
                }
                else if (userChoice == 5)
                {
                    Console.WriteLine("\nThank you for using the Library.");
                    break;
                }
                else
                {
                    Console.WriteLine("\nWrong input! Type the correct number that corresponds to the operation.\n");

                    Console.WriteLine("\t[1] - Add New Book");
                    Console.WriteLine("\t[2] - Search A Book");
                    Console.WriteLine("\t[3] - Delete A Book");
                    Console.WriteLine("\t[4] - Book List");
                    Console.WriteLine("\t[5] - Close Program");
                }
            }

            Console.ReadLine();
        }
    }
}