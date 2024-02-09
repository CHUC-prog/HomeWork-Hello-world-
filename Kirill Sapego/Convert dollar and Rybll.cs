using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишите сколько долларов вы хотите перевести в рубли: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = 91.26; 
            double result =  b * a;
            Console.WriteLine(result + " Руб.");
            Console.Write("Желаете ли вы сделать обратную операцию?    Да или Нет: ");
            string str = Console.ReadLine();
            if (str == "Да")
            {
                Console.Write("Сколько вы хотите перевсти в доллоры: ");
                double Rubl = Convert.ToDouble(Console.ReadLine());
                double dollar = 91.26;
                double result2 = Rubl / dollar;
                Console.WriteLine(result2 + "$");
            } else if (str == "Нет")
            {
                Console.Write("Хорошего вам дня!");
            };
            
        }
    }
}
