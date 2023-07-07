using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Demo
{
    public class Array_Demo
    {
        public void Addition()
        {
            // Array is a Collection of Elements of same types.
            // Array index starts with Zero.
            // We can store only fix set of elements in a Array.
            //Type-1
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7 };
            string[] strings = new string[10];
            //Type-2
            int[] obj = new int[] { 1, 2, 3, 4, 6, 7 };
            int[] ints = { 1, 2, 3, 4, 6, 8 };
            //Type-3
            string[] strings_Two = new string[5] { "1", "2", "3", "4", "5 " };
            foreach(string s in strings_Two)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("**************************");
            string[] strings_Three = new string[] { "Niketan", "Jenekar", "is", "A", "Good", "Boy" };
            foreach (string s in strings_Three)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("**************************");
            //We can use For loop to Display Array .
            for(int n = 0; n < strings_Three.Length; n++)
            {
                Console.WriteLine(strings_Three[n]);
            }
            Console.WriteLine("*****************************");
            // We can use While Loop for Displaying Array.
            int value = 0;
            while(value < strings_Three.Length)
            {
                Console.WriteLine(strings_Three[value]);
                value++;
            }
        }
        
    }
}
