using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDS
{
    public class QueueDataS<T> : IQueueDataS<T>
    {
        private T[] queue;
        private const int Initial_Capacity = 2;
        private int startIndex = 0;
        private int endIndex = 0;
        public QueueDataS()
        {
            queue = new T[Initial_Capacity];
        }

        public int IndexCount { get; set; }
        public T Dequeue()
        {
            if (this.IndexCount == 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            T element = this.queue[startIndex];
            this.startIndex++;
            this.IndexCount--;
            return element;
        }


        public void Engueue(T element)
        {
            if (this.IndexCount >= queue.Length)
            {
                this.Resize();
            }

            this.queue[endIndex] = element;
            endIndex++;
            this.IndexCount++;
        }

        private void Resize()
        {
            var copy = new T[this.queue.Length * 2];
            this.CopyElements(copy);
        }

        private void CopyElements(T[] copy)
        {
            var fromIndex = this.startIndex;
            var toIndex = this.endIndex;
            for (int i = 0; i < this.IndexCount; i++)
            {
                copy[endIndex] = this.queue[fromIndex];
                fromIndex++;
                toIndex++;
            }
        }
    }
}
