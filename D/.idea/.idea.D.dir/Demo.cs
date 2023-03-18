using System;
namespace DefaultNamespace;

public class Demo
{
    public string str;
    public int num;
    
    public void PrintDemo()
    {
        Console.Write($"{str} {num}\n");
    }

    public Democlass()
    {
        Console.Write("Создание объекта класса\n");
        str = "null";
        num = 0;
    }
    public Democlass(string n, int a)
    {
        str = n;
        num = a;
    }
    
    ~Democlass()
    {
        Console.Write($"Удаление объекта класса");
    }
}