using System;

namespace Arraycheck // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];
            for (int i = 0; i < array.Length; i++)
            {
                array[i]=Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ",array[i]);
            }
            Console.WriteLine();
            Console.WriteLine(array.Max());
            Console.WriteLine(array.Min()); 
            Console.WriteLine(array.Sum());
        }
    }
}