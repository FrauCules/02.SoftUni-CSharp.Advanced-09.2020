using System;
using System.Collections;
using System.Collections.Generic;

namespace _09.Demo_Yield_Returt_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerator<int> enumerator = GetNums().GetEnumerator(); // вика краткия вариант на енумеротор
            //IEnumerator<int> enumerator = new GetNumsEnumerator(); // вика дългия вариант на енумеротор
            var result = 0;
            enumerator.MoveNext();

            result += enumerator.Current;
            enumerator.MoveNext();
            result += 50;
            result += enumerator.Current;

            enumerator.MoveNext();
            result += enumerator.Current;

            Console.WriteLine(result);
        }
        static IEnumerable<int> GetNums() // краткия вариант на енумератор
        {
            yield return 5;
            Console.WriteLine("Print ***");
            yield return 8;
            yield return 9;
            yield return 10;
            yield return 11;
        }

        // ако трябва да имплементираме собствен еномератор - сложния вариант, идентичен със static IEnumerable<int> GetNums()
        private class GetNumsEnumerator : IEnumerator<int> 
        {
            private int index = -1;
            public int Current  
            {
                get
                {
                    if (index == 0)
                    {
                        return 5;
                    }

                    if (index == 1)
                    {
                        Console.WriteLine("Print ***");
                        return 8;
                    }

                    if (index == 2)
                    {
                        return 9;
                    }

                    return -1;
                } 
            }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                index++;
                if(index >= 3)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public void Reset()
            {
                index = -1; ;
            }
        }
    }
}
