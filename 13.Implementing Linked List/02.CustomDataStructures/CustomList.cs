using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDataStructures
{
    public class CustomList
    {
        private const int INITIAL_CAPACITY = 2;
        //private readonly int[] items;
        private  int[] items;

        public CustomList() // // конструктора задава първоначалния капацитет на 2
        {
            this.items = new int[INITIAL_CAPACITY];
        }
        public int Count { get; private set; } //  съдържа боя на значещите елементи

        public void Add(int item)       // добавя елемент в масива
        {
            if(this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count] = item;
            this.Count++;
        }

        public int RemoveAt(int index)  // изтрива елемент на дадена позиция и връща стойността на изтрития елемент 
        {
            if (!this.IsValidIndex(index)) // валидация на индекса
            {
                throw new ArgumentOutOfRangeException();
            }

            int removedItem = this.items[index]; // елемента, който ще изтриваме
            this.items[index] = default(int);   // нулира стойността на елемента
            this.ShiftToLeft(index);                  // праща за изтриване и преместване на сл.елементи

            this.items[Count-1] = default;
            this.Count--;                       // намалява стойността на значещите елементи с 1

            if(this.Count <= this.items.Length/4)
            {
                this.Shrink();  // свива капацитета на масива
            }

            return removedItem;
        }

        public void Insert(int index, int element) // вмъква елемент на определена позиция
        {
            if (!IsValidIndex(index))
            {
                throw new ArgumentOutOfRangeException();
            }

            if(this.Count== this.items.Length)
            {
                this.Resize();
            }

            this.ShiftToRight(index);
            this.items[index] = element;
            this.Count++;
        }

        public bool Contains(int item) // връща true ако има този елемент, ако не - връща false
        {
            for (int i = 0; i < this.Count; i++)
            {
                int currentElement = this.items[i];

                if (currentElement == item)
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)   // местата на два елемента по техн.индекси
        {
            if(!IsValidIndex(firstIndex) || !IsValidIndex(secondIndex))
            {
                throw new ArgumentOutOfRangeException();
            }

            // Aditional Variable - бавен и лесен метод
            //int currentItem = this.items[firstIndex];
            //this.items[firstIndex] = this.items[secondIndex];
            //this.items[secondIndex] = currentItem;

            // Bitwise - много бърз, пести памет
            // x = x ^ y;
            // y = x ^ y;
            // x = x ^ y;
            this.items[firstIndex] = this.items[firstIndex] ^ this.items[secondIndex];
            this.items[secondIndex] = this.items[firstIndex] ^ this.items[secondIndex];
            this.items[firstIndex] = this.items[firstIndex] ^ this.items[secondIndex];
        }

        public int this[int index] // Индексатор/4
        { 
            get 
            {
                if (!this.IsValidIndex(index))
                {
                    throw new ArgumentOutOfRangeException();
                }
                return this.items[index];
            }
            set 
            {
                if (!this.IsValidIndex(index))
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.items[index] = value; // записва стойността след = (value)
            }

        }

        private void Resize()   // удвоява капацитета на масива
        {
            int[] copy = new int[this.items.Length*2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            items = copy;
        } 

        private void Shrink()  // свива капацитета на масива
        {
            int[] copy = new int[this.items.Length / 2];

            for (int i = 0; i < this.Count; i++)
            {
                this.items[i] = copy[i];
            }

            this.items = copy;

        } 

        private void ShiftToLeft(int index) // изтрива определена позиция и премества следващите елементи с една позиция назад/наляво
        {
            for (int i = index; i < this.Count-1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        } 

        private void ShiftToRight(int index)   // от определена позиция премества следващите елементи с една позиция надясно
        {
            for (int i = Count; i > index; i--)
            {
                this.items[i] = this.items[i-1];
            }
        }

        private bool IsValidIndex(int index) // проверява дали индекса е валиден
        => index < this.Count;

        public override string ToString() // наш ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.Count; i++)
            {
                if(i == this.Count - 1)
                {
                    // Final iteration
                    sb.Append($"{this.items[i]}");
                }
                else
                {
                    sb.Append($"{this.items[i]}, ");
                }
            }
            
            return sb.ToString().TrimEnd(); // ползвай TrimEnd() за да не остават празни редове
        }
    }
}
