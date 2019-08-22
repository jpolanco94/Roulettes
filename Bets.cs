using System;
using System.Collections.Generic;
using System.Text;

namespace LosingMoney
{
    public class Bets
    {
        public static void Corners(Bin[] binsArray, int luckyBin)
        {
            if (binsArray[luckyBin].column == 3 && binsArray[luckyBin].number != 3 && binsArray[luckyBin].number != 36)
            {
                Console.WriteLine($"The possible corner bets for {binsArray[luckyBin].number} are " +
                    $"{binsArray[luckyBin - 4].number}, {binsArray[luckyBin - 3].number}, {binsArray[luckyBin - 1].number}" +
                    $", {binsArray[luckyBin].number} and {binsArray[luckyBin - 1].number}, {binsArray[luckyBin].number}," +
                    $" {binsArray[luckyBin + 2].number}, {binsArray[luckyBin + 3].number}");
            }
            if (binsArray[luckyBin].column == 1 && binsArray[luckyBin].number != 1 && binsArray[luckyBin].number != 34)
            {
                Console.WriteLine($"The possible corner bets for {binsArray[luckyBin].number} are " +
                    $"{binsArray[luckyBin].number}, {binsArray[luckyBin + 1].number}, {binsArray[luckyBin + 2].number}" +
                    $", {binsArray[luckyBin + 3].number} and {binsArray[luckyBin - 3].number}, {binsArray[luckyBin - 2].number}," +
                    $" {binsArray[luckyBin - 1].number}, {binsArray[luckyBin].number}");
            }
            if (binsArray[luckyBin].number == 1)
            {
                Console.WriteLine($"The possible corner bets for {binsArray[luckyBin].number} are " +
                    $"{binsArray[luckyBin].number}, {binsArray[luckyBin + 1].number}, {binsArray[luckyBin + 3].number}" +
                    $", {binsArray[luckyBin + 4].number}");
            }
            if (binsArray[luckyBin].number == 3)
            {
                Console.WriteLine($"The possible corner bets for {binsArray[luckyBin].number} are " +
                    $"{binsArray[luckyBin - 1].number}, {binsArray[luckyBin].number}, {binsArray[luckyBin + 2].number}" +
                    $", {binsArray[luckyBin + 3].number}");
            }
            if (binsArray[luckyBin].number == 36)
            {
                Console.WriteLine($"The possible corner bets for {binsArray[luckyBin].number} are " +
                    $"{binsArray[luckyBin - 4].number}, {binsArray[luckyBin - 3].number}, {binsArray[luckyBin - 1].number}" +
                    $", {binsArray[luckyBin].number}");
            }
            if (binsArray[luckyBin].number == 34)
            {
                Console.WriteLine($"The possible corner bets for {binsArray[luckyBin].number} are " +
                    $"{binsArray[luckyBin - 3].number}, {binsArray[luckyBin - 2].number}, {binsArray[luckyBin].number}" +
                    $", {binsArray[luckyBin + 1].number}");
            }
            if (binsArray[luckyBin].column == 2 && binsArray[luckyBin].row != 1 && binsArray[luckyBin].row != 12)
            {
                Console.WriteLine($"The possible corner bets for {binsArray[luckyBin].number} are " +
                    $"{binsArray[luckyBin - 4].number}, {binsArray[luckyBin - 3].number}, {binsArray[luckyBin - 1].number}" +
                    $", {binsArray[luckyBin].number} and {binsArray[luckyBin - 3].number}, {binsArray[luckyBin - 2].number}" +
                    $", {binsArray[luckyBin].number}, {binsArray[luckyBin + 1].number} and {binsArray[luckyBin - 1].number}" +
                    $", {binsArray[luckyBin].number}, {binsArray[luckyBin + 2].number}, {binsArray[luckyBin + 3].number}" +
                    $" and {binsArray[luckyBin].number}, {binsArray[luckyBin + 1].number}, {binsArray[luckyBin + 3].number}" +
                    $", {binsArray[luckyBin + 4].number}");
            }
            if (binsArray[luckyBin].number == 2)
            {
                Console.WriteLine($"The possible corner bets for {binsArray[luckyBin].number} are " +
                    $"{binsArray[luckyBin - 1].number}, {binsArray[luckyBin].number}, {binsArray[luckyBin + 2].number}" +
                    $", {binsArray[luckyBin + 3].number} and {binsArray[luckyBin].number}, {binsArray[luckyBin + 1].number}" +
                    $", {binsArray[luckyBin + 3].number}, {binsArray[luckyBin + 4].number}");
            }
            if (binsArray[luckyBin].number == 35)
            {
                Console.WriteLine($"The possible corner bets for {binsArray[luckyBin].number} are " +
                    $"{binsArray[luckyBin - 4].number}, {binsArray[luckyBin - 3].number}, {binsArray[luckyBin - 1].number}" +
                    $", {binsArray[luckyBin].number} and {binsArray[luckyBin - 3].number}, {binsArray[luckyBin - 1].number}" +
                    $", {binsArray[luckyBin].number}, {binsArray[luckyBin + 1].number}");
            }
        }
        public static void DoubleRows(Bin[] binsArray, int luckyBin)
        {
            if (binsArray[luckyBin].row == 1)
            {
                Console.WriteLine($"The possible double row bets for {binsArray[luckyBin].number} are " +
                    $"{binsArray[1].number}, {binsArray[2].number}, {binsArray[3].number}, {binsArray[4].number}, " +
                    $"{binsArray[5].number}, {binsArray[6].number}");
            }
            if (binsArray[luckyBin].row == 12)
            {
                Console.WriteLine($"The possible double row bets for {binsArray[luckyBin].number} are " +
                    $"{binsArray[31].number}, {binsArray[32].number}, {binsArray[33].number}, {binsArray[34].number}, " +
                    $"{binsArray[35].number}, {binsArray[36].number}");
            }
            if (binsArray[luckyBin].row == 2)
            {
                Console.WriteLine($"The possible double row bets for {binsArray[luckyBin].number} are " +
               $"{binsArray[1].number}, {binsArray[2].number}, {binsArray[3].number}, {binsArray[4].number}, " +
               $"{binsArray[5].number}, {binsArray[6].number} and {binsArray[4].number}, {binsArray[5].number}, " +
               $"{binsArray[6].number}, {binsArray[7].number}, {binsArray[8].number}, {binsArray[9].number} ");
            }
            if (binsArray[luckyBin].row == 3)
            {
                Console.WriteLine($"The possible double row bets for {binsArray[luckyBin].number} are " +
               $"{binsArray[4].number}, {binsArray[5].number}, {binsArray[6].number}, {binsArray[7].number}, " +
               $"{binsArray[8].number}, {binsArray[9].number} and {binsArray[7].number}, {binsArray[8].number}, " +
               $"{binsArray[9].number}, {binsArray[10].number}, {binsArray[11].number}, {binsArray[12].number} ");
            }
            if (binsArray[luckyBin].row == 4)
            {
                Console.WriteLine($"The possible double row bets for {binsArray[luckyBin].number} are " +
               $"{binsArray[7].number}, {binsArray[8].number}, {binsArray[9].number}, {binsArray[10].number}, " +
               $"{binsArray[11].number}, {binsArray[12].number} and {binsArray[10].number}, {binsArray[11].number}, " +
               $"{binsArray[12].number}, {binsArray[13].number}, {binsArray[14].number}, {binsArray[15].number} ");
            }
            if (binsArray[luckyBin].row == 5)
            {
                Console.WriteLine($"The possible double row bets for {binsArray[luckyBin].number} are " +
               $"{binsArray[10].number}, {binsArray[11].number}, {binsArray[12].number}, {binsArray[13].number}, " +
               $"{binsArray[14].number}, {binsArray[15].number} and {binsArray[13].number}, {binsArray[14].number}, " +
               $"{binsArray[15].number}, {binsArray[16].number}, {binsArray[17].number}, {binsArray[18].number} ");
            }
            if (binsArray[luckyBin].row == 6)
            {
                Console.WriteLine($"The possible double row bets for {binsArray[luckyBin].number} are " +
               $"{binsArray[13].number}, {binsArray[14].number}, {binsArray[15].number}, {binsArray[16].number}, " +
               $"{binsArray[17].number}, {binsArray[18].number} and {binsArray[16].number}, {binsArray[17].number}, " +
               $"{binsArray[18].number}, {binsArray[19].number}, {binsArray[20].number}, {binsArray[21].number} ");
            }
            if (binsArray[luckyBin].row == 7)
            {
                Console.WriteLine($"The possible double row bets for {binsArray[luckyBin].number} are " +
               $"{binsArray[16].number}, {binsArray[17].number}, {binsArray[18].number}, {binsArray[19].number}, " +
               $"{binsArray[20].number}, {binsArray[21].number} and {binsArray[19].number}, {binsArray[20].number}, " +
               $"{binsArray[21].number}, {binsArray[22].number}, {binsArray[23].number}, {binsArray[24].number} ");
            }
            if (binsArray[luckyBin].row == 8)
            {
                Console.WriteLine($"The possible double row bets for {binsArray[luckyBin].number} are " +
               $"{binsArray[19].number}, {binsArray[20].number}, {binsArray[21].number}, {binsArray[22].number}, " +
               $"{binsArray[23].number}, {binsArray[24].number} and {binsArray[22].number}, {binsArray[23].number}, " +
               $"{binsArray[24].number}, {binsArray[25].number}, {binsArray[26].number}, {binsArray[27].number} ");
            }
            if (binsArray[luckyBin].row == 9)
            {
                Console.WriteLine($"The possible double row bets for {binsArray[luckyBin].number} are " +
               $"{binsArray[22].number}, {binsArray[23].number}, {binsArray[24].number}, {binsArray[25].number}, " +
               $"{binsArray[26].number}, {binsArray[27].number} and {binsArray[25].number}, {binsArray[26].number}, " +
               $"{binsArray[27].number}, {binsArray[28].number}, {binsArray[29].number}, {binsArray[30].number} ");
            }
            if (binsArray[luckyBin].row == 10)
            {
                Console.WriteLine($"The possible double row bets for {binsArray[luckyBin].number} are " +
               $"{binsArray[25].number}, {binsArray[26].number}, {binsArray[27].number}, {binsArray[28].number}, " +
               $"{binsArray[29].number}, {binsArray[30].number} and {binsArray[28].number}, {binsArray[29].number}, " +
               $"{binsArray[30].number}, {binsArray[31].number}, {binsArray[32].number}, {binsArray[33].number} ");
            }
            if (binsArray[luckyBin].row == 11)
            {
                Console.WriteLine($"The possible double row bets for {binsArray[luckyBin].number} are " +
               $"{binsArray[28].number}, {binsArray[29].number}, {binsArray[30].number}, {binsArray[31].number}, " +
               $"{binsArray[32].number}, {binsArray[33].number} and {binsArray[31].number}, {binsArray[32].number}, " +
               $"{binsArray[33].number}, {binsArray[34].number}, {binsArray[35].number}, {binsArray[36].number} ");
            }
        }
        public static void Splits(Bin[] binsArray, int luckyBin)
        {
            if (binsArray[luckyBin].number == 3)
            {
                Console.WriteLine($"The possible split bets for {binsArray[luckyBin].number} are" +
                    $" {binsArray[luckyBin - 1].number}, {binsArray[luckyBin].number} and {binsArray[luckyBin].number}, " +
                    $"{binsArray[luckyBin + 3].number}");
            }
            if (binsArray[luckyBin].number == 1)
            {
                Console.WriteLine($"The possible split bets for {binsArray[luckyBin].number} are" +
                    $" {binsArray[luckyBin].number}, {binsArray[luckyBin + 1].number} and {binsArray[luckyBin].number}, " +
                    $"{binsArray[luckyBin + 3].number}");
            }
            if (binsArray[luckyBin].number == 36)
            {
                Console.WriteLine($"The possible split bets for {binsArray[luckyBin].number} are" +
                    $" {binsArray[luckyBin - 3].number}, {binsArray[luckyBin].number} and {binsArray[luckyBin - 1].number}, " +
                    $"{binsArray[luckyBin].number}");
            }
            if (binsArray[luckyBin].number == 34)
            {
                Console.WriteLine($"The possible split bets for {binsArray[luckyBin].number} are" +
                    $" {binsArray[luckyBin - 3].number}, {binsArray[luckyBin].number} and {binsArray[luckyBin].number}, " +
                    $"{binsArray[luckyBin + 1].number}");
            }
            if (binsArray[luckyBin].number == 2)
            {
                Console.WriteLine($"The possible split bets for {binsArray[luckyBin].number} are" +
                    $" {binsArray[luckyBin - 1].number}, {binsArray[luckyBin].number} and {binsArray[luckyBin].number}, " +
                    $"{binsArray[luckyBin + 1].number} and {binsArray[luckyBin].number}, {binsArray[luckyBin + 3].number}");
            }
            if (binsArray[luckyBin].number == 35)
            {
                Console.WriteLine($"The possible split bets for {binsArray[luckyBin].number} are" +
                    $" {binsArray[luckyBin - 1].number}, {binsArray[luckyBin].number} and {binsArray[luckyBin].number}, " +
                    $"{binsArray[luckyBin + 1].number} and {binsArray[luckyBin].number}, {binsArray[luckyBin - 3].number}");
            }
            if (binsArray[luckyBin].column == 1 && binsArray[luckyBin].number != 1 && binsArray[luckyBin].number != 34)
            {
                Console.WriteLine($"The possible split bets for {binsArray[luckyBin].number} are" +
                    $" {binsArray[luckyBin - 3].number}, {binsArray[luckyBin].number} and {binsArray[luckyBin].number}" +
                    $", {binsArray[luckyBin + 1].number} and {binsArray[luckyBin].number}" +
                    $", {binsArray[luckyBin + 3].number}");
            }
            if (binsArray[luckyBin].column == 3 && binsArray[luckyBin].number != 3 && binsArray[luckyBin].number != 36)
            {
                Console.WriteLine($"The possible split bets for {binsArray[luckyBin].number} are" +
                    $" {binsArray[luckyBin - 3].number}, {binsArray[luckyBin].number} and {binsArray[luckyBin - 1].number}" +
                    $", {binsArray[luckyBin].number} and {binsArray[luckyBin].number}" +
                    $", {binsArray[luckyBin + 3].number}");
            }
            if (binsArray[luckyBin].column == 2 && binsArray[luckyBin].number != 2 && binsArray[luckyBin].number != 35)
            {
                Console.WriteLine($"The possible split bets for {binsArray[luckyBin].number} are" +
                    $" {binsArray[luckyBin - 3].number}, {binsArray[luckyBin].number} and {binsArray[luckyBin - 1].number}" +
                    $", {binsArray[luckyBin].number} and {binsArray[luckyBin].number}" +
                    $", {binsArray[luckyBin + 1].number} and {binsArray[luckyBin].number}, {binsArray[luckyBin + 3].number}");
            }
        }
        public static void Street(Bin[] binsArray, int luckyBin)
        {
            if (binsArray[luckyBin].column == 1)
            {
                Console.WriteLine($"The possible street bets for {binsArray[luckyBin].number} are" +
                    $" {binsArray[luckyBin].number}, {binsArray[luckyBin + 1].number}, {binsArray[luckyBin + 2].number}");
            }
            if (binsArray[luckyBin].column == 2)
            {
                Console.WriteLine($"The possible street bets for {binsArray[luckyBin].number} are" +
                    $" {binsArray[luckyBin - 1].number}, {binsArray[luckyBin].number}, {binsArray[luckyBin + 1].number}");
            }
            if (binsArray[luckyBin].column == 3)
            {
                Console.WriteLine($"The possible street bets for {binsArray[luckyBin].number} are" +
                    $" {binsArray[luckyBin - 2].number}, {binsArray[luckyBin - 1].number}, {binsArray[luckyBin].number}");
            }

        }
        public static void EvenOrOdd(Bin[] binsArray, int luckyBin)
        {
            if (binsArray[luckyBin].number % 2 == 0)
            {
                Console.Write($"{binsArray[luckyBin].number} is even. The following numbers will also win" +
                    $" in an even bet: ");
                for (int i = 1; i < binsArray.Length - 1; i++)
                {
                    if (binsArray[i].number % 2 == 0)
                    {
                        Console.Write(binsArray[i].number + " ");
                    }
                }
            }
            if (binsArray[luckyBin].number % 2 == 1)
            {
                Console.Write($"{binsArray[luckyBin].number} is odd. The following numbers will also win" +
                    $" in an odd bet: ");
                for (int i = 1; i < binsArray.Length - 1; i++)
                {
                    if (binsArray[i].number % 2 == 1)
                    {
                        Console.Write(binsArray[i].number + " ");
                    }
                }
            }
            Console.Write("\n");
        }
        public static void RedOrBlack(Bin[] binsArray, int luckyBin)
        {
            if (binsArray[luckyBin].color == "black")
            {
                Console.Write($"{binsArray[luckyBin].number} is black. The following numbers will also win" +
                    $" in a black bet: ");
                for (int i = 1; i < binsArray.Length - 1; i++)
                {
                    if (binsArray[i].color == "black")
                    {
                        Console.Write(binsArray[i].number + " ");
                    }
                }
            }
            if (binsArray[luckyBin].color == "red")
            {
                Console.Write($"{binsArray[luckyBin].number} is red. The following numbers will also win" +
                    $" in a red bet: ");
                for (int i = 1; i < binsArray.Length - 1; i++)
                {
                    if (binsArray[i].color == "red")
                    {
                        Console.Write(binsArray[i].number + " ");
                    }
                }
            }
            Console.Write("\n");

        }
        public static void LowOrHigh(Bin[] binsArray, int luckyBin)
        {
            if (binsArray[luckyBin].number <= 18)
            {
                Console.Write($"{binsArray[luckyBin].number} is a low number. The following numbers will also win" +
                    $" in a low bet: ");
                for (int i = 1; i < binsArray.Length - 1; i++)
                {
                    if (binsArray[i].number >= 1 && binsArray[i].number <= 18)
                    {
                        Console.Write(binsArray[i].number + " ");
                    }
                }
            }
            if (binsArray[luckyBin].number > 18)
            {
                Console.Write($"{binsArray[luckyBin].number} is a high number. The following numbers will also win" +
                    $" in a high bet: ");
                for (int i = 1; i < binsArray.Length - 1; i++)
                {
                    if (binsArray[i].number > 18)
                    {
                        Console.Write(binsArray[i].number + " ");
                    }
                }
            }
            Console.Write("\n");

        }
        public static void Column(Bin[] binsarray, int luckyBin)
        {
            if (binsarray[luckyBin].column == 1)
            {
                Console.Write($"{binsarray[luckyBin].number} is in column one. The following numbers will also" +
                    $" in in a column one bet:  ");
                for (int i = 0; i < binsarray.Length - 1; i++)
                {
                    if (binsarray[i].column == 1)
                    {
                        Console.Write(binsarray[i].number + " ");
                    } 
                }
                Console.Write("\n");
                
            }
            if (binsarray[luckyBin].column == 2)
            {
                Console.Write($"{binsarray[luckyBin].number} is in column two. The following numbers will also" +
                    $" in in a column two bet:  ");
                for (int i = 0; i < binsarray.Length - 1; i++)
                {
                    if (binsarray[i].column == 2)
                    {
                        Console.Write(binsarray[i].number + " ");
                    }
                }
                Console.Write("\n");
            }
            if (binsarray[luckyBin].column == 3)
            {
                Console.Write($"{binsarray[luckyBin].number} is in column three. The following numbers will also" +
                    $" in in a column three bet:  ");
                for (int i = 0; i < binsarray.Length - 1; i++)
                {
                    if (binsarray[i].column == 3)
                    {
                        Console.Write(binsarray[i].number + " ");
                    }
                }
                Console.Write("\n");
            }
        }
        public static void Dozen(Bin[] binsarray, int luckyBin)
        {
            if (binsarray[luckyBin].number >= 1 && binsarray[luckyBin].number <=12)
            {
                Console.Write($"{binsarray[luckyBin].number} is a low dozens bet. The following numbers are also " +
                    $"found in a low dozens bet: ");
                for(int i = 1; i <= binsarray.Length / 3; i ++)
                {
                    if(binsarray[i].number >= 1 && binsarray[i].number <= 12)
                    {
                        Console.Write(binsarray[i].number + " ");
                    }
                }
                Console.Write("\n");
            }
            if (binsarray[luckyBin].number >= 13 && binsarray[luckyBin].number <= 24)
            {
                Console.Write($"{binsarray[luckyBin].number} is a middle dozens bet. The following numbers are also " +
                    $"found in a middle dozens bet: ");
                for (int i = 1; i <= binsarray.Length - 1 ; i++)
                {
                    if (binsarray[i].number >= 13 && binsarray[i].number <= 24)
                    {
                        Console.Write(binsarray[i].number + " ");
                    }
                }
                Console.Write("\n");
            }
            if (binsarray[luckyBin].number >= 25 && binsarray[luckyBin].number <= 36)
            {
                Console.Write($"{binsarray[luckyBin].number} is a high dozens bet. The following numbers are also " +
                    $"found in a high dozens bet:\n  ");
                for (int i = 1; i <= binsarray.Length - 1; i++)
                {
                    if (binsarray[i].number >= 25 && binsarray[i].number <= 36)
                    {
                        Console.Write(binsarray[i].number + " ");
                    }
                }
                Console.Write("\n");
            }
        }
        public static void ExactNumber()
        {
            Console.WriteLine("This bet has the lowest chance of winning. Your guess must equal the exact bin");
        }
    }
}
