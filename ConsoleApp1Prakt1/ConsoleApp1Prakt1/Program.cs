using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Prakt1
{
    class Program
    {
        static Class1 az = new Class1();

        static void Main(string[] args)
        {
            for (int z = 0; z < 10000; z++)
            {
                Console.WriteLine("1. Создать список.                     ");
                Console.WriteLine("2. Вывести список.                     ");
                Console.WriteLine("3. Очистить экран                      ");
                Console.WriteLine("4. Выйти из программы.                 ");
                Console.Write("Введите число от 1 до 4: ");
                int x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1: az.add(); break;
                    case 2: az.print(); break;
                    case 3: Console.Clear(); break;
                    case 4: Environment.Exit(0); break;
                    default: Console.WriteLine("ОШИБКА, введите числа от 1 до 4 !!!"); break;
                }
            }

            Console.ReadKey();
        }
    }
}
