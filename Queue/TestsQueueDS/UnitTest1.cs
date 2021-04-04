using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueueDS;

namespace TestsQueueDS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Enqueue_EmptyQueue_ShouldAddElement()
        {
            // Arrange
            QueueDataS<int> queue = new QueueDataS<int>();

            // Act
            queue.Engueue(5);

            // Assert
            Assert.AreEqual(1, queue.IndexCount);
        }
    }
}
