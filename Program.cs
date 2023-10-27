using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal class Program
    {

        static void Main(string[] args)
        {

            var calculator = new Calculator();
            calculator.EventResult += C_EventResult;
            float result = 0;
            bool a = true;
            int num;
            while (a)
            {
                Console.WriteLine("1 - операция +");
                Console.WriteLine("2 - операция -");
                Console.WriteLine("3 - операция /");
                Console.WriteLine("4 - операция *");
                Console.WriteLine("5 - отмены последней операции");
                Console.WriteLine("6 - выход");
                Console.Write("Ввод: ");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Write("Введите число: ");
                        num = int.Parse(Console.ReadLine());
                        result = calculator.Add(num);
                        break;
                    case "2":
                        Console.Write("Введите число: ");
                        num = int.Parse(Console.ReadLine());
                        result = calculator.Sub(num);
                        break;
                    case "3":
                        Console.Write("Введите число: ");
                        num = int.Parse(Console.ReadLine());
                        if (num == 0)
                        {
                            Console.WriteLine("Ошибка! На ноль делить нельзя!");
                            break;
                        }
                        result = calculator.Div(num);
                        break;
                    case "4":
                        Console.Write("Введите число: ");
                        num = int.Parse(Console.ReadLine());
                        result = calculator.Mul(num);
                        break;
                    case "5":
                        Console.WriteLine("Отмена последней операции");
                        calculator.CancelLast();
                        break;
                    case "6":
                        Console.WriteLine("Выход");
                        a = false;
                        break;
                    default:
                        Console.WriteLine("Некорректная операция. Программа завершена.");
                        break;
                }
            }
        }

        private static void C_EventResult(object sender, EventArgs e)
        {
            Console.WriteLine(((Calculator)sender).result);
        }
    }
}
