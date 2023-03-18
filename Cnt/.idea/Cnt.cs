using System;
namespace DefaultNamespace;

public class Cnt
{
    public int cnt = 0;
    public void SetCnt()
    {
        cnt = Convert.ToInt32(Console.ReadLine());
    }
    public void CheckCnt()
    {
        Console.Write($"Счётчик: {cnt}\n");
    }
    public void PlusCnt()
    {
        cnt++;
    }
    public void MinusCnt()
    {
        cnt--;
    }
}