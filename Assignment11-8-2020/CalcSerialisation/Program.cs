using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using ClassCalcLib;


namespace CalcSerialisation
{
    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            Operators obj = new Operators();
            FileStream fs = new FileStream("Calculator.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(fs, obj);
            Console.WriteLine("Text File Created");
        }
    }
}
