using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Demo
{
    /* List<T> class represents the list of objects which can be accesssed with index.
     * It is Dynamic and we can resize the list.*/
    public class List_Demo
    {
        //Creating a List of Integers.
        List<int> list = new List<int>();
        public void Addition()
        {
            list.Add(20);
            list.Add(30);
            list.Add(6);
            list.Add(5);
            list.Add(4);
            list.Add(3);
            list.Add(2);
            list.Add(1);
            foreach(int  item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****************************************");
            Console.WriteLine("Count of the List is : " + list.Count);
            /*When you create a new instance of List<int>, it starts with a default capacity, which is typically 4. 
             As you add elements to the list using the Add method, the list's count increases, and when the count exceeds the current capacity, 
             the list automatically resizes its internal array to accommodate more elements. The resizing process involves creating a new array with
             a larger size and copying the existing elements to the new array.
             By default, the List<int> class increases its capacity by doubling the current capacity whenever a resize is needed. 
             For example, if the current capacity is 4 and you add the 5th element, the list will resize its internal array to a capacity of 8. 
             This resizing strategy helps optimize performance because it reduces the frequency of resizing operations.
             */
            Console.WriteLine("Capacity of list is : " + list.Capacity);
            list.Add(30);
            list.Add(6);
            Console.WriteLine("Finding Element "+ list.Contains(5));
            Console.WriteLine("Removing Element "+ list.Remove(1));
            Console.WriteLine("****************************************");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.RemoveAt(5);
            Console.WriteLine("****************************************");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            list.Clear();
            list.Count();
        }
    }
}
