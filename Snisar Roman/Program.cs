using System;
using System.Threading.Channels;

namespace kasino777
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Добро пожаловать в казино ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("TopIntim74");
            Console.ResetColor();
            Random random = new Random();
            double balance = 0;
            double deposit = 0;
            string promo;
            string button = "+";
            while (button != "-")
            {
                Console.WriteLine("\nМеню:\nИгры: 1\nБаланс: 2\nДепнуть: 3\nПромики: 4\nВыход: -");
                button = Console.ReadLine();
                switch (button)
                {
                    case "1":
                        Console.WriteLine("Игры, которые есть: \nблек джек: 1\nугадай цифру(1 из 5 или 1 из 10): 2");
                        string game = Console.ReadLine();
                        switch (game)
                        {
                            case "1":
                                Console.WriteLine("игра: блек джек");
                                Console.WriteLine("Бля у меня не получилось");
                                break;

                            case "2":
                                Console.WriteLine("Угадай цифру\n");
                                Console.WriteLine("1 из 5(x5): 1\n1 из 10(x10): 2");
                                string game2 = Console.ReadLine();
                                switch (game2)
                                {
                                    case "1":
                                        string stopGame2 = "+";
                                        while (stopGame2 != "-")
                                        {
                                            if (balance > 0)
                                            {
                                                Console.WriteLine("Ставка: ");
                                                int betGame2 = int.Parse(Console.ReadLine());
                                                balance -= betGame2; 
                                                int number1 = random.Next(1, 5);
                                                Console.Write("\nЗагаданно число от 1 до 5, введите число: ");
                                                int num1 = int.Parse(Console.ReadLine());
                                                if (num1 == number1)
                                                {
                                                    Console.WriteLine($"выйграл норм, число было: {number1}");
                                                    betGame2 *= 5;
                                                    balance += betGame2;
                                                    Console.WriteLine($"Баланс: {balance}");
                                                }
                                                else if (num1 > 5 || num1 < 0)
                                                {
                                                    Console.WriteLine("ауууууу чё ты пишешь такого числа не может быть");
                                                    balance += betGame2;
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"Ты проиграл, число было: {number1}");
                                                    Console.WriteLine($"Баланс: {balance}");
                                                }
                                                Console.WriteLine("Если выход то: -\nесли продолжить то: enter");
                                                stopGame2 = Console.ReadLine();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Тебе не хватает, братишка, иди депни последние деньги");
                                                stopGame2 = "-";
                                            }
                                        }
                                        break;

                                    case "2":
                                        string stop2Game2 = "+";
                                        while (stop2Game2 != "-")
                                        {
                                            if (balance > 0)
                                            {
                                                Console.WriteLine("Ставка: ");
                                                int betGame2 = int.Parse(Console.ReadLine());
                                                balance -= betGame2;
                                                int number1 = random.Next(1, 10);
                                                Console.Write("\nЗагаданно число от 1 до 10, введите число: ");
                                                int num1 = int.Parse(Console.ReadLine());
                                                if (num1 == number1)
                                                {
                                                    Console.WriteLine($"выйграл норм, число было: {number1}");
                                                    betGame2 *= 10;
                                                    balance += betGame2;
                                                    Console.WriteLine($"Баланс: {balance}");
                                                }
                                                else if (num1 > 10 || num1 < 0)
                                                {
                                                    Console.WriteLine("ауууууу чё ты пишешь такого числа не может быть");
                                                    balance += betGame2;
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"Ты проиграл, число было: {number1}");
                                                    Console.WriteLine($"Баланс: {balance}");
                                                }
                                                Console.WriteLine("Если выход то: -\nесли продолжить то: enter");
                                                stop2Game2 = Console.ReadLine();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Тебе не хватает, братишка, иди депни последние деньги");
                                                stop2Game2 = "-";
                                            }
                                        }
                                        break;

                                }
                                break;

                            case "3":
                                Console.WriteLine(  );
                                break;
                        }
                        break;

                    case "2":
                        Console.WriteLine($"Ваш баланс: {balance}");
                        if (balance == 0)
                        {
                            Console.WriteLine("Вы можете пополнить баланс командой 3(Депнуть) ");
                        }
                        break;

                    case "3":
                        while (deposit < 500) 
                        {
                            Console.Write("Введите сумму для депозита(минимум 500р): ");
                            deposit = double.Parse(Console.ReadLine());
                            if (deposit < 500)
                            {
                                Console.WriteLine("аууу минимум 500р");
                                deposit = 0;
                            }

                        }
                        Console.Write("Промокод(если есть): ");
                        promo = Console.ReadLine();
                        if (promo == "YaProstitutka")
                        {
                            deposit += deposit * 0.5;
                        }
                        else if (promo == "AristovLox")
                        {
                            deposit += deposit * 2;
                        }
                        Console.WriteLine($"Вы пополнили баланс на {deposit}");
                        balance += deposit;
                        deposit = 0;
                        Console.WriteLine($"Ваш баланс: {balance}");
                        break;

                    case "4":
                        Console.Write("Промокоды: \nYaProstitutka = 50% к депозиту\nAristovLox = 200% к депозиту");
                        break;

                    case "-":
                        Console.WriteLine("Выход...");
                        button = "-";
                        break;
                }

            }
        }
    }
}