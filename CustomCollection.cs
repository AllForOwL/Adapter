using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Adapter
{
    public class CustomCollection<T> : ICollection<T>
    {
        private List<T> _list;

        public CustomCollection()
        {
            _list = new List<T>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(T item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(T item)
        {
            try
            {
                _list.Remove(item);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remove(int index)
        {
            try
            {
                _list.RemoveAt(index);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index <= _list.Count)
                    return _list[index];

                return default(T);
            }
            set
            {
                if (index <= _list.Count)
                    _list[index] = value;
            }
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
    }
}
