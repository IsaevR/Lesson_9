using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_9
{

    class ObservableIList<T> : List<T[]>, IList<T[]>, ICollection<T[]>
    {
        public delegate void MethodContainer();
        

        private List<T[]> ilist = new List<T[]>();
        T[] List = new T[0];
        public int Length { get { return List.Length; } }

        public void Add2(params T[] value)
        {
            
            ilist.Add(value);
            if (value != null)
            {
                Add2();
            }
            
        }

       

        public void Remove(int index)
        {
            ilist.RemoveAt(index);

            
        }

        void Insert2(int index, T[] value)
        {
            ilist.Insert(index, value);
            
        }

        public int Count2 { get { return ilist.Count; } }

        bool IsReadOnly { get; }

      
        
        void Clear2()
        {
            ilist.Clear();
        }

       
    }
}
