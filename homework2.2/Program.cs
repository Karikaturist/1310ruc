/* 2.	Да се напише програма, която пресмята лицето на трапец по дадени две основи и височина.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("h = ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            
            Console.WriteLine("(({0} + {1})/2)*{2} = {3}", a, b, h, ((a + b)/2)*h);
        
        }
    }
}
