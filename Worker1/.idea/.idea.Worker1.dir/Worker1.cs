using System;
namespace DefaultNamespace;

public class Worker1
{
    string Name;
    string Surname;
    int Rate;
    int Days;
    public Worker1(string name, string surname, int rate, int day)
    {
        name = name;
        surname = surname;
        rate = rate;
        days = day;
    }
    public void GetSalary()
    {
        Console.Write($"Зарплата {name} {surname} равна : {rate * days}");
    }
}
}