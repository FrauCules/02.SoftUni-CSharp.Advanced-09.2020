using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _09.Demo_IEnumerator
{
    public class Game : IPrintable, IEnumerable<int>
    {
        public void End(bool idOver)
        {
            Console.WriteLine();
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
