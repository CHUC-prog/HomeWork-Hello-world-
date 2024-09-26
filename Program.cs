using System;
    namespace ConsoleApp1
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Игра: 'Русская рулетка'");
            Console.ReadKey();
            Random shot = new Random();
            int a = shot.Next(1,6);
            for (int i = 1; i < 6; i++) 
            {
                if (i == shot.Next (1,6))
                {
                    Console.WriteLine("YOU DIED");
                    break;
                }
                else
                {
                    Console.WriteLine("Да ты везунчик");
                    Console.ReadKey();
                }
            }
        }
    }
}