using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NegativeNumberException;

namespace GenericsImplementatiom
{
    public class RecentlyUsedList<T>
    {
        List<T> _Array;
        public RecentlyUsedList(int size)
        {
            _Array = new List<T>(size);
        }
        public T this[int index] 
        {
            get
            {
                return _Array[index];
            }
        }
        public void AddItem(T value)
        {
             int index = _Array.IndexOf(value);
             if (index == -1)
             {
                 int noOfElements = _Array.Count<T>();
                 if(noOfElements==_Array.Capacity)
                 {
                     _Array.RemoveAt(noOfElements-1);
                     Swap(noOfElements-1, value);
                 }
                 else
                 {
                     Swap(noOfElements, value);
                 }                
              }
              else
              {
                  _Array.RemoveAt(index);
                  Swap(index, value);
              }
        }
        private void Swap(int j,T value)
        {
            for (int k = j; k > 0; k--)
            {
                _Array.Insert(k, _Array.ElementAt(k - 1));
                _Array.RemoveAt(k - 1);       
            }
            _Array.Insert(0, value);
        }
        public int NoOfElements()
        {
            int count = _Array.Count<T>();
            return count;
        }
    }
}
