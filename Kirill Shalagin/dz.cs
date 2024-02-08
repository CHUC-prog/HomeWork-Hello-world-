using System.Diagnostics;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Давай сыграем с тобой в игру\nрусская рулетка\nкрути барабан");
            int UnHumanityRnd = rnd.Next(1, 10);
            for (int i = 1; i < 4; i++)
            {
                int a = rnd.Next(1, 6);
                int b = Convert.ToInt32(Console.ReadLine());
                if (a == b)
                {
                    Console.WriteLine("Ты проиграл");
                    for (int i2 = 0; i2 < UnHumanityRnd; i2++)
                    {
                        Process.Start(new ProcessStartInfo("https://www.youtube.com/watch?v=GRoI1s6R1pc") { UseShellExecute = true });
                    }
                    Environment.Exit(0);
                }
                else if (b >= 7)
                {
                    Console.WriteLine("ЗДЕСЬ ЦЫФРЫ БОЛЬШЕ 6 ЗАПРЕЩЕНЫ, FAGGOT!");
                }
                else
                {
                    Console.WriteLine("ЕЩЁ РАЗ");
                }
            }
        }
    }
}
