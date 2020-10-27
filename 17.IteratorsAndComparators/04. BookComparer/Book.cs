using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors.ToList();
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public int CompareTo(Book other) // ние определяме как да работи сравняването
        {
            int result = this.Year.CompareTo(other.Year);

            if (result == 0)
            {
                result = this.Year.CompareTo(other.Year);
            }

            return result;

        }

        //if (this.Title[0] < other.Title[0]) // ако обърнем знака (<) на (>) => сменяме реда на сортировката books.Sort() или OrderBy() в низходящ ред
        //{
        //    return -1;
        //}
        //if (this.Title[0] == other.Title[0]) // Можем да сортираме по имената на книгите (по пэрва буква) => (Name[0] == other.Name[0])
        //{
        //    return 0;
        //}
        //else
        //{
        //    return 1;
        //}
        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
