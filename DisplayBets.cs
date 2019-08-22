using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LosingMoney
{
    public class DisplayBets
    {
        public static void Introduction()
        {
            Console.WriteLine("This app will let you pick a number between 0 and 36 (including 00).\nIt will then show you" +
                "all the possible bets that can win with the number you chose.");
        }
        public static void Display()
        {
            Console.Write("Type in a number between 0 and 36 now. For double zero type 37:  ");
            int pickedNumber = int.Parse(Console.ReadLine());
            if (pickedNumber > 37 && pickedNumber < 0)
                throw new NumberException("Number entered not within the specified range");
            if (pickedNumber == 37 || pickedNumber == 0)
            {
                Console.WriteLine("You can only win with these numbers if you choose this number and it lands exactly on these numbers.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Exact Number Bet");
                Console.ForegroundColor = ConsoleColor.White;
                Bets.ExactNumber();
                Thread.Sleep(900);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Even or Odd Bet");
                Console.ForegroundColor = ConsoleColor.White;
                Bets.EvenOrOdd(Bin.PopulateBoard(), pickedNumber);
                Thread.Sleep(900);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Red or Black Bet");
                Console.ForegroundColor = ConsoleColor.White;
                Bets.RedOrBlack(Bin.PopulateBoard(), pickedNumber);
                Thread.Sleep(900);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Low or High Bet");
                Console.ForegroundColor = ConsoleColor.White;
                Bets.LowOrHigh(Bin.PopulateBoard(), pickedNumber);
                Thread.Sleep(900);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dozens Bet");
                Console.ForegroundColor = ConsoleColor.White;
                Bets.Dozen(Bin.PopulateBoard(), pickedNumber);
                Thread.Sleep(900);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Column Bet");
                Console.ForegroundColor = ConsoleColor.White;
                Bets.Column(Bin.PopulateBoard(), pickedNumber);
                Thread.Sleep(900);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Street bet(Rows)");
                Console.ForegroundColor = ConsoleColor.White;
                Bets.Street(Bin.PopulateBoard(), pickedNumber);
                Thread.Sleep(900);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Double Rows");
                Console.ForegroundColor = ConsoleColor.White;
                Bets.DoubleRows(Bin.PopulateBoard(), pickedNumber);
                Thread.Sleep(900);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Corners");
                Console.ForegroundColor = ConsoleColor.White;
                Bets.Corners(Bin.PopulateBoard(), pickedNumber);
            }
        }
    }
}
