using System;
namespace ConsoleApp1;

public class Help
{
    public static void Main(string[] args)
    {
        //2.1
        
        //1 ZADANIE
        /*int cnt = 0;
        string a = "abc";
        string b = "aabbccddff";
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                if (a[i] == b[j])
                {
                    cnt++;
                }
            }
        }
        Console.WriteLine(cnt);*/
        //3 ZADANIE
        /*int[] nums = {1, 5, 6, 1};
        bool vanga = false;
        int cnt = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }
                if (nums[i] == nums[j])
                {
                    cnt++;
                }
            }
            if (cnt > 1)
            {
                vanga = true;
                break;
            }
        }
        Console.Write(vanga);
        */
        //2 ZADANIE
        /*
        int[] candidates = {1, 2, 3, 4, 5};
        int target = 5;
        int sum = 0;
        List<int> resultat = new List<int>();
        for (int i = 0; i < candidates.Length; ++i)
        {
            resultat.Clear();
            sum = 0;
            for (int j = 0; j < candidates.Length; ++j)
            {
                if (i != j)
                {
                    sum += candidates[j];
                    resultat.Add(candidates[j]);
                }
                if (sum > target)
                {
                    break;
                }
                else if (sum == target)
                {
                    foreach (var element in resultat)
                    {
                        Console.Write($"[{element}]");
                    }
                    Console.WriteLine("");
                    break;
                }
            }
        }
        */
        
        
        //2.2
        
        //ZADANIE 1
        /*Student student = new Student();
        void ChangeInfo()
        {
            const int n = 5;
            Console.WriteLine("Write Surname: ");
            string a = Console.ReadLine();
            Console.WriteLine("Write date: ");
            string b = Console.ReadLine();
            Console.WriteLine("Write number of group: ");
            int group = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write markes: ");
            int[] grades = new int[n];
            for (int i = 0; i < n; i++)
            {
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }
            student.Redactor(a, b, group, grades);
        }
        Console.WriteLine("1.Check info: \n2. Edit info: ");
        int a = Convert.ToInt32(Console.ReadLine());
        switch (a)
        {
           case 1:
               student.Info();
               break;
           case 2:
               ChangeInfo();
               student.Info();
               break;
        }*/
        //ZADANIE 2
        /*
        Train trains = new Train();
        Console.WriteLine("Write number train: ");
        int a = Convert.ToInt32(Console.ReadLine());
        bool vanga = false;
        for (int i = 0; i < trains.NumberOfTrains.Lenght; i++)
        {
            if (a == trains.NumberOfTrains[i])
            {
                trains.Info(i);
                vanga = true;
            }
        }
        if (!vanga)
        {
            Console.WriteLine("Такого поезда нет");
        }
        */
        //ZADANIE 3 
        /*Nums number = new Nums();
        number.EditNums();
        number.NumsSumma();
        number.CheckNums();*/
        //ZADANIE 4
        /*
        Cnt a = new Cnt();
        a.CheckCnt();
        a.SetCnt();
        a.CheckCnt();
        while (a.cnt < 10)
        {
            Console.WriteLine("Cnt");
            a.PlusCnt();
        }
        */
        //ZADANIE 5
        /*
        Democlass demo = new Democlass();
        demo.PrintDemo();
        Democlass demos = new Democlass("ky", 123);
        demos.PrintDemo();
        */
        
        // 2.3
        
        //ZADANIE 1
        /*
        Worker1 first = new Worker1("Ivan", "Yakovlev", 1200, 30);
        first.GetSalary();
        */
        // Задание 2
        /*
        Worker2 first = new Worker2("Grouv", "Sidjaq", 1500, 28);
        Console.Write($"Зп: {first.GetSalary()}");
        */
        // Задание 3
        /*
        Calculation first = new Calculation();
        first.SetCalculationLine();
        Console.WriteLine(first.GetCalculationLine());
        Console.WriteLine(first.GetLastSymbol());
        first.SetLastSymbolCalculationLine('f');
        Console.WriteLine(first.GetCalculationLine());
        first.DeleteLastSymbol();
        Console.WriteLine(first.GetCalculationLine());
        */
        
        // 2.4
        /*
        string str = "MCMXCIV";
        int summa = 0;
        str = "!" + str + "=";
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == 'I')
            {
                if (str[i + 1] == 'V')
                {
                    summa += 4;
                }
                else if(str[i] == 'X')
                {
                    summa += 9;
                }
                else
                {
                    summa++;
                }
            }
            else if (str[i] == 'V' && str[i - 1] != 'I')
            {
                summa += 5;
            }
            else if (str[i] == 'X')
            {
                if (str[i + 1] == 'L')
                {
                    summa += 40;
                }
                else if (str[i + 1] == 'C')
                {
                    summa += 90;
                }
                else if(str[i - 1] != 'I')
                {
                    summa += 10;
                }
            }
            else if (str[i] == 'L' && str[i - 1] != 'X')
            {
                sum += 50;
            }
            else if (str[i] == 'C')
            {
                if (str[i + 1] == 'D')
                {
                    sum += 400;
                }
                else if (str[i + 1] == 'M')
                {
                    sum += 900;
                }
                else if(str[i - 1] != 'X')
                {
                    sum += 100;
                }
            }
            else if (str[i] == 'D' && str[i - 1] != 'C')
            {
                sum += 500;
            }
            else if (str[i] == 'M' && str[i - 1] != 'C')
            {
                sum += 1000;
            }
        
            if (str[i] == '=')
            {
                break;
            }
        }
        Console.WriteLine(sum);
        */
    }
}