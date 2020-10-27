using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsClasses
{
    class Math
    {
        public static object Add(object a, object b)
        {
            if(a is string && b is string) // проверяваме да ли параметрите са стринг
            {
                return a.ToString() + b.ToString();
            }

            // можем да включим проверки на др.типове и да върнем съответен резултат...
            return 0;  
        }
    }
}
