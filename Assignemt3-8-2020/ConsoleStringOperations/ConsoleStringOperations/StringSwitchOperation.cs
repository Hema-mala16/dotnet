using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStringOperations
{
    class StringSwitchOperation
    {
        void Display()
        {
            Console.WriteLine("1. Concatenate Strings. ");
            Console.WriteLine("2. Length of two strings. ");
            Console.WriteLine("3. Substring ");
            Console.WriteLine("4. Replace. ");
            Console.WriteLine("5. Uppercase.");
            Console.WriteLine("6. Lowercase.");
            Console.WriteLine("7. Trim. ");
            Console.WriteLine("8. Split. ");
            Console.WriteLine("Make  the choice  again..Enter 9 to exit ");
        }
        static void Main()
        {
            Console.WriteLine("Enter a string  ");
            string strA = Console.ReadLine();

            Console.WriteLine("Enter a string  ");
            string strB = Console.ReadLine();

            Console.WriteLine("-----------------------");


            string str;
            StringSwitchOperation obj = new StringSwitchOperation();

        check: Console.WriteLine();
            //Console.WriteLine("===============================================================");
            obj.Display();



            char c;
           // Console.WriteLine("Enter your choice ");
            c = Convert.ToChar(Console.ReadLine());




            switch (c)
            {
                case '1':
                    str = String.Concat(strA, strB);
                    Console.WriteLine("Concatenated string is: {0}", str);
                    goto check;
                //break;
                case '2':
                    Console.WriteLine("String Length of frist : " + strA.Length);
                    Console.WriteLine("String Length of frist : " + strB.Length);
                    goto check;
                //break;
                case '3':
                    Console.WriteLine("Substring of string A " + strA.Substring(3));
                    Console.WriteLine("Substring of string B " + strB.Substring(4));
                    goto check;

                //break;
                case '4':
                    Console.WriteLine(strA = strA.Replace('a', 'b'));
                    Console.WriteLine(strB = strB.Replace('c', 'd'));
                    goto check;
                //break;
                case '5':
                    Console.WriteLine(strA = strA.ToUpper());
                    Console.WriteLine(strB = strB.ToUpper());
                    goto check;
                //break;

                case '6':
                    Console.WriteLine(strA = strA.ToLower());
                    Console.WriteLine(strB = strB.ToLower());
                    goto check;
                //break;
                case '7':
                    char[] arrA = { 'J', 'a' };
                    Console.WriteLine("String = " + strA);
                    Console.WriteLine("String (after trim) = " + strA.Trim(arrA));

                    char[] arrB = { 'I', 'a' };
                    Console.WriteLine("String = " + strB);
                    Console.WriteLine("String (after trim) = " + strA.Trim(arrB));
                    goto check;
                // break;
                case '8':
                    char[] separator = { ':', ' ' };
                    string[] words = strA.Split(separator);
                    foreach (string word in words)
                    {
                        Console.WriteLine(word);
                    }

                    char[] separator1 = { ';', ' ' };
                    string[] words1 = strB.Split(separator);
                    foreach (string word in words1)
                    {
                        Console.WriteLine(word);
                    }


                    goto check;
                //  break;
                case '9':

                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}
