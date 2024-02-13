using System;

namespace Convert_dollar_and_ruble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Какую валюты вы желаете конвертировать: введите валюты из списка \n  Доллара в Рубли \n  Рублей в Доллары \n Доллары в Юани \n  Юани в Рубли \n  Рублей в Юани \n Юани в Доллары \n Теньге \n");
            string vibor = Console.ReadLine();



            if (vibor == " Доллара в Рубли")
            {
                Console.Write("Напишите сколько долларов вы хотите перевести в рубли: ");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = 91.26;
                double result = b * a;
                Console.WriteLine(result + " Руб.");
            }
            else if (vibor == " Рублей в Доллары")
            {
                Console.Write("Сколько вы желаете перевести в доллоры: ");
                double Rubl = Convert.ToDouble(Console.ReadLine());
                double dollar = 91.26;
                double result2 = Rubl / dollar;
                Console.WriteLine(result2 + "$");
            }
            else if (vibor == " Юани в Рубли")
            {
                Console.Write("Сколько вы желате перевести из Юаней в Рубли: ");
                double CNY = Convert.ToDouble(Console.ReadLine());
                double rubl = 12.55;
                double result = rubl * CNY;
                Console.WriteLine(result);
            }
            else if (vibor == " Рублей в Юани")
            {
                Console.Write("Сколько вы желаете перевести из Рублей в Юани: ");
                double rubl = Convert.ToDouble(Console.ReadLine());
                double CNY = 12.55;
                double result = rubl / CNY;
                Console.WriteLine(result);
            }
            else if (vibor == " Долларов в Юани ")
            {
                Console.Write("Сколько вы желаете перевести из Долларов в Юани");
                double dollar = Convert.ToDouble(Console.ReadLine());
                double CNY = 7.26;
                double result = dollar * CNY;
                Console.WriteLine(result);
            }
            else if (vibor == "Юани в Доллары")
            {
                Console.Write("Сколько вы желаете перевести из Юаней в доллары: ");
                double CNY = Convert.ToDouble(Console.ReadLine());
                double dollar = 0.137826;
                double result = CNY * dollar;
                Console.WriteLine(result);
            }
           

            
        }
    }
}
