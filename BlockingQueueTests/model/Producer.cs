using System;
using System.Threading;

namespace BlockingQueueTests
{
    public class Producer
    {
        private string _producerName;
        private int _producingTime;
        private BlockingQueue<int> _queue;

        public Producer(string name, BlockingQueue<int> queue, int producingTime)
        {
            _producerName = name;
            _queue = queue;
            _producingTime = producingTime;
        }

        public void run()
        {
            while (true)
            {
                Thread.Sleep(_producingTime);
                int elementToEnqueue = new Random().Next(1, 999);
                _queue.Enqueue(elementToEnqueue);
            }
        }
    }
}
