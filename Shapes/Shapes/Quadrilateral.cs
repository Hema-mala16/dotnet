using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Shapes
{
    abstract class Quadrilateral
    {

        public int length;
        public Quadrilateral()
        {

        }
        public Quadrilateral(int _length)
        {
            length = _length;
        }

        abstract public int Area();
        //abstract public void Display();

    }
    class Square : Quadrilateral
    {
        
        public Square()
        {

        }
        public Square(int length) : base(length)
        {
            
        }
        public override int Area()
        {
          int   area = length * length;
            return area;
        }
       


    }
    class Rectangle : Quadrilateral
    {
        int breadth;
        
       
    public   Rectangle()
        {

        }
        public Rectangle(int length,  int _breath) : base(length)
        {
            breadth = _breath;
           


        }
        public override int Area()
        {
            return (breadth * length);
        }
        
    }

}

