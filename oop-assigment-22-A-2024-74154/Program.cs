using System;
using System.Collections.Generic;
using oop_assigment_2_A_2024_74154.Models;

namespace oop_assigment_2_A_2024_74154
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adicionando livros à biblioteca
            library.AddBook("Book 1");
            library.AddBook("Book 2");
            library.AddBook("Book 3");
            library.AddBook("Book 4");

            // Loop de interação com o usuário
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nWelcome to The Library System:");
                Console.WriteLine("1. Display all books");
                Console.WriteLine("2. Borrow a book");
                Console.WriteLine("3. Return a book");
                Console.WriteLine("4. Exit");
                Console.Write("Inset your option: ");

                string choice = Console.ReadLine().Trim();

                switch (choice.ToLower())
                {
                    case "1":
                        library.DisplayBooks();
                        break;

                    case "2":
                        Console.Write("Enter the book that you want to borrow: ");
                        string borrowTitle = Console.ReadLine().Trim();
                        library.BorrowBook(borrowTitle);
                        break;

                    case "3":
                        Console.Write("Enter the book that you want to return: ");
                        string returnTitle = Console.ReadLine().Trim();
                        library.ReturnBook(returnTitle);
                        break;

                    case "4":
                        exit = true;
                        Console.WriteLine("Exiting System ...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }
        }
    }
}
