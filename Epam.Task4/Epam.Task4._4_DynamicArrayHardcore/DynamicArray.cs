using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4._4_DynamicArrayHardcore
{
    public class DynamicArray<T> : IEnumerable, IEnumerable<T>, ICloneable, IShowable
    {
        protected T[] array;
        protected int capacity;
        protected int last;

        public DynamicArray()
        {
            this.array = new T[8];
            this.capacity = 8;
            this.last = 0;
        }

        public DynamicArray(int n)
        {
            this.array = new T[n];
            this.capacity = n;
            this.last = 0;
        }

        public DynamicArray(IEnumerable<T> list)
        {
            this.array = new T[list.Count()];
            int i = 0;

            foreach (var item in list)
            {
                this.array[i] = item;
                i++;
            }

            this.capacity = this.array.Count();
            this.last = this.capacity;
        }

        public int Length
        {
            get
            {
                return this.last;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            set
            {
                if (value < this.capacity)
                {
                    this.last = value;
                }
                else
                { 
                    this.last = this.capacity; 
                }

                this.capacity = value;
                Array.Resize<T>(ref this.array, this.capacity);
            }
        }

        public T this[int i]
        {
            get
            {
                if (i >= 0)
                {
                    return this.array[i];
                }
                else
                {
                    return this.array[this.last + i];
                }
            }

            set
            {
                this.array[i] = value;
            }
        }

        public void Add(T elem)
        {
            if (this.last >= this.capacity)
            {
                this.last = this.array.Count();
                this.capacity *= 2;

                Array.Resize<T>(ref this.array, this.capacity);
                this.array[this.last] = elem;
            }
            else
            {
                this.array[this.last] = elem;
                this.last++;
            }
        }

        public void AddRange(IEnumerable<T> elems)
        {
            this.last += 1;
            if (this.last >= this.capacity)
            {
                int n = (int)Math.Ceiling((double)this.capacity / elems.Count());
                this.capacity *= n;

                Array.Resize<T>(ref this.array, this.capacity);

                foreach (var item in elems)
                {
                    this.array[this.last] = item;
                    this.last++;
                }
            }
            else
            {
                foreach (var item in elems)
                {
                    this.array[this.last] = item;
                    this.last++;
                }
            }
        }

        public bool Remove(int n)
        {
            bool flag = false;
            for (int i = n; i < this.array.Length - 1; i++)
            {
                this.array[i] = this.array[i + 1];
                flag = true;
            }

            this.last -= 1;

            return flag;
        }

        public bool Insert(T elem, int n)
        {
            bool flag = false;
            if (this.last >= this.capacity)
            {
                this.capacity *= 2;
                Array.Resize<T>(ref this.array, this.capacity);
            }

            for (int i = this.last + 1; i > n; i--)
            {
                this.array[i] = this.array[i - 1];
                flag = true;
            }

            this.array[n] = elem;
            this.last += 1;

            return flag;
        }

        public T[] ToArray()
        {
            T[] arr = new T[this.last];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = this.array[i];
            }

            return arr;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.array)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this.GetEnumerator();
        }

        public void Show()
        {
            for (int i = 0; i < this.last; i++)
            {
                Console.Write($"{this.array[i]} ");
            }

            Console.WriteLine();
        }

        public object Clone()
        {
            return new DynamicArray<T>(this.array);
        }
    }
}
