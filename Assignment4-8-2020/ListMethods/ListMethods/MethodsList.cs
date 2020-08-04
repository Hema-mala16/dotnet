using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListMethods
{
    class MethodsList
    {
        public static void Main()
        {
            Console.WriteLine("using a generic collection list similar to arraylist");
            Console.WriteLine("...........FINDALL...............");
            List<int> firstlist = new List<int>();
            firstlist.Add(2);
            firstlist.Add(4);
            firstlist.Add(7);
            firstlist.Add(2);
            firstlist.Add(3);
            firstlist.Add(2);
            firstlist.Add(4);

            foreach (int k in firstlist)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine(" ");

            Console.Write("Elements that Match: \n");


            List<int> Result = new List<int>(firstlist.FindAll(a => a != 3));


            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("...........FINDINDEX..............");
            {

                foreach (var item in Result)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(firstlist.FindIndex(x => x == 7));
            }
            Console.WriteLine("...........FINDLAST..............");
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }

            Console.Write("Element is: ");
            Console.Write((firstlist.FindLast(a => a != 4)));

            // Console.WriteLine(firstlist.LastIndexOf(firstlist.FindLast(a => a != 2)));

        }
    }
}