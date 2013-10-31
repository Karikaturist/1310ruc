/*1.	Да се напише програма, която намира сумата на елементите на едномерен масив*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._1
{
    class Program41
    {
        static void Main(string[] args)
        {
            int i;
            int[] x = new int [] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int sum=0;
            for (i = 0; i < 8; i++)
            {
                sum += x[i];
            }
            Console.WriteLine("Сумата от елементите на масива е: "+sum );
        }
    }
}
