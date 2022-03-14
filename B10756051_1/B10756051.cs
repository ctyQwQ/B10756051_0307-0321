using System;

namespace B10756051_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //0307 作業
            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;

            double totle = meal_cost * 1.15 * 1.08;
            Console.WriteLine(totle);



            //0314 練習1
            Console.Write("\n請輸入數字:");
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
            Console.Write("\n請輸入數字:");
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
            Console.Write("\n請輸入數字:");
            input = Console.ReadLine();
            inputInt = int.Parse(input);

            for (int i = 1; i <= 3; i++)
            {
                int num = inputInt * i;
                //Console.WriteLine(inputInt + "*" + i + "=" + inputInt * i);
                Console.WriteLine($"{inputInt} * {i} = {num}");
            }

            //0314 練習4
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine(i + "*" + j + "=" + i * j);
                }
                Console.WriteLine();
            }

            //0314 練習5
            int[] studenNo = { 1, 2, 3, 4, 5 };
            string[] studenName = { "Jack", "Mary", "Tom", "Grace", "Alice" };
            int[] computerScore = { 80, 65, 100, 98, 83 };
            int[] progamScore = { 75, 67, 93, 25, 82 };
            int[] animationScore = { 60, 62, 91, 50, 87 };

            while (true)
            {
                Console.WriteLine("請輸入座號(1~5):");
                input = Console.ReadLine();
                int inputStudenNo = int.Parse(input);
                int arrayIndex = Array.IndexOf(studenNo, inputStudenNo);
                if (arrayIndex > -1)
                {
                    Console.WriteLine($"姓名:{studenName[arrayIndex]}");
                    Console.WriteLine($"電腦概論:{computerScore[arrayIndex]}");
                    Console.WriteLine($"程式設計:{progamScore[arrayIndex]}");
                    Console.WriteLine($"動畫設計:{animationScore[arrayIndex]}");
                }
                else
                {
                    Console.WriteLine("沒有這個座號");
                }
            }
        }
    }
}