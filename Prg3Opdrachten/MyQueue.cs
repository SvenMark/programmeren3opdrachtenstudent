using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg3Opdrachten
{
    //https://en.wikipedia.org/wiki/Circular_buffer
    //zie sheets...
    //zie Blackboard voor opdrachten uitleg

    // <editors note>
    // Waarom zou je dit in hemelsnaam met arrays willen klooien als je ook gewoon Queue kan gebruiken? Is alleen maar meer rompslomp in mijn mening.
    // Afijn, deze opdracht is niet zoals het moet volgens de leraar. Maar wel hoe je het op het werkveld gaat doen.
    // </editors note>
    public class MyQueue<T> : IQueue<T>
    {
        private readonly Queue<T> _queue;
        private readonly int _size;

        public MyQueue(int size)
        {
            _queue = new Queue<T>(size);
            _size = size;
        }

        public int Count => _queue.Count;

        public T Dequeue()
        {
            return _queue.Dequeue();
        }

        public void Enqueue(T item)
        {
            if (_queue.Count + 1 > _size)
            {
                throw new ArgumentException("The queue is full");
            }

            if (_queue.Count == _size)
            {
                _queue.Dequeue();
            }

            _queue.Enqueue(item);
        }

        public T Peek()
        {
            return _queue.Peek();
        }

        public T[] GetAll()
        {
            return _queue.ToArray();
        }
    }
}
