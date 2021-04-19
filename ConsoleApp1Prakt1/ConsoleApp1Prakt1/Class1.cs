using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        static Class1[] a = new Class1[1000];
        static int n;

        public string nazvanie { get; set; }
        public float kalibr { get; set; }
        public double dalnost { get; set; }

        internal void add()
        {
            Console.WriteLine();
            Console.Write("Введите кол-во записей: ");
            n = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] = new Class1();
                Console.Write("Название: ");
                a[i].nazvanie = Console.ReadLine();
                Console.Write("Калибр: ");
                a[i].kalibr = Convert.ToSingle(Console.ReadLine());
                Console.Write("Дальность: ");
                a[i].dalnost = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
            }
        }

        internal void print()
        {
            Console.WriteLine();
            Console.WriteLine("Список стрелковых оружий:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Название:" + a[i].nazvanie);
                Console.WriteLine("Калибр:" + a[i].kalibr);
                Console.WriteLine("Дальность:" + a[i].dalnost);

            }
            Console.WriteLine();
        }
    }
}
