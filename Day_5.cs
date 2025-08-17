using System;
using System.Collections.Generic;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bookTitles = new List<string>();
            Dictionary<string, int> books = new Dictionary<string, int>();
            HashSet<string> borrowedMembers = new HashSet<string>();
            int choice;
            while (true)
            {
                Console.WriteLine("1. Add Book\n2. Remove Book\n3. Borrow Book\n4. Return Book\n5. View All Books\n6. View Borrowed Members\n7. Exit");
                Console.Write("Enter your choice : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter book title: ");
                        string title = Console.ReadLine();
                        if (books.ContainsKey(title))
                        {
                            books[title]++;
                        }
                        else
                        {
                            books.Add(title, 1);
                            bookTitles.Add(title);
                        }
                        break;
                    case 2:
                        Console.Write("Enter book title to remove: ");
                        string removeTitle = Console.ReadLine();
                        if (books.ContainsKey(removeTitle))
                        {
                            books[removeTitle]--;
                            if (books[removeTitle] <= 0)
                            {
                                books.Remove(removeTitle);
                                bookTitles.Remove(removeTitle);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;
                    case 3:
                        Console.Write("Enter book title to borrow: ");
                        string borrowTitle = Console.ReadLine();
                        Console.Write("Enter member name: ");
                        string memberName = Console.ReadLine();
                        if (books.ContainsKey(borrowTitle) && books[borrowTitle] > 0)
                        {
                            books[borrowTitle]--;
                            borrowedMembers.Add(memberName);
                            Console.WriteLine($"{memberName} borrowed {borrowTitle}.");
                        }
                        else
                        {
                            Console.WriteLine("Book not available for borrowing.");
                        }
                        break;
                    case 4:
                        Console.Write("Enter book title to return: ");
                        string returnTitle = Console.ReadLine();
                        Console.Write("Enter member name: ");
                        string returnMember = Console.ReadLine();
                        if (books.ContainsKey(returnTitle))
                        {
                            books[returnTitle]++;
                            borrowedMembers.Remove(returnMember);
                            Console.WriteLine($"{returnMember} returned {returnTitle}.");
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("All Books:");
                        foreach (var book in books)
                        {
                            Console.WriteLine($"{book.Key} - {book.Value} copies");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Borrowed Members:");
                        foreach (var member in borrowedMembers)
                        {
                            Console.WriteLine(member);
                        }
                        break;
                    case 7:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}