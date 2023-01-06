using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //set variable
            int step = 0;
            string[,] table = new string[8, 8];
            string[] OX = { "O", "X" };
            string input;
            int col, row;

            //initialize table
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    table[i, j] = "-";
                }
            }
            //Game Start!
            while (step <= 64)
            {
                //clear table
                Console.Clear();
                //print table
                Console.WriteLine("  A B C D E F G H");
                for (int i = 0; i < 8; i++)
                {
                    Console.Write(i + 1);
                    for (int j = 0; j < 8; j++)
                    {
                        Console.Write(" " + table[i, j]);

                    }
                    Console.WriteLine();
                }
                //End
                if(step == 64)
                {
                    int onumber = 0;
                    //calculate 
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (table[i, j] == "O")
                                onumber++;
                        }
                    }
                    if (onumber > 32)
                        Console.WriteLine("遊戲結束 玩家O獲勝!");
                    else
                        Console.WriteLine("遊戲結束 玩家X獲勝!");
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("輪到玩家{0} 請輸入要下的位置:", OX[step % 2]);
                input = Console.ReadLine();
                row = input[0] - 'A';
                col = input[1] - '1';
                // 重疊
                if (table[col, row] != "-")
                {
                    Console.WriteLine("此位置已有棋子! 按任意鍵繼續遊戲");
                    Console.ReadKey();
                }
                else
                {
                    table[col, row] = OX[step % 2];
                    //check row
                    for (int i = 0; i < col; i++)
                    {
                        if (table[i, row] == OX[step % 2]) //pair
                        {
                            for (int j = i + 1; j < col; j++)
                            {
                                if (table[j, row] == OX[(step + 1) % 2])
                                    table[j, row] = OX[step % 2];
                            }
                            break;
                        }
                    }
                    for (int i = 7; i > col; i--)
                    {
                        if (table[i, row] == OX[step % 2]) //pair
                        {
                            for (int j = i - 1; j > col; j--)
                            {
                                if (table[j, row] == OX[(step + 1) % 2])
                                    table[j, row] = OX[step % 2];
                            }
                            break;
                        }
                    }
                    //check column
                    for (int i = 0; i < row; i++)
                    {
                        if (table[col, i] == OX[step % 2]) //pair
                        {
                            for (int j = i + 1; j < row; j++)
                            {
                                if (table[col, j] == OX[(step + 1) % 2])
                                {
                                    table[col, j] = OX[step % 2];
                                }
                            }
                            break;
                        }
                    }
                    for (int i = 7; i > row; i--)
                    {
                        if (table[col, i] == OX[step % 2]) //pair
                        {
                            for (int j = i - 1; j > row; j--)
                            {
                                if (table[col, j] == OX[(step + 1) % 2])
                                {
                                    table[col, j] = OX[step % 2];
                                }
                            }
                            break;
                        }
                    }
                    step++;
                }
            }//while
        } //Main
    }
}
