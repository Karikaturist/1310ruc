/*
 * 3.	Да се напише програма, която по три зададени страни смята лицето на триъгълник. Използвайте Херонова формула.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2._3
{
    class Program
    {
        static void Main(string[] args)
        {   //float a,b,c,p;
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            int p = (a + b + c) / 2;
            int M = (p * (p - a) * (p - b) * (p - c));
            int S =(int) Math.Sqrt(M);
            Console.Write("S=" + S);
        }
    }
}
