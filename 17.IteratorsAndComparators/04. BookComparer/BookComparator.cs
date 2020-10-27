using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book x,  Book y)     // краткия запис на долното
        {
            int result = x.Title.CompareTo(y.Title);   // първо ги подрежда по заглавия във възходящ ред (й - е първия) 

            if (result == 0)
            {
                result = y.Year.CompareTo(x.Year);  // ако две за главия са еднакви - по година на издаване
                                                    // така ще връща в низходящ ред (y е първия)
            }

            return result;

            //if (x.Year > y.Year) // ако обърнем знака (<) на (>) => сменяме реда на сортировката books.Sort() или OrderBy() в низходящ ред
            //{
            //    return 1;
            //}
            //if (x.Year < y.Year) // Можем да сортираме по имената на книгите (по пэрва буква) => (Name[0] == other.Name[0])
            //{
            //    return -1;
            //}
            //else
            //{
            //    return 0;
            //}
        }
    }
}
