using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlockingQueueTests
{
    [TestClass]
    public class UnitTests : TestBase
    {
        [TestMethod]
        public void NewQueueIsEmpty() 
        {
            const int queueCapacity = 10;
            BlockingQueue<int> queue = CreateBlockingQueue(queueCapacity);
            Assert.IsTrue(queue.Count == 0);
        }

        [TestMethod]
        public void InsertsToEmptyQueue() 
        {
            const int numberOfInserts = 10;
            const int queueCapacity = 10;
            BlockingQueue<int> queue = CreateBlockingQueue(queueCapacity);
            for (int i = 0; i < numberOfInserts; i++)
                queue.Enqueue(new Random().Next(int.MinValue, int.MaxValue));
            Assert.IsTrue(queue.Count == numberOfInserts);
        }

        [TestMethod]
        public void EnqueueThenDequeue() 
        {
            const int queueCapacity = 10;
            const int elementToEnqueue = 256;
            BlockingQueue<int> queue = CreateBlockingQueue(queueCapacity);
            queue.Enqueue(elementToEnqueue);
            Assert.IsTrue(queue.Dequeue() == elementToEnqueue);
        }

        [TestMethod]
        public void FeelAndEmptyQueue() 
        {
            const int numberOfInserts = 10;
            const int queueCapacity = 10;
            BlockingQueue<int> queue = CreateBlockingQueue(queueCapacity);
            for (int i = 0; i < numberOfInserts; i++)
                queue.Enqueue(i);
            for (int i = 0; i < numberOfInserts; i++)
                Assert.IsTrue(queue.Dequeue() == i);
        }

        [TestMethod]
        public void RemovingDownToEmpty()
        {
            const int numberOfRemoves = 10;
            const int queueCapacity = 10;
            BlockingQueue<int> queue = CreateBlockingQueue(queueCapacity);
            for (int i = 0; i < numberOfRemoves; i++)
                queue.Enqueue(new Random().Next(int.MinValue, int.MaxValue));
            for (int i = 0; i < numberOfRemoves; i++)
                queue.Dequeue();
            Assert.IsTrue(queue.Count == 0);
        }

        [TestMethod]
        public void EnqueueOnFullQueue()
        {
            const int numberOfInserts = 10;
            const int queueCapacity = 10;
            BlockingQueue<int> queue = CreateBlockingQueue(queueCapacity);
            for (int i = 0; i < numberOfInserts; i++)
                queue.Enqueue(new Random().Next(int.MinValue, int.MaxValue));
            Assert.IsTrue(queue.Count == numberOfInserts);
        }
    }
}
