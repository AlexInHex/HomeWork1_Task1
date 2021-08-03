using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation, NUM1, NUM2;
            double num1, num2;
            double res = 0;
            int numOperation;
            

            Console.WriteLine("Выберите математическую операцию:");
            Console.WriteLine("1 - Сложение");
            Console.WriteLine("2 - Вычитание");
            Console.WriteLine("3 - Умножение");
            Console.WriteLine("4 - Деление");
            Console.WriteLine("5 - Процент который составляет одно число от другого");
            Console.WriteLine("6 - квадратный корень введенного числа");
            operation = Console.ReadLine();

            bool parseResult = int.TryParse(operation, out numOperation);

            if (parseResult)
            {
                Console.WriteLine("Отлично!");
            }
            else
            {
                Console.WriteLine("Неверно введен номер операции.");
            }

            if (numOperation <= 5)
            {
                Console.WriteLine("Введите первое число");
                NUM1 = Console.ReadLine();
                bool parseResultNum1 = double.TryParse(NUM1, out num1);

                if (parseResultNum1)
                {
                    Console.WriteLine("Отличный выбор!");
                }
                else
                {
                    Console.WriteLine("Введите верное первое число");
                }

                Console.WriteLine("Введите второе число");
                NUM2 = Console.ReadLine();
                bool parseResultNum2 = double.TryParse(NUM2, out num2);

                if (parseResultNum1)
                {
                    Console.WriteLine("Прекрасно!");
                }
                else
                {
                    Console.WriteLine("Введите верное второе число");
                }


                if (numOperation == 1)
                {
                    res = num1 + num2;
                }
                else if (numOperation == 2)
                {
                    res = num1 - num2;
                }
                else if (numOperation == 3)
                {
                    res = num1 * num2;
                }
                else if (numOperation == 4)
                {
                    res = num1 / num2;
                }
                else
                {
                    res = num1 / num2 * 100;
                }

            }
            else
            {
                Console.WriteLine("Введите число");
                NUM1 = Console.ReadLine();
                bool parseResultNum1 = double.TryParse(NUM1, out num1);

                if (parseResultNum1)
                {
                    Console.WriteLine("Отличный выбор!");
                }
                else
                {
                    Console.WriteLine("Введите верное число");

                    res = Math.Sqrt(num1);
                }
            }

            Console.WriteLine("Результат операции = " + res);
        }
    }
}
