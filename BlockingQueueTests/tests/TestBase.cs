using System;
using System.Threading;

namespace BlockingQueueTests
{
    public class TestBase
    {
        public BlockingQueue<int> CreateBlockingQueue(int capacity)
        {
            return new BlockingQueue<int>(capacity);
        }

        public void CreateNewProducer(string name, BlockingQueue<int> queue, int producingTime)
        {
            Producer newProducer       = new Producer(name, queue, producingTime);
            ThreadStart newThreadStart = new ThreadStart(newProducer.run);
            Thread newThread           = new Thread(newThreadStart);
            newThread.Start();
        }

        public void CreateNewConsumer(string name, BlockingQueue<int> queue, int consumiringTime)
        {
            Consumer newConsumer       = new Consumer(name, queue, consumiringTime);
            ThreadStart newThreadStart = new ThreadStart(newConsumer.run);
            Thread newThread           = new Thread(newThreadStart);
            newThread.Start();
        }

        public void ImitateActivity(int activityTime)
        {
            Thread.Sleep(activityTime);
        }
    }
}
