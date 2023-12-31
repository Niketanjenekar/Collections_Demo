﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Demo
{
    public class Program
    {
        /*Collection is a class that means we can create an object
         can be create or ddecleared instance of a aclass , so we can add a data in collections
         Collection types - are designed to store, manage similar data.
        We can aUse to adding*/
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose the Option For Program to Execute : ");
                Console.WriteLine("1. List ");
                Console.WriteLine("2. Array ");
                Console.WriteLine("3. ArrayList");
                Console.WriteLine("4. Dictionary");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Welcome to List ");
                        List_Demo list_Demo = new List_Demo();
                        list_Demo.Addition();
                        break;
                    case 2:
                        Console.WriteLine("Welcome to Array ");
                        Array_Demo array_Demo = new Array_Demo();
                        array_Demo.Addition();
                        break;
                    case 3:
                        Console.WriteLine("Welcome to ArrayList ");
                        Array_List array_ListDemo = new Array_List();
                        array_ListDemo.ArrayList();
                        break;
                    case 4:
                        Console.WriteLine("Welcome to Dictionary ");
                        Dictionary_Demo dictionary_Demo = new Dictionary_Demo();
                        dictionary_Demo.DictionaryDemo();
                        break;
                    default:
                        Console.WriteLine("Please Choose the Correct Option ");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
