using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Demo
{
    public class Array_List
    {
        //Its a Non-Generic Collection
        //it ia same as Array except its size increases dynamically
        //Stores the Element of Multiple Datatypes.
        public void ArrayList()
        {
           ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add("Apple");
            arrayList.Add("Banana");
            arrayList.Add("Peach");
            arrayList.Add('a');
            arrayList.Add('b');
            arrayList.Add('z');
            arrayList.Insert(1, 9);
            arrayList.Remove(9);
            arrayList.RemoveAt(1);
            Console.WriteLine(arrayList.Count);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("******************************");
            for(var i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

        }
    }
}
