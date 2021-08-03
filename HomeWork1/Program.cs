using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation, NUM1, NUM2;
            double num1, num2;

            Console.WriteLine("Выберите математическую операцию:");
            Console.WriteLine("1 - Сложение");
            Console.WriteLine("2 - Вычитание");
            Console.WriteLine("3 - Умножение");
            Console.WriteLine("4 - Деление");
            Console.WriteLine("5 - Процент который составляет одно число от другого");
            Console.WriteLine("6 - квадратный корень");
            operation = Console.ReadLine();

            Console.WriteLine("Введите первое число");
            NUM1 = Console.ReadLine();

            Console.WriteLine("Введите второе число");
            NUM2 = Console.ReadLine();

        }
    }
}
