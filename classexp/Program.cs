using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            PlayerModel p1 = new PlayerModel();
            p1.Name = "Daniel";
            p1.Print(PrintPlayerName, p1);
            p1.Print(PrintPlayerId, p1);

            Console.ReadKey();

        }

        private static void PrintPlayerName(PlayerModel pl)
        {
            Console.WriteLine($"player name is: {pl.Name}");
        }
        private static void PrintPlayerId(PlayerModel pl)
        {
            Console.WriteLine($"player name is: {pl.Name}");
            Console.WriteLine($"player id is: {pl.Id}");
        }
    }
}