using System;
using System.Threading;

namespace BlockingQueueTests
{
    public class Consumer
    {
        private string _consumerName;
        private BlockingQueue<int> _queue;
        private int _consumeringTime;

        public Consumer(string name, BlockingQueue<int> queue, int consumeringTime)
        {
            _consumerName = name;
            _queue = queue;
            _consumeringTime = consumeringTime;
        }

        public void run()
        {
            while (true)
            {
                int elementDequeue;
                elementDequeue = _queue.Dequeue();
                Thread.Sleep(_consumeringTime);
            }
        }
    }
}
