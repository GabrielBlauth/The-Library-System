using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assigment_2_A_2024_74154.Models
{
    public class Library
    {
        private Dictionary<string, Book> books;

        public Library()
        {
            books = new Dictionary<string, Book>();
        }

        public void AddBook(string title)
        {
            books[title.ToLower()] = new Book(title);
        }

        public void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("There is any book available in the library.");
                return;
            }

            foreach (var book in books.Values)
            {
                Console.WriteLine($"{book.Title} - {(book.IsBorrowed ? "Borrowed" : "Available")}");
            }
        }

        public void BorrowBook(string title)
        {
            title = title.ToLower();
            if (books.ContainsKey(title))
            {
                Book book = books[title];
                if (book.IsBorrowed)
                {
                    Console.WriteLine($"The book: '{book.Title}' is already borrowed.");
                }
                else
                {
                    book.IsBorrowed = true;
                    Console.WriteLine($"You have borrowed '{book.Title}'.");
                }
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void ReturnBook(string title)
        {
            title = title.ToLower();
            if (books.ContainsKey(title))
            {
                Book book = books[title];
                if (!book.IsBorrowed)
                {
                    Console.WriteLine($"The book: '{book.Title}' was not borrowed.");
                }
                else
                {
                    book.IsBorrowed = false;
                    Console.WriteLine($"You have returned: '{book.Title}'.");
                }
            }
            else
            {
                Console.WriteLine("This Book is not found.");
            }
        }
    }
}
