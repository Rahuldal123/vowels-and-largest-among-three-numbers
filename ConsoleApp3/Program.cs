using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // WAP ocheck largest num among three numbers 


            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                if (a > c)
                    Console.WriteLine("a is largest number");
                else Console.WriteLine("c is largest number");
            else if (b > c)
                Console.WriteLine("b is largest");
            else
                Console.WriteLine("c is the largest number");


            // WAp to Check given caracter is vowel or not


            //char a = Convert.ToChar(Console.ReadLine());
            //if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
            //    Console.WriteLine("it is vowel");
            //else
            //    Console.WriteLine("it is consent");










        }
    }
}
