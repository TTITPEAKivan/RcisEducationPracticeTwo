using System;
namespace DefaultNamespace;

public class Calculation
{
    string calculationLine;
    public void SetCalculationLine()
    {
        Console.Write("Write stroka: ");
        calculationLine = Console.ReadLine();
    }
    public void SetLastSymbolCalculationLine(char symbol)
    {
        calculationLine = calculationLine + symbol;
    }
    public string GetCalculationLine()
    {
        return calculationLine;
    }
    public char GetLastSymbol()
    {
        return calculationLine[calculationLine.Length - 1];
    }
    public void DeleteLastSymbol()
    {
        char symbol = calculationLine[calculationLine.Length - 1];
        calculationLine = calculationLine.TrimEnd(symbol);
    }
}