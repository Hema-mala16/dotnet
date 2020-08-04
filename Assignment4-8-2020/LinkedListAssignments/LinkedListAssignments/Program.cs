using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignments
{
    class Program
    {
            static void Main(string[] args)
             {
        //            LinkedList<string> lList = new LinkedList<string>(new string[] {"quick","fox","the","lazy"});
        //            string str = "";


        //            lList.AddFirst("the");

        //           lList.AddLast("fox");
        //            var stu = lList.Find("quick");


        //            lList.AddAfter(stu ,"brown");

        //            var stude = lList.FindLast("the");
        //            lList.AddBefore(stude, "jumps");
        //            lList.AddBefore(stude, "over");

        //            foreach (var st in lList)
        //            {
        //                str += st + " ";


        //            }
        //            Console.WriteLine(str);
        //        }
        //    }
        //}
        LinkedList<string> lList = new LinkedList<string>(new string[] { "quick", "fox", "the", "lazy" });
        Console.WriteLine("====Performing LinkedList methods====");
                foreach (string str in lList)
                {
                    Console.WriteLine(str);
                }
    Console.WriteLine();
                lList.AddFirst("the");
                Console.WriteLine(" Add 'the' to beginning of the list by AddFirst():{0}", lList.Count);
                foreach (string the in lList)
                {
                    Console.WriteLine(the);
                }

LinkedListNode<string> current1 = lList.Find("fox");

lList.AddBefore(current1, "brown");
                Console.WriteLine("Add 'brown'  to the list AddBefore():{0}", lList.Count);
                foreach (string brown in lList)
                {
                    Console.WriteLine(brown);
                }

                LinkedListNode<string> current2 = lList.Find("fox");
lList.AddAfter(current2, "jumps");
                Console.WriteLine("Add 'jumps' to  the list AddAfter():{0}", lList.Count);
                foreach (string jump in lList)
                {
                    Console.WriteLine(jump);
                }
                LinkedListNode<string> current3 = lList.FindLast("jumps");

lList.AddAfter(current3, "over");
                Console.WriteLine("Add 'over' to  the list:{0}", lList.Count);
                foreach (string over in lList)
                {
                    Console.WriteLine(over);
                }
                lList.AddLast("fox");
                Console.WriteLine(" Add 'fox' to ending of the list:{0}", lList.Count);
                foreach (string fox in lList)
                {
                    Console.WriteLine(fox);
                }

                        


            Console.Read();
            }
        
    }
}
