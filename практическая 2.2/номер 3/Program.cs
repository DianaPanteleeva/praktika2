using System;

class Numbers
{
    private int[] numbers;

    public Numbers(params int[] nums)
    {
        numbers = nums;
    }

    public void Print()
    {
        Console.Write("Numbers: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();
    }
    public void ChangeNumbers(params int[] nums)
    {
        numbers = nums;
    }

    public int Sum()
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        return sum;
    }

    public int MaxNum()
    {
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                {
                    max = num;
                }
            }
        }

        return max;
    }
}

class Program
{
    static void Main()
    {
        Numbers numbers = new Numbers(10, 100, 1);
        Console.WriteLine("Initial numbers: ");
        numbers.Print();
        
        Console.WriteLine("\nThe sum of the numbers: " + numbers.Sum());
        Console.WriteLine("\nThe maximum number: " + numbers.MaxNum());
        
        numbers.ChangeNumbers(20, 25, 30);
    }
}