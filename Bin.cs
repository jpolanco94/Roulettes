using System;
using System.Collections.Generic;
using System.Text;

namespace LosingMoney
{
    public class Bin
    {
        public int number;
        public int row;
        public int column;
        public string color;
        public static Bin[] PopulateBoard()
        {
            Bin bin0 = new Bin { number = 0 };
            Bin bin00 = new Bin { number = 00 };
            Bin bin1 = new Bin { number = 1, color = "red", row = 1, column = 1 };
            Bin bin2 = new Bin { number = 2, color = "black", row = 1, column = 2 };
            Bin bin3 = new Bin { number = 3, color = "red", row = 1, column = 3 };
            Bin bin4 = new Bin { number = 4, color = "black", row = 2, column = 1 };
            Bin bin5 = new Bin { number = 5, color = "red", row = 2, column = 2 };
            Bin bin6 = new Bin { number = 6, color = "black", row = 2, column = 3 };
            Bin bin7 = new Bin { number = 7, color = "red", row = 3, column = 1 };
            Bin bin8 = new Bin { number = 8, color = "black", row = 3, column = 2 };
            Bin bin9 = new Bin { number = 9, color = "red", row = 3, column = 3 };
            Bin bin10 = new Bin { number = 10, color = "black", row = 4, column = 1 };
            Bin bin11 = new Bin { number = 11, color = "black", row = 4, column = 2 };
            Bin bin12 = new Bin { number = 12, color = "red", row = 4, column = 3 };
            Bin bin13 = new Bin { number = 13, color = "black", row = 5, column = 1 };
            Bin bin14 = new Bin { number = 14, color = "red", row = 5, column = 2 };
            Bin bin15 = new Bin { number = 15, color = "black", row = 5, column = 3 };
            Bin bin16 = new Bin { number = 16, color = "red", row = 6, column = 1 };
            Bin bin17 = new Bin { number = 17, color = "black", row = 6, column = 2 };
            Bin bin18 = new Bin { number = 18, color = "red", row = 6, column = 3 };
            Bin bin19 = new Bin { number = 19, color = "red", row = 7, column = 1 };
            Bin bin20 = new Bin { number = 20, color = "black", row = 7, column = 2 };
            Bin bin21 = new Bin { number = 21, color = "red", row = 7, column = 3 };
            Bin bin22 = new Bin { number = 22, color = "black", row = 8, column = 1 };
            Bin bin23 = new Bin { number = 23, color = "red", row = 8, column = 2 };
            Bin bin24 = new Bin { number = 24, color = "black", row = 8, column = 3 };
            Bin bin25 = new Bin { number = 25, color = "red", row = 9, column = 1 };
            Bin bin26 = new Bin { number = 26, color = "black", row = 9, column = 2 };
            Bin bin27 = new Bin { number = 27, color = "red", row = 9, column = 3 };
            Bin bin28 = new Bin { number = 28, color = "black", row = 10, column = 1 };
            Bin bin29 = new Bin { number = 29, color = "black", row = 10, column = 2 };
            Bin bin30 = new Bin { number = 30, color = "red", row = 10, column = 3 };
            Bin bin31 = new Bin { number = 31, color = "black", row = 11, column = 1 };
            Bin bin32 = new Bin { number = 32, color = "red", row = 11, column = 2 };
            Bin bin33 = new Bin { number = 33, color = "black", row = 11, column = 3 };
            Bin bin34 = new Bin { number = 34, color = "red", row = 12, column = 1 };
            Bin bin35 = new Bin { number = 35, color = "black", row = 12, column = 2 };
            Bin bin36 = new Bin { number = 36, color = "red", row = 12, column = 3 };
            Bin[] binArr = {bin0, bin1, bin2, bin3, bin4, bin5, bin6, bin7, bin8, bin9, bin10, bin11, bin12, bin13, bin14,
                            bin15, bin16, bin17, bin18, bin19, bin20, bin21, bin22, bin23, bin24, bin25, bin26, bin27, bin28,
                            bin29, bin30, bin31, bin32, bin33, bin34, bin35, bin36, bin00};
            return binArr;
        }
    }
}
