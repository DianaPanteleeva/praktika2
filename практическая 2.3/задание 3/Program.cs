using System;

class Calculation
{
    private string calculationLine;

    public Calculation()
    {
        calculationLine = "";
    }

    public void SetCalculationLine(string line)
    {
        calculationLine = line;
    }

    public void SetLastSymbolCalculationLine(char symbol)
    {
        calculationLine += symbol;
    }

    public string GetCalculationLine()
    {
        return calculationLine;
    }

    public char GetLastSymbol()
    {
        if (!string.IsNullOrEmpty(calculationLine))
        {
            return calculationLine[calculationLine.Length - 1];
        }
        else
        {
            throw new InvalidOperationException("The calculationLine line is empty.");
        }
    }

    public void DeleteLastSymbol()
    {
        if (!string.IsNullOrEmpty(calculationLine))
        {
            calculationLine = calculationLine.Substring(0, calculationLine.Length - 1);
        }
        else
        {
            throw new InvalidOperationException("The calculationLine line is empty.");
        }
    }
}

class Program
{
    static void Main()
    {
        Calculation calc = new Calculation();
        calc.SetCalculationLine("2 + 7 ");

        
        calc.SetLastSymbolCalculationLine('=');

        
        Console.WriteLine("Calculation String : " + calc.GetCalculationLine());

        
        Console.WriteLine("The last character: " + calc.GetLastSymbol());

        
        calc.DeleteLastSymbol();

        
        Console.WriteLine("Modified calculation string: " + calc.GetCalculationLine());
    }
}