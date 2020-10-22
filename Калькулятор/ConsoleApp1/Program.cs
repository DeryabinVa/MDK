using Microsoft.VisualBasic;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           float num1 = 0; float num2 = 0;
            Console.WriteLine("Console Calculator in c#\r");
            Console.WriteLine("-------------------------\n");

            Console.WriteLine("Первое значени");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе значение");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Выберите действие:");
            Console.WriteLine("\ta - сочетание");
            Console.WriteLine("\ts-вычитание");
            Console.WriteLine("\tm-умножение");
            Console.WriteLine("\td-деление");
            Console.WriteLine("Какую опцию вы выберете?");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + { num2} =" + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($" Yuor result: {num1} - {num2} =" + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} =" + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result:{num1} / {num2}=" + (num1 / num2));
                    break;
            }
            Console.WriteLine("нажмите любую кнопку что-бы закрыть программу...");
            Console.ReadKey();
        }
    }
}
