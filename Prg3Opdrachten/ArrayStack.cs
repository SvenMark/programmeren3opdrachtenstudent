using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg3Opdrachten
{
    public class ArrayStack<T> : IStack<T>
    {
        private T[] _array;
        private int _index;
        public int Count => _index + 1;
        public int Capacity => _array.Length;

        public ArrayStack(int stackLength = 2)
        {
            _array = new T[stackLength];
            _index = -1;
        }


        public T Peek()
        {
            if (_index == -1)
            {
                throw new ArgumentException("The Array Stack is empty");
            }

            return _array[_index];
        }

        public T Pop()
        {
            if (_index == -1)
            {
                throw new ArgumentException("The Array Stack is empty");
            }
            if (_index < _array.Length / 4)
            {
                Shrink();
            }

            var result = _array[_index];
            _index--;
            return result;
        }

        public void Push(T o)
        {
            _index++;
            if (_index == _array.Length)
            {
                Grow();
            }

            _array[_index] = o;
        }


        private void Grow()
        {
            int elementsNewLength = _array.Length * 2;
            T[] newElements = new T[elementsNewLength];
            Array.Copy(_array, newElements, _array.Length);
            _array = newElements;
        }


        private void Shrink()
        {
            int elementsNewLength = _array.Length / 2;
            T[] newElements = new T[elementsNewLength];
            Array.Copy(_array, newElements, elementsNewLength);
            _array = newElements;
        }
    }
}