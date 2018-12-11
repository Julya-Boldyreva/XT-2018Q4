using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4._4_DynamicArrayHardcore
{
    public class CycledDynamicArray<T> : DynamicArray<T>, ICycleShowble
    {
        private int count = -1;

        public CycledDynamicArray()
            : base()
        {
        }

        public CycledDynamicArray(int n)
            : base(n)
        {
        }

        public CycledDynamicArray(IEnumerable<T> list)
            : base(list)
        {
        }

        private int Count
        {
            get
            {
                this.count++;
                if (this.count >= this.last - 1)
                {
                    this.count = 0;
                }

                return this.count;
            }
        }

        public T this[int i]
        {
            get
            {
                return this.array[this.Count];
            }

            set
            {
                this.array[i] = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
         {
            while (true)
            {
                yield return this.array[this.Count];
            }
         }

        public void ShowCycle()
        {
            foreach (var item in this.array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}
