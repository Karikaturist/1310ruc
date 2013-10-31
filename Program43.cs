/*3.	Да се напише програма, която сортира елементите на масив във възходящ ред.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._3
{
    class Program43
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 6, 9, 4, 3, 5, 1, 42, -2 };
            for (int i = 0; i < x.Length - 1; i++)
            {
                for (int j = 0; j < x.Length - 1; j++)
                {
                    if (x[j] > x[j + 1]) // swap the elements
                    {
                        int buffer = x[j];
                        x[j] = x[j + 1];
                        x[j + 1] = buffer;
                    }
                }
            }
            for (int i = 0; i < x.Length; i++) // print the elements
            {
                Console.Write(x[i] + " ");
            }
        }
    }
}
