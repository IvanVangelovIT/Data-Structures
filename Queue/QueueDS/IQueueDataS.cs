using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDS
{
    public interface IQueueDataS<T>
    {
        void Engueue(T element);
        T Dequeue();

    }
}
