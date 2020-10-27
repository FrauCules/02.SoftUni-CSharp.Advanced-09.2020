using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class StartUpLibrary
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            //SortedSet<Book> sortedList = new SortedSet<Book>() { bookOne, bookTwo, bookThree }; 
            //SortedSet<Book> sortedList = new SortedSet<Book>(new BooksComparer()) {bookOne, bookTwo, bookThree };

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            foreach (var book in libraryTwo)
            {
                Console.WriteLine(book);
            }


            //foreach (var item in sortedList)
            //{
            //    Console.WriteLine(item);
            //}
            //Library libraryOne = new Library();
            //Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            //foreach (var item in libraryTwo)
            //{
            //Console.WriteLine(item.Title);
            //Console.WriteLine(item.Year);
            //foreach (var items in item.Authors)
            //{
            //    Console.WriteLine(items);
            //}
            //}

            //List<Book> books = new List<Book>() { bookOne, bookTwo, bookThree };
            //books.Sort();

            //books = books.OrderBy(x => x).ToList();

            //foreach (var item in books)
            //{
            //    Console.WriteLine($"{item.Title} - {item.Year}");
            //}

            //bookOne.CompareTo(55);
            //bookOne.CompareTo(bookTwo);

            //var bookss = new SortedSet<Book>() { bookOne, bookTwo, bookThree };
        }
    }
}
