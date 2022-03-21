using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace B10756051_1
{
    class Program
    {
        //0321+
        static private int Add(int a, int b)
        {
            return a + b;
        }

        static private int MyRandom(int minNum, int maxNum)
        {
            Random random = new Random();

            return random.Next(minNum, maxNum + 1);
        }

        static void Main(string[] args)
        {
            //0307 作業
            Console.WriteLine("餐費100元，服務費15%，稅8%：");
            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;

            double tip = tip_percent * 0.01;
            double tax = tax_percent * 0.01;

            double totle = meal_cost + meal_cost * tip + (meal_cost + meal_cost * tip) * tax;
            Console.WriteLine(totle);



            //0314 練習1
            Console.Write("\n\n請輸入數字：");
            string input = Console.ReadLine();
            int inputInt = int.Parse(input);

            if (inputInt % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if (inputInt >= 2 && inputInt <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (inputInt >= 6 && inputInt <= 20)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                Console.WriteLine("Not Weird");
            }

            //0314 練習2
            Console.Write("\n\n請輸入數字：");
            input = Console.ReadLine();
            inputInt = int.Parse(input);

            for (int i = 0; i < inputInt; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



            //0314 練習3
            Console.Write("\n\n請輸入數字：");
            input = Console.ReadLine();
            inputInt = int.Parse(input);

            for (int i = 1; i <= 3; i++)
            {
                int num = inputInt * i;
                //Console.WriteLine(inputInt + "*" + i + "=" + inputInt * i);
                Console.WriteLine($"{inputInt} * {i} = {num}");
            }



            //0314 練習4
            Console.WriteLine("\n九九乘法表：");
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    int num = i * j;
                    Console.Write($"{j} * {i} = {num, 2}    ");
                }
                Console.WriteLine();
            }



            //0314 練習5
            int[] sNo = { 1, 2, 3, 4, 5 };
            string[] sName = { "Jack", "Mary", "Tom", "Grace", "Alice" };
            int[] computerScore = { 80, 65, 100, 98, 83 };
            int[] progamScore = { 75, 67, 93, 25, 82 };
            int[] animationScore = { 60, 62, 91, 50, 87 };

            while ( true )
            {
                Console.WriteLine("\n\n請輸入座號(1~5)查詢成績, 輸入\"0\"退出。");
                input = Console.ReadLine();
                int inputStudenNo = int.Parse(input);
                int arrayIndex = Array.IndexOf(sNo, inputStudenNo);

                if (inputStudenNo == 0)
                {
                    Console.WriteLine("成功退出！\n");
                    break;
                }

                if (arrayIndex > -1)
                {
                    Console.WriteLine($"姓名：{sName[arrayIndex]}");
                    Console.WriteLine($"電腦概論：{computerScore[arrayIndex]}分");
                    Console.WriteLine($"程式設計：{progamScore[arrayIndex]}分");
                    Console.WriteLine($"動畫設計：{animationScore[arrayIndex]}分");
                }
                else
                {
                    Console.WriteLine("查無此座號！");
                }
            }



            //0321 練習1
            Hiro hiro1 = new Hiro();
            hiro1.Showhiroinfo();

            while(true)
            {
                Console.WriteLine("\n要進行什麼操作(1~2.使用技能, 0.退出遊戲):");
                input = Console.ReadLine();
                int inputxuanxiang = int.Parse(input);

                if (inputxuanxiang == 1)
                {
                    hiro1.Usehiroskill_01();
                }
                else if (inputxuanxiang == 2)
                {
                    hiro1.Usehiroskill_02();
                }
                else if (inputxuanxiang == 0)
                {
                    Console.WriteLine("遊戲結束!\n");
                    break;
                }
            }



            //0321 練習2

            


            //0321練習3
            int leaveCnt = 5;
            int minRange = 0, maxRange = 100;
            int ans = MyRandom(minRange, maxRange);

            while (leaveCnt > 0)
            {
                Console.WriteLine($"\n剩餘次數:{leaveCnt}次");
                leaveCnt--;
                Console.Write("\n請猜測數字:");
                int guess = int.Parse(Console.ReadLine());

                if(leaveCnt == 0 & guess != ans)
                {
                    Console.WriteLine($"\n剩餘次數:{leaveCnt}次");
                    Console.WriteLine($"\n*****很遺憾，失敗了! 答案是{ans}，下次請繼續努力!*****\n\n");
                    break;
                }

                if (guess == ans)
                {
                    Console.WriteLine($"\n剩餘次數:{leaveCnt}次");
                    Console.WriteLine("*****恭喜你答對了!*****\n\n");
                    break;
                }

                else if(guess > ans)
                {
                    maxRange = guess;
                    Console.WriteLine($"答案介於{minRange}到{maxRange}之間。");
                }

                else if (guess < ans)
                {
                    minRange = guess;
                    Console.WriteLine($"答案介於{minRange}到{maxRange}之間。");
                }
            }



            //0321練習4
            IFileService fileService = new FileServiceA();
            fileService.UploadFile();
        }
    }
}