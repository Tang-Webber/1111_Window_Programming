using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2_1
{
    class Program
    {
        struct curr
        {
            public string name;
            public bool exist;
        };

        static void Main(string[] args)
        {
            //set variable
            string input; //input temp name
            string newclass;
            int func = 0;
            string temp;
            int credits = 0;
            int week, start, end;
            bool legal = true;

            //set class list
            curr[,] myclass = new curr[7,8];
            for (int i = 0; i < 7; i++) //initialization
            {
                for (int j = 0; j < 8; j++)
                {
                    myclass[i, j].exist = false;
                }
            }

            while (func != 5) //start command
            {
                Console.WriteLine("(1)新增課程 (2)刪除課程 (3)列印課表 (4)計算學分 (5)離開程式 ");
                Console.Write("請輸入數字選擇功能: ");
                func = int.Parse(Console.ReadLine());

                if (func == 1)
                {
                    legal = true;
                    Console.WriteLine("請輸入要加入的課程，格式為<課程代號 星期 開始節 結束節>");
                    input = Console.ReadLine();
                    string[] words = input.Split(' ');
                    newclass = words[0];
                    week = int.Parse(words[1]);
                    start = int.Parse(words[2]);
                    end = int.Parse(words[3]);

                    //檢查重複
                    for (int i = 0; i < 7; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (string.Compare(newclass, myclass[i, j].name) == 0)
                            {
                                Console.WriteLine("課程重複!");
                                legal = false;
                                break;
                            }
                        }
                    }

                    //檢查衝堂
                    for (int i = start - 1; i < end; i++)
                    {
                        if (myclass[week - 1, i].exist == true)
                        {
                            Console.WriteLine("課程衝堂!");
                            legal = false;
                            break;
                        }
                    }

                    if (legal == true) // 新增課程
                    {
                        for (int i = start - 1; i < end; i++)
                        {
                            myclass[week - 1, i].name = newclass;
                            myclass[week - 1, i].exist = true;
                        }
                        Console.WriteLine("成功加入課程!");
                    }
                }

                if (func == 2)
                {
                    legal = false;
                    Console.Write("請輸入要刪除的課程代號:");
                    input = Console.ReadLine();
                    for (int i = 0; i < 7; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (string.Compare(input, myclass[i, j].name) == 0)
                            {
                                myclass[i, j].name = "";
                                myclass[i, j].exist = false;
                                legal = true;
                            }
                        }
                    }
                    if (legal == false)
                        Console.WriteLine("課程 {0} 不在課表中", input);
                    if (legal == true)
                        Console.WriteLine("成功刪除課程: {0}", input);
                }
                if (func == 3)
                {
                    Console.WriteLine("      Sun   Mon   Tue   Wen   Thu   Fri   Sat   ");
                    for (int i = 0; i < 8; i++)
                    {
                        Console.Write((i + 1) + "     ");
                        if (myclass[6, i].exist == true)
                            Console.Write(myclass[6, i].name + " ");
                        if (myclass[6, i].exist == false)
                            Console.Write("      ");
                        for (int j = 0; j < 6; j++)
                        {
                            if (myclass[j, i].exist == true)
                                Console.Write(myclass[j, i].name + " ");
                            else
                                Console.Write("      ");
                        }
                        Console.WriteLine();
                    }
                }
                if (func == 4)
                {
                    credits = 0;
                    for (int i = 0; i < 7; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (myclass[i, j].exist == true)
                                credits++;
                        }
                    }
                    Console.WriteLine(credits);
                }

                Console.WriteLine();
            }

        }
    }
}
