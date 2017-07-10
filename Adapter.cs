using System;

namespace Adapter
{
    public class Adapter
    {
        private CustomCollection<int> _list { get; set; }

        public Adapter()
        {
            _list = new CustomCollection<int>();
        }

        public void Add(int value)
        {
            _list.Add(value);
            Console.WriteLine("Added value to List");
        }

        public void Change(int value, int index)
        {
            _list[index] = value;
            Console.WriteLine("Changed value in List");
        }

        public void Remove(int index)
        {
            _list.Remove(index);
            Console.WriteLine("Removing value from List");
        }
    }
}
