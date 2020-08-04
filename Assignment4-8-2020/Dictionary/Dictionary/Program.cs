using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Dictionary<int, string> di = new Dictionary<int, string>();
                di.Add(1, "hema");
                di.Add(2, "hemu");
                di.Add(3, "pinky");
                di.Add(4, "chunky");
                di.Add(5, "hemamala");
                Console.WriteLine("-------------Printing Dictionary Element--------------------");
                foreach (var a in di)
                {
                    Console.WriteLine(a);
                }
                Console.WriteLine();


                Console.WriteLine("Count of element in dictionary : {0}", di.Count);

                Console.WriteLine("Checking index 2 in di : {0}", di.ContainsKey(2));
                Console.WriteLine("Checking Value Satya in di : {0}", di.ContainsValue("Satya "));
                Console.WriteLine("Checking index 7 in di : {0}", di.ContainsKey(4));

                Console.WriteLine("Removing All element From dictionary : ");
                di.Clear();

                foreach (var a in di)
                {
                    Console.WriteLine(a);
                }


                Console.ReadLine();
            }
        }
    }

    

