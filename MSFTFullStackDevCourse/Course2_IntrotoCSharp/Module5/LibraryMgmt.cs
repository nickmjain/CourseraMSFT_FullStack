using System;
using System.Collections.Generic;

namespace Course2_IntrotoCSharp.Module5
{
    class LibraryMgmt
    {
        static Dictionary<string, bool> bookTitles = new Dictionary<string, bool>(5);

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Library Management System");
                Console.WriteLine("1. Add a book title");
                Console.WriteLine("2. Remove a book title");
                Console.WriteLine("3. Display list of books");
                Console.WriteLine("4. Search for a book title");
                Console.WriteLine("5. Borrow a book");
                Console.WriteLine("6. Return a book");
                Console.WriteLine("7. Exit");
                Console.Write("Select an option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddBook();
                        break;
                    case "2":
                        RemoveBook();
                        break;
                    case "3":
                        DisplayBooks();
                        break;
                    case "4":
                        SearchBook();
                        break;
                    case "5":
                        BorrowBook();
                        break;
                    case "6":
                        ReturnBook();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }

        static void AddBook()
        {
            if (bookTitles.Count >= 5)
            {
                Console.WriteLine("Library is full. Cannot add more books.");
                return;
            }

            Console.Write("Enter the book title to add: ");
            string title = Console.ReadLine();
            if (!bookTitles.ContainsKey(title))
            {
                bookTitles.Add(title, true); // true indicates the book is available
                Console.WriteLine($"Book '{title}' added to the library.");
            }
            else
            {
                Console.WriteLine($"Book '{title}' already exists in the library.");
            }
        }

        static void RemoveBook()
        {
            Console.Write("Enter the book title to remove: ");
            string title = Console.ReadLine();

            if (bookTitles.Remove(title))
            {
                Console.WriteLine($"Book '{title}' removed from the library.");
            }
            else
            {
                Console.WriteLine($"Book '{title}' not found in the library.");
            }
        }

        static void DisplayBooks()
        {
            if (bookTitles.Count == 0)
            {
                Console.WriteLine("No books in the library.");
                return;
            }

            Console.WriteLine("Books in the library:");
            foreach (var book in bookTitles)
            {
                string status = book.Value ? "Available" : "Checked out";
                Console.WriteLine($"{book.Key} - {status}");
            }
        }

        static void SearchBook()
        {
            Console.Write("Enter the book title to search: ");
            string title = Console.ReadLine();

            if (bookTitles.ContainsKey(title))
            {
                string status = bookTitles[title] ? "Available" : "Checked out";
                Console.WriteLine($"Book '{title}' is {status} in the library.");
            }
            else
            {
                Console.WriteLine($"Book '{title}' is not available in the library.");
            }
        }

        static void BorrowBook()
        {
            Console.Write("Enter the book title to borrow: ");
            string title = Console.ReadLine();

            if (bookTitles.ContainsKey(title))
            {
                if (bookTitles[title])
                {
                    bookTitles[title] = false; // Mark the book as checked out
                    Console.WriteLine($"You have borrowed '{title}'.");
                }
                else
                {
                    Console.WriteLine($"Book '{title}' is already checked out.");
                }
            }
            else
            {
                Console.WriteLine($"Book '{title}' is not available in the library.");
            }
        }

        static void ReturnBook()
        {
            Console.Write("Enter the book title to return: ");
            string title = Console.ReadLine();

            if (bookTitles.ContainsKey(title))
            {
                if (!bookTitles[title])
                {
                    bookTitles[title] = true; // Mark the book as available
                    Console.WriteLine($"You have returned '{title}'.");
                }
                else
                {
                    Console.WriteLine($"Book '{title}' was not checked out.");
                }
            }
            else
            {
                Console.WriteLine($"Book '{title}' is not available in the library.");
            }
        }
    }
}

