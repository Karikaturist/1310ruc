/*2.	Напишете програма, която намира индекса на най-големия елемент в едномерен масив.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._2
{
    class Program42
    {
        static void Main(string[] args)
        {
            int i;
            int[] x = { 1, 2, 3, 9, 5, 6, 7, 8 };
            int max=0;
            try
            {
                for (i = 0; i < 8; i++)
                {
                    if (x[i] > x[i-1]) max = i;
                }
            }
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine("Индексът на най-големия елемент: " + max);
            }
            
                 
            }
    }
}
