using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_1
{
    class Program
    {
        struct item
        {
            public string name;
            public int amount;
            public bool exist;
        };

        static void Main(string[] args)
        {
            //set variable
            string newname; //input temp name
            int money = 0, expesum = 0, temp; 
            int func = 0, num = 0; // func:option of function  num:option of expenses  
            //set item list
            item[] expe = new item[5]; 
            for(int i = 0; i < 5; i++) //initialization
            {
                expe[i].exist = false;
                expe[i].amount = 0;
            }
            
            while(func != 8) //start command
            {
                Console.WriteLine("(1)輸入收入 (2)輸入支出 (3)新增項目 (4)刪除項目 (5)計算比例 (6)查詢支出 (7)剩餘金額 (8)退出程式");
                Console.Write("輸入數字選擇功能: ");
                func = int.Parse(Console.ReadLine());
                
                if (func == 1)
                {
                    Console.Write("輸入金額: ");
                    try
                    {
                        temp = int.Parse(Console.ReadLine());
                        if (temp < 0)
                            Console.WriteLine("收入不可為負數");
                        else
                            money += temp;
                    }
                    catch
                    {
                        Console.WriteLine("請輸入數字");
                    }
                }
                if (func == 2)
                {
                    if (expe[0].exist == true) // at least one expense
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (expe[i].exist == false)
                                break;
                            Console.Write("(" + (i + 1) + ")" + expe[i].name + " ");
                        }
                        Console.WriteLine();

                        Console.Write("輸入數字選擇支出項目: ");
                        num = int.Parse(Console.ReadLine()) - 1;
                        if (num < 5 && num >= 0 && expe[num].exist == true)
                        {
                            Console.Write("輸入金額: ");
                            temp = int.Parse(Console.ReadLine());
                            if (temp <= money) 
                            {
                                expe[num].amount += temp;
                                expesum += temp;
                                money -= temp;
                            }
                            else
                                Console.Write("存款不足");
                        }
                        else
                            Console.Write("此數字不在範圍中");
                    }
                    else
                        Console.WriteLine("請新增支出項目");
                }
                if (func == 3)
                {
                    if (expe[4].exist == true)
                    {
                        Console.WriteLine("已無法再新增支出項目");
                    }
                    else
                    {
                        Console.Write("輸入項目名稱: ");
                        newname = Console.ReadLine();
                        for (int i = 0; i < 5; i++)
                        {
                            if (string.Compare(newname, expe[i].name) == 0)
                            {
                                Console.WriteLine("支出項目已存在");
                                break;
                            }
                            if (expe[i].exist == false)
                            {
                                expe[i].name = newname;
                                expe[i].exist = true;
                                break;
                            }
                        }
                    }
                }
                if (func == 4)
                {
                    if (expe[0].exist == false)
                    {
                        Console.WriteLine("已無法再刪除支出項目");
                    }
                    else
                    {
                        Console.Write("輸入項目名稱: ");
                        newname = Console.ReadLine();
                        for (int i = 0; i < 5; i++)
                        {
                            if (expe[i].exist == false)
                            {
                                Console.WriteLine("此項目不存在");
                                break;
                            }

                            if (string.Compare(newname, expe[i].name) == 0)
                            {
                                expesum -= expe[i].amount;
                                money += expe[i].amount;
                                for (int j = i; j < 4; j++)
                                {
                                    expe[j].name = expe[j + 1].name;
                                    expe[j].amount = expe[j + 1].amount;
                                    if (expe[j + 1].exist == false)
                                    {
                                        expe[j].name = "";
                                        expe[j].amount = 0;
                                        expe[j].exist = false;
                                        break;
                                    }
                                }
                                expe[4].name = "";
                                expe[4].amount = 0;
                                expe[4].exist = false;
                                break;
                            }
                        }
                        if (expe[4].exist == true)
                            Console.WriteLine("此項目不存在");
                    }
                 }
                if (func == 5)
                {
                    if(expesum == 0) {
                        for (int i = 0; i < 5; i++)
                        {
                            if (expe[i].exist == false)
                                break;
                            Console.WriteLine("(" + (i + 1) + ")" + expe[i].name + ": 0%");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (expe[i].exist == false)
                                break;
                            Console.WriteLine("(" + (i + 1) + ")" + expe[i].name + ": " + expe[i].amount * 100 / (double)expesum + "%");
                        }
                    }
                }
                if (func == 6)
                {
                    Console.WriteLine("目前總支出: " + expesum);
                    Console.Write("輸入要查詢的項目: ");
                    newname = Console.ReadLine();
                    for (int i = 0; i < 5; i++)
                    {
                        if (expe[i].exist == false)
                        {
                            Console.WriteLine("此項目不存在");
                            break;
                        }
                        if (string.Compare(newname, expe[i].name) == 0)
                        {
                            Console.WriteLine(expe[i].name + ": " + expe[i].amount);
                            break;
                        }
                        if (i == 4 && string.Compare(newname, expe[4].name) != 0)
                            Console.WriteLine("此項目不存在");
                    }
                }
                if (func == 7)
                    Console.WriteLine("剩餘金額為: " + money);

                Console.WriteLine();
            };
        }
    }
}
