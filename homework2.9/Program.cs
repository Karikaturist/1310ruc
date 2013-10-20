/* 9.	Да се напише програма, която изписва с думи въведена цифра. Да се използва операторът switch. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            string cifra;
            switch (Cifra)
            {
            case 1:
              Console.Write(cifra = "Едно");
                    break;
            case 2:
              Console.Write(cifra = "Две");
                    break;
            case 3:
              Console.Write(cifra = "Три");
                    break;
            case 4:
              Console.Write(cifra = "Четири");
                    break;
            case 5:
               Console.Write(cifra = "Пет");
                    break;
            case 6:
                Console.Write(cifra = "Шест");
                    break;
            case 7:
                Console.Write(cifra = "Седем");
                    break;
            case 8:
                Console.Write(cifra = "Осем");
                    break;
            case 9:
                Console.Write(cifra = "Девет");
                    break;
            case 0:
                Console.Write(cifra = "Нула");
                    break;
            default:
                Console.WriteLine("Въведете цифра!");
                    break;
                }
        }
        
    public static int Cifra { get; set; }}
    }


