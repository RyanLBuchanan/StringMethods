using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    class StringMethods
    {
        static void Main(string[] args)
        {
            var string1 = "hello there";
            var characterArray = new char[5];

            Console.WriteLine($"string1: \"{string1}\"");

            Console.WriteLine($"Length of string1: {string1.Length}");

            Console.Write("The string reversed is: ");

            for (int i = string1.Length - 1; i >= 0; --i)
            {
                Console.Write(string1[i]);
            }

            // Copy the characters from string1 to characterArray
            string1.CopyTo(0, characterArray, 0, characterArray.Length);
            Console.Write("\nThe character array is: ");

            foreach (var element in characterArray)
            {
                Console.Write(element);
            }

            Console.WriteLine("\n");
        }
    }
}
