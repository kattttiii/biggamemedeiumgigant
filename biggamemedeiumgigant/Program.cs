using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        public static int Case;
        public static int Num;
        static void Main()
        {
            Start();

            Case = Convert.ToInt32(Console.ReadLine());

            SelectedCase(Case);
        }

        public static void Start()
        {
            Console.WriteLine("1.Угадай число");
            Console.WriteLine("2.Таблица умножения");
            Console.WriteLine("3.Вывод делителей числа");
            Console.WriteLine("4.Закрыть программу");

            Console.WriteLine("Выберите действие");
        }

        public static void SelectedCase(int id)
        {
            switch (id)
            {
                case 1:
                    int r = new Random().Next(0, 100);

                    Console.WriteLine("Угадай число от 0 до 100!");
                    do
                    {
                        Num = Convert.ToInt32(Console.ReadLine());


                        if (Num < r) Console.WriteLine("Надо больше");
                        if (Num > r) Console.WriteLine("Надо меньше");
                    }
                    while (r != Num);

                    Console.WriteLine("Молодец");
                    Start();

                    Case = Convert.ToInt32(Console.ReadLine());

                    SelectedCase(Case);
                    break;
                case 2:
                    var table = new int[10, 10];
                    for (int a = 1; a < 10; ++a)
                    {
                        for (int j = 1; j < 10; ++j)
                        {
                            table[a, j] = a * j;
                        }
                    }
                    for (int a = 1; a < 10; ++a)
                    {
                        for (int j = 1; j < 10; ++j)
                        {
                            Console.Write("{0, 3}", table[j, a]);
                        }
                        Console.WriteLine();
                    }

                    Start();

                    Case = Convert.ToInt32(Console.ReadLine());

                    SelectedCase(Case);
                    break;
                case 3:
                    Console.WriteLine("Введите число:");
                    int k = Convert.ToInt32(Console.ReadLine());
                    for (int a = 1; a <= k; a++)
                    {
                        if (k % a == 0) Console.WriteLine("{0}", a);
                    }

                    Start();

                    Case = Convert.ToInt32(Console.ReadLine());

                    SelectedCase(Case);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Такого действия нет!!!");

                    Start();

                    Case = Convert.ToInt32(Console.ReadLine());

                    SelectedCase(Case);
                    break;
            }
        }
    }
}
