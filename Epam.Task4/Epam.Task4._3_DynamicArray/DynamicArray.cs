using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4._3_DynamicArray
{
    public class DynamicArray<T>
    {
        private T[] array;
        private int capacity;
        private int last;

        public DynamicArray()
        {
            array = new T[8];
            capacity = 8;
            last = -1;
        }

        public DynamicArray(int n)
        {
            array = new T[n];
            capacity = n;
            last = -1;
        }

        public DynamicArray(IEnumerable<T> list)
        {
            array = new T[list.Count()];
            int i = 0;
            foreach (var item in list)
            {
                array[i] = item;
                i++;
            }
            capacity = array.Count();
            last = -1;
        }

        public void Add(T elem)
        {
            if (last == capacity - 1)
            {
                Array.Resize<T>(ref array, capacity * 2);
                array[capacity] = elem;
                last = array.Count() - 1;
                capacity *= 2;
            }
            else
            {
                array[last] = elem;
                last++;
            }
        }

        public void AddRange(IEnumerable<T> elems)
        {
            if (last >= capacity - 1)
            {
                int n = (int)Math.Ceiling((double)capacity / elems.Count());
                Array.Resize<T>(ref array, capacity * n);
                int count = 0;
                int i = capacity;

                foreach (var item in elems)
                {
                    array[i] = item;
                    i++;
                    last++;
                    count++;
                }

                //last = array.Count() - 1;
                capacity *= n;
            }
            else
            {
                int i = capacity;
                foreach (var item in elems)
                {
                    array[i] = item;
                    i++;
                    last++;
                }
            }
        }

        public bool Remove(int n)
        {
            bool flag = false;
            for (int i = n; i < array.Length; i++)
            {

                flag = true;
            }
            return flag;
        }



    }
}
