using System;

namespace калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пременная 1(целое число)
            int num1 = 15;
            //Переменная 2(с плавоющей запятой с двойной точностью)
            double num2 = 65;
            //Переменная 3(постоянная с плавоющей запятой с двойной точностью)
            const double PI = 3.14;
            // Арифметическая функция-сложения
            Console.WriteLine(num1 + num2);
            //Результат
            //outputs
            // Арифметическая функция-вычитание
            Console.WriteLine(num1 - num2);
            //Результат
            //output
            //Арифметическая функция-умножение
            Console.WriteLine(num1 * num2);
            //Результат
            //output
            //Арифметическая функция-деление
            Console.WriteLine(num1 / num2);
           //Результат
            //output
            //Арифмеическая функция-проценты
            Console.WriteLine(num1 % num2);
            //Результат
            //output
            // Сложная арифметическая функция-деление целого числа на постоянную; сложение целого числа с постоянной; вычитание получившихся результатовю
            Console.WriteLine(PI + num2 - num1/PI);
            //Результат
            //output
        }

    }
}
