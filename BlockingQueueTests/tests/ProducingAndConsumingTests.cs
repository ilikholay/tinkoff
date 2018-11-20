using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlockingQueueTests
{
    [TestClass]
    public class ProducingAndConsumingTests : TestBase
    {
        [TestMethod]
        public void CreateProducerAndConsumer()
        {
            BlockingQueue<int> Queue = CreateBlockingQueue(25);
            CreateNewProducer("Producer1", Queue, 5);
            CreateNewConsumer("Consumer1", Queue, 5);
            ImitateActivity(1000);
        }

        [TestMethod]
        public void CreateProducerOnly()
        {
            BlockingQueue<int> Queue = CreateBlockingQueue(25);
            CreateNewProducer("Producer1", Queue, 5);
            ImitateActivity(1000);
        }

        [TestMethod]
        public void CreateConsumerOnly()
        {
            BlockingQueue<int> Queue = CreateBlockingQueue(25);
            CreateNewConsumer("Consumer1", Queue, 5);
            ImitateActivity(1000);
        }

        [TestMethod]
        public void CreateSeveralProducersAndConsumers()
        {
            BlockingQueue<int> Queue = CreateBlockingQueue(25);
            CreateNewProducer("Producer1", Queue, 100);
            CreateNewProducer("Producer2", Queue, 50);
            CreateNewConsumer("Consumer1", Queue, 200);
            CreateNewConsumer("Consumer2", Queue, 150);
            CreateNewConsumer("Consumer3", Queue, 250);
            CreateNewConsumer("Consumer4", Queue, 100);
            CreateNewConsumer("Consumer5", Queue, 500);
            ImitateActivity(10000);
        }
    }
}
