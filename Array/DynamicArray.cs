﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class DynamicArray<T> : IEnumerable<T>
    {
        private T[] array;
        private int capacity = 0;
        private int size = 0;

        public DynamicArray()
        {
            this.capacity = 10;
        }

        public DynamicArray(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentException("capacity can not  be  negative " + capacity);
            }
            else
            {
                this.capacity = capacity;
            }
            array = (T[])new T[capacity];
        }

        public int Size()
        {
            return this.size;
        }

        public bool IsEmpty()
        {
            return Size() == 0;
        }

        public T GetT(int index)
        {
            return array[index];
        }

        public void setT(int index, T element)
        {
            array[index] = element;
        }

        public void clear()
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = default(T);
            }
            size = 0;
        }

        public void Add(T element)
        {
            if (size >= capacity - 1)
            {
                if (capacity == 0)
                {
                    capacity = 1;
                }
                else
                {
                    capacity *= 2;
                }
                T[] newArray = new T[capacity];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }
            array[size++] = element;
        }

        public void RemoveAt(int index)
        {
            if (index >= size || index <= 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                T[] newArray = (T[])new T[size - 1];
                for (int i = 0; i < index; i++)
                {
                    newArray[i] = (T)array[i];
                }
                for (int i = index; i < array.Length - 1; i++)
                {
                    newArray[i] = array[i + 1];
                }
            }
        }

        public void Remove(Object obj)
		{
            int removeIndex = IndexOf(obj);
            RemoveAt(removeIndex);
		}

        public int IndexOf(Object obj)
		{
			for (int i = 0; i < size; i++)
			{
				if (obj == null)
				{
					if (array[i] == null)
					{
                        return i;
					}
				}
				else
				{
					if (obj.Equals(array[i]))
					{
                        return i;
					}
				}
			}
            return -1;
		}

        public bool Contains(Object obj)
        {
            return IndexOf(obj) != 1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return null;
        }

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
    }
}
