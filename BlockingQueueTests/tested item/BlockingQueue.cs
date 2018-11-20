using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace BlockingQueueTests
{
    public class BlockingQueue<T>
    {
        private readonly Queue<T> queue = new Queue<T>();
        private readonly int capacity = 1;
        public BlockingQueue(int capacity)
        {
            if (capacity > 0)
                this.capacity = capacity;
        }

        public int Count
        {
            get
            {
                return queue.Count;
            }
        }

        public void Enqueue(T element)
        {
            lock (queue)
            {
                while (queue.Count == capacity)
                    Monitor.Wait(queue);
                if (queue.Count == 0)
                    Monitor.PulseAll(queue);

                queue.Enqueue(element);
            }
        }

        public T Dequeue()
        {
            lock (queue)
            {
                while (queue.Count == 0)
                    Monitor.Wait(queue);
                if (this.queue.Count == capacity)
                    Monitor.PulseAll(queue);
                return queue.Dequeue();
            }
        }
    }
}
