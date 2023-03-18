using System;
namespace DefaultNamespace;

public class Worker2
{
    private string name;
    public string Name
    {
        get
        {
            return name;
        }
    }
    private string surname;
    public string Surname
    {
        get
        {
            return surname;
        }
    }
    private int rate;
    public int Rate
    {
        get
        {
            return rate;
        }
    }
    private int days;
    public int Days
    {
        get
        {
            return days;
        }
    }
    public Worker2(string name, string surname, int rate, int day)
    {
        name = name;
        surname = surname;
        rate = rate;
        days = day;
    } 
    public int GetSalary()
    {
        return rate * days;
    }
}

}