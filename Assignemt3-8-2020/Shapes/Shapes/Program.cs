using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(4);
            Console.WriteLine("Square Area : " + s.Area());

            Rectangle  q= new Rectangle(6,5);
            
            Console.WriteLine("Rectangle Area : " + q.Area());


            if (s.Area() > q.Area())
            {
                Console.WriteLine("Square area is greater than Rectangle area");
            }
            else
            {
                Console.WriteLine("Rectangle area is greater than Square area");
            }


            Console.Read();

        }
    }
}
        
