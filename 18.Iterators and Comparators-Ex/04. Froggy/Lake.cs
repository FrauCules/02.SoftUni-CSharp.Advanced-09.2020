using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Froggy
{
    class Lake: IEnumerable<int>
    {
        private List<int> stones;

        public Lake(params int[] stones) // за упражняване на params
        {
            this.stones = stones.ToList(); // на List присвояваме масив с ToList()
        }

        public IEnumerator<int> GetEnumerator()
        {
            int last = stones.Count-1;

            for (int i = 0; i < stones.Count; i+=2)
            {
                yield return stones[i];
            }

            if (last % 2 == 0)      // ако посл.индекс е четно -> намаляме с 1
            {
                last--;
            }

            for (int i = last; i > 0; i-=2)
            {
                yield return stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
