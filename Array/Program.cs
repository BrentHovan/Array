using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] eponymous = new int[25];
            for (int i = 1; i < eponymous.Length + 1; i++)
            {
                Console.WriteLine("Element value = " + i);
            }
            Console.ReadKey(true);
        }
    }
}
