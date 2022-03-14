using System;

namespace B10756051_1
{
    class Program
    {
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
                    Console.WriteLine("成功退出！");
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
                    Console.WriteLine("查無此座號！\n");
                }
            }
        }
    }
}