using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStructure
{
    public interface IArrayList<T>
    {
        void Add(T item);
        void Reorder(int index);
    }
}
