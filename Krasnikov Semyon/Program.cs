using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstvalue, twovalue;
            char operatorV;

            Console.WriteLine("Введите первое значение");
            firstvalue = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе значение");
            twovalue = Double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите метод операции + - / * ");
            operatorV = char.Parse(Console.ReadLine());
            double result = 0;
            switch (operatorV)
            {
                case '+':
                    result = firstvalue + twovalue;

                    break;

                case '-':
                    result = firstvalue - twovalue;
                    break;

                case '*':
                    result = firstvalue * twovalue;
                    break;

                case '/':
                    result = firstvalue / twovalue;
                    break;

                default:
                    Console.WriteLine("");
                    break;




            }
            Console.WriteLine(result);






















        }
    }
}
