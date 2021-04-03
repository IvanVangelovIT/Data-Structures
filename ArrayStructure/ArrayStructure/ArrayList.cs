using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStructure
{
    public class ArrayList<T> : IArrayList<T>
    {
        private const int Initial_Capacity = 2;
        private T[] arrayList;
        public ArrayList()
        {
            arrayList = new T[Initial_Capacity];
        }

        public int IndexCount { get; private set; }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.IndexCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.arrayList[IndexCount];
            }

            set
            {
                if (index < 0 || index >= this.IndexCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.arrayList[index] = value;
            }
        }

        public void Add(T item)
        {
            if (this.IndexCount == this.arrayList.Length)
            {
                this.Resize(true);
            }

            this.arrayList[this.IndexCount++] = item;
        }

        private void Resize(bool isExpanding)
        {
            var copy = isExpanding ? new T[this.arrayList.Length * 2] : new T[this.arrayList.Length / 2];
            Array.Copy(this.arrayList, copy, this.IndexCount);
            this.arrayList = copy;
        }

        public T RemoveAt(int index)
        {
            if (index < 0 || index >= this.IndexCount)
            {
                throw new ArgumentOutOfRangeException();
            }

            T element = this.arrayList[index];
            this.Reorder(index);
            this.IndexCount--;

            if (this.IndexCount <= this.arrayList.Length / 4)
            {
                this.Resize(false);
            }

            return element;
        }


        public void Reorder(int index)
        {
            for (int i = index; i < this.IndexCount; i++)
            {
                this.arrayList[i] = this.arrayList[i + 1];
            }
        }

   
    }

}
