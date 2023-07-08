using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Demo
{
    public class Dictionary_Demo
    {
        //Its a Generic Collection, it will store Key-Value Pair.
        //Define under System.Collection.Generics Namespace
        //Its Dynamic in Nature
        //In Dictionary cannot be Null but a Value can.
        //Key Must be Unique, Key duplicate are not allowed.
        //We can store only same Data-type Values.
        public void DictionaryDemo()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("First", "Niketan");
            dictionary.Add("Second", "10010");
            dictionary.Add("Third", "M");
            dictionary.Add("Fourth", "1.25");
            dictionary.Add("Fifth", "Jenekar");
            Console.WriteLine(dictionary["First"]);
            dictionary["Fifth"] = "Engineer";
            Console.WriteLine(dictionary["Fifth"]);
            foreach(KeyValuePair<string, string> ele in dictionary)
            {
                Console.WriteLine(ele.Key +" : "+ ele.Value);
            }
            dictionary.Remove("Fourth");
            for(int i = 0; i < dictionary.Count; i++)
            {
                var item = dictionary.ElementAt(i);
                Console.WriteLine(item.Value);
            }
        }
    }
}
