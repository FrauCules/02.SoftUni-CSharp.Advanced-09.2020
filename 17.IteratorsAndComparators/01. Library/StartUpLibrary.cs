using System;
using System.Linq;

namespace IteratorsAndComparators
{
    public class StartUpLibrary
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case 1", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case 2", 1930);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            foreach (var item in libraryTwo)
            {
                Console.WriteLine(item.Title);
                //Console.WriteLine(item.Year);
                //foreach (var items in item.Authors)
                //{
                //    Console.WriteLine(items);
                //}
            }
        }
    }
}
