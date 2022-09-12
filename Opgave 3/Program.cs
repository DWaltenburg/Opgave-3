using System;

namespace Opgave_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] value = { 1, 3, 5, 2, 4, 0 };
            string[] abbrev = { "CPU", "RAM", "HDD", "USB", "VGA", "DVI" };

            foreach (string val in abbrev)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine();
            for ( int i = 0; i < value.Length; i++)
            {
                Console.WriteLine(abbrev[value[i]]);
            }
        }
    }
}
