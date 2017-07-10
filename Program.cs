using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var adapter = new Adapter();
            for (int i = 0; i < 10; i++)
            {
                adapter.Add(i);
            }

            adapter.Change(10, 0);
            adapter.Remove(0);

            Console.ReadKey();
        }
    }
}