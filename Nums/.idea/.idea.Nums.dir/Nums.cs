using System;
namespace DefaultNamespace;

public class Nums
{
    int a;
    int b;
    public void PrintNums()
    {
        Console.Write($"{a}; {b}");
    }
    public void EditNums()
    {
        Console.Write("a = ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = ");
        b = Convert.ToInt32(Console.ReadLine());
    }
    public void NumsSumma()
    {
        Console.Write($"{a} + {b} = {a + b}");
    }
    public void CheckNums()
    {
        if (a > b)
        {
            Console.Write($"{a} > {b}\n");
        }
        else if (a < b)
        {
            Console.Write($"{a} < {b}\n");
        }
        else
        {
            Console.Write($"{a} = {b}\n");
        }
    }
}