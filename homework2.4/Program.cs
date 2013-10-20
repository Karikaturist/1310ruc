/* 4.	Да се напише програма, която чете цяло число от конзолата и го умножава по 8 без да използва операторът за умножение.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine()); 
            int proizvedenie = x + x + x + x + x + x + x + x;
            Console.Write("x*8 = "+proizvedenie );
        }
    }
}
